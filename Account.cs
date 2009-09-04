using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GoogleVoice
{
    class Account
    {
        string _user;
        string _password;

        bool _loggedin;
        CookieContainer _cookies;
        string _rnr;

        static string LogonUrl = "https://www.google.com/accounts/ServiceLoginAuth";
        static string LogoutUrl = "https://www.google.com/voice/account/signout";
        static string MainUrl = "https://www.google.com/voice";
        static string CallUrl = "https://www.google.com/voice/call/connect";
        static string SMSUrl = "https://www.google.com/voice/sms/send";
        static string InboxUrl = "https://www.google.com/voice/inbox/recent/inbox/";
        static string AllCallsUrl = "https://www.google.com/voice/inbox/recent/all/";
        static string StarredCallsUrl = "https://www.google.com/voice/inbox/recent/starred/";
        static string SpamUrl = "https://www.google.com/voice/inbox/recent/spam/";
        static string TrashUrl = "https://www.google.com/voice/inbox/recent/trash/";
        static string VoicemailUrl = "https://www.google.com/voice/inbox/recent/voicemail/";
        static string SMSMessagesUrl = "https://www.google.com/voice/inbox/recent/sms/";
        static string RecordedCallsUrl = "https://www.google.com/voice/inbox/recent/recorded/";
        static string PlacedCallsUrl = "https://www.google.com/voice/inbox/recent/placed/";
        static string ReceivedCallsUrl = "https://www.google.com/voice/inbox/recent/received/";
        static string MissedCallsUrl = "https://www.google.com/voice/inbox/recent/missed/";
        static string ContactsUrl = "https://www.google.com/voice/inbox/recent/contacts/";
        static Uri CookieUri = new Uri("https://www.google.com");

        static string RNRStartString = "<input name=\"_rnr_se\" type=\"hidden\" value=";
        static string RNREndString = "\"/>";
        static int SMSLength = 159;

        public Account(string user, string password)
        {
            _user = user;
            _password = password;

            _loggedin = false;
            _cookies = null;
            _rnr = null;
        }

        public bool Login()
        {
            if (_loggedin)
            {
                return true;
            }

            _cookies = new CookieContainer();

            var data = string.Format("Email={0}&Passwd={1}", 
                HttpUtility.UrlEncode(_user), HttpUtility.UrlEncode(_password));
            var logonResponse = MakeRequest(LogonUrl, "POST", data);
            if (logonResponse.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(string.Format("Could not login: {0}", logonResponse.StatusCode));
            }

            _loggedin = true;

            try
            {
                var inboxResponse = MakeRequest(MainUrl, "GET", null);
                if (inboxResponse.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception(string.Format("Could not load Inbox: {0}", inboxResponse.StatusCode));
                }

                using (StreamReader inboxReader = new StreamReader(inboxResponse.GetResponseStream()))
                {
                    var inbox = inboxReader.ReadToEnd();

                    var startIndex = (inbox.IndexOf(RNRStartString) + RNRStartString.Length) + 1;
                    var endIndex = inbox.IndexOf(RNREndString, startIndex);
                    _rnr = inbox.Substring(startIndex, endIndex - startIndex);
                }
            }
            catch(Exception inner)
            {
                Logout();
                throw new Exception("Could not load Inbox", inner);
            }

            return _loggedin;
        }

        private JObject GetData(string url)
        {
            EnsureLoggedIn();

            var response = MakeRequest(url, "GET", null);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(string.Format("Could not load {0}: {0}", url, response.StatusCode));
            }

            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                var xml = reader.ReadToEnd();
                var document = new XmlDocument();
                document.LoadXml(xml);

                var json = document.SelectSingleNode("/response/json").FirstChild.InnerText;

                using (var stringReader = new StringReader(json))
                {
                    using (var jsonReader = new JsonTextReader(stringReader))
                    {
                        return JObject.Load(jsonReader);
                    }
                }
            }
        }

        private void EnsureLoggedIn()
        {
            if (!Login())
            {
                throw new Exception("Could not log into Google Voice account");
            }
        }

        static private string SanitizeNumber(string number)
        {
            var result = new StringBuilder();
            foreach (var c in number)
            {
                if (char.IsDigit(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        HttpWebResponse MakeRequest(string url, string method, string data)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.CookieContainer = _cookies;
            request.KeepAlive = false;
            request.ProtocolVersion = HttpVersion.Version10;
            request.Method = method;
            request.ContentType = "application/x-www-form-urlencoded";

            var cookieHeader = _cookies.GetCookieHeader(CookieUri);
            if (cookieHeader != string.Empty)
            {
                request.Headers.Add(HttpRequestHeader.Cookie, cookieHeader);
            }

            if (data != null)
            {
                var dataBuffer = Encoding.ASCII.GetBytes(data);
                request.ContentLength = dataBuffer.Length;

                var requestStream = request.GetRequestStream();
                requestStream.Write(dataBuffer, 0, dataBuffer.Length);
                requestStream.Close();
            }

            return (HttpWebResponse)request.GetResponse();
        }

        public bool Logout()
        {
            if (_loggedin)
            {
                var response = MakeRequest(LogoutUrl, "GET", null);
                var reader = new StreamReader(response.GetResponseStream());
                var text = reader.ReadToEnd();

                _cookies = null;
                _loggedin = false;
            }
            return true;
        }

        public void Dial(string dest, string source)
        {
            EnsureLoggedIn();

            var data = string.Format("outgoingNumber={0}&forwardingNumber={1}&_rnr_se={2}",
                HttpUtility.UrlEncode(SanitizeNumber(dest)), HttpUtility.UrlEncode(SanitizeNumber(source)), HttpUtility.UrlEncode(_rnr));
            var response = MakeRequest(CallUrl, "POST", data);
            VerifyCommand(response);
        }

        public void SMS(string dest, string message)
        {
            EnsureLoggedIn();

            var count = (int)Math.Ceiling(message.Length / (double)SMSLength);
            for (var i = 0; i < count; ++i)
            {
                var offset = i * SMSLength;
                var length = Math.Min(SMSLength, message.Length - offset);
                var splitMessage = message.Substring(offset, length);

                var data = string.Format("phoneNumber={0}&text={1}&_rnr_se={2}", 
                    HttpUtility.UrlEncode(SanitizeNumber(dest)), HttpUtility.UrlEncode(splitMessage), HttpUtility.UrlEncode(_rnr));
                var response = MakeRequest(SMSUrl, "POST", data);
                VerifyCommand(response);
            }
        }

        JObject VerifyCommand(HttpWebResponse response)
        {
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(string.Format("Bad response: {0}", response.StatusCode));
            }

            using (var stream = new StreamReader(response.GetResponseStream()))
            {
                using (var reader = new JsonTextReader(stream))
                {
                    var result = JObject.Load(reader);
                    if (!(bool)result["ok"])
                    {
                        throw new Exception(
                            string.Format("Bad status, code {0}", (int)result["data"]["code"]));
                    }
                    return result;
                }
            }
        }

        public JObject GetPlacedCalls()
        {
            return GetData(PlacedCallsUrl);
        }

        public JObject GetReceivedCalls()
        {
            return GetData(ReceivedCallsUrl);
        }

        public JObject GetMissedCalls()
        {
            return GetData(MissedCallsUrl);
        }

        public JObject GetAllCalls()
        {
            return GetData(AllCallsUrl);
        }

        public JObject GetVoicemails()
        {
            return GetData(VoicemailUrl);
        }

        public JObject GetSMSMessages()
        {
            return GetData(SMSMessagesUrl);
        }

        public JObject GetRecordedCalls()
        {
            return GetData(RecordedCallsUrl);
        }

        public JObject GetStarredCalls()
        {
            return GetData(StarredCallsUrl);
        }

        public JObject GetInboxCalls()
        {
            return GetData(InboxUrl);
        }

        public JObject GetSpamCalls()
        {
            return GetData(SpamUrl);
        }

        public JObject GetTrashCalls()
        {
            return GetData(TrashUrl);
        }

        public JObject GetContacts()
        {
            return GetData(ContactsUrl);
        }

        public void GetInboxUrl(out string url, out byte[] data, out string headers)
        {
            url = LogonUrl;

            var postData = string.Format("Email={0}&Passwd={1}",
                HttpUtility.UrlEncode(_user), HttpUtility.UrlEncode(_password));
            data = Encoding.ASCII.GetBytes(postData);

            headers = "Content-Type: application/x-www-form-urlencoded\r\n";
        }
    }
}
