using GoogleVoice;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace GVDialer
{
    public partial class MainScreen : Form
    {
        Account account;

        public MainScreen()
        {
            InitializeComponent();
            mPictureBox.Size = mPictureBox.Image.Size;

            this.account = null;
        }

        void ReportException(Exception exception, string format, params object[] parameters)
        {
            var message = string.Format(format, parameters);
            var dialog = new ErrorDialog(message, exception);
            dialog.ShowDialog();
        }

        private void Login()
        {
            var email = Properties.Settings.Default.Email;
            var password = Properties.Settings.Default.Password;

            if (email == string.Empty || password == string.Empty)
            {
                return;
            }

            this.account = new Account(email, password);
            try
            {
                this.account.Login();

                PopulateRecentCalls();
                PopulateRecentSMS();
                PopulateContacts();

                mCallMenuItem.Enabled = true;
                mSmsMenuItem.Enabled = true;
                mInboxMenuItem.Enabled = true;

                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
                mTrayIcon.Icon = global::GVDialer.Properties.Resources.ActiveIcon;
            }
            catch (Exception ex)
            {
                ReportException(ex, "There was an error logging into your Google voice account." +
                                    "  Please make sure that you have entered the correct email" +
                                    " address and password.");
                this.account = null;
            }
        }

        private void PopulateRecentCalls()
        {
            try
            {
                var placedCalls = this.account.GetPlacedCalls().Root.Element("messages").Elements();
                foreach (var call in placedCalls)
                {
                    AddRecent((string)call.Element("displayNumber"), (string)call.Element("phoneNumber"), mCallRecentMenuItem);
                }
            }
            catch (Exception ex)
            {
                ReportException(ex, "There was an error loading recent call list.");
            }
        }

        private void PopulateRecentSMS()
        {
            try
            {
                var sentSMSs = this.account.GetSMSMessages().Root.Element("messages").Elements();
                foreach (var sms in sentSMSs)
                {
                    AddRecent((string)sms.Element("displayNumber"), (string)sms.Element("phoneNumber"), mSmsRecentMenuItem);
                }
            }
            catch (Exception ex)
            {
                ReportException(ex, "There was an error loading recent SMS list.");
            }
        }

        private void PopulateContacts()
        {
            try
            {
                var data = this.account.GetContacts();
                var contacts = from contact in data.Root.Element("messages").Elements()
                               select contact.Elements().First();
                foreach (var contact in contacts)
                {
                    AddContact((string)contact.Element("displayNumber"), (string)contact.Element("phoneNumber"));
                }
            }
            catch (Exception ex)
            {
                ReportException(ex, "There was an error loading contact list.");
            }
        }

        private void Logout()
        {
            mCallMenuItem.Enabled = false;
            mSmsMenuItem.Enabled = false;
            mInboxMenuItem.Enabled = false;

            mCallRecentMenuItem.DropDownItems.Clear();
            mSmsRecentMenuItem.DropDownItems.Clear();

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            mTrayIcon.Icon = global::GVDialer.Properties.Resources.InactiveIcon;

            if (this.account != null)
            {
                this.account.Logout();
            }
        }

        private void Dial(string number)
        {
            try
            {
                this.account.Dial(number, Properties.Settings.Default.CallbackNumber);

                var formatted = FormatNumber(number);
                AddRecent(formatted, formatted, mCallRecentMenuItem);
            }
            catch (Exception ex)
            {
                ReportException(ex, "There was an error placing your call." +
                                    "  This may be caused by an incorrect callback number." +
                                    "  Make sure that your callback number matches one of the" +
                                    " phones registered to your Google Voice account.");
            }
        }

        private void SMS(string number)
        {
            var formatted = FormatNumber(number);
            var form = new SMSDialog(formatted);
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.account.SMS(number, form.Message);

                    AddRecent(formatted, formatted, mCallRecentMenuItem);
                }
                catch (Exception ex)
                {
                    ReportException(ex, "There was an error sending the SMS message.");
                }
            }
        }

        private void AddRecent(string caption, string number, ToolStripMenuItem parent)
        {
            foreach (ToolStripMenuItem item in parent.DropDownItems)
            {
                if (item.Text == caption)
                {
                    // Move to end of list
                    parent.DropDownItems.Remove(item);
                    parent.DropDownItems.Add(item);
                    return;
                }
            }

            var recent = CreateEntry(caption, number);
            parent.DropDownItems.Add(recent);
            parent.Enabled = true;

            if (parent.DropDownItems.Count > Properties.Settings.Default.RecentCount)
            {
                parent.DropDownItems.RemoveAt(0);
            }
        }

        private void AddContact(string caption, string number)
        {
            var call = CreateEntry(caption, number);
            mCallContactsMenuItem.DropDownItems.Add(call);
            mCallContactsMenuItem.Enabled = true;
            mCallContactsMenuItem.Visible = true;

            var sms = CreateEntry(caption, number);
            mSmsContactsMenuItem.DropDownItems.Add(sms);
            mSmsContactsMenuItem.Enabled = true;
            mSmsContactsMenuItem.Visible = true;
        }

        private ToolStripMenuItem CreateEntry(string caption, string number)
        {
            var entry = new ToolStripMenuItem(caption);
            entry.Tag = FormatNumber(number);
            entry.Click += new EventHandler(HandleEntryClick);
            return entry;
        }

        private static string FormatNumber(string number)
        {
            var result = new StringBuilder();
            foreach (var c in number)
            {
                if (char.IsDigit(c))
                {
                    result.Append(c);
                }
            }

            var numeric = result.ToString();
            var offset = -1;
            if( numeric.Length == 9)
            {
                offset = 0;
            }
            else if (numeric.Length == 10 && numeric[0] == '1')
            {
                offset = 1;
            }
            else
            {
                return number;
            }

            var area = numeric.Substring(offset, 3);
            var branch = numeric.Substring(offset + 3, 3);
            var final = numeric.Substring(offset + 3 + 3, 4);

            return string.Format("({0}) {1}-{2}", area, branch, final);
        }

        private void HandleShown(object sender, EventArgs e)
        {
            Login();
        }

        private void HandleSettingsClick(object sender, EventArgs e)
        {
            var form = new SettingsDialog();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Logout();
                Login();
            }
        }

        private void HandleExitClick(object sender, EventArgs e)
        {
            Logout();
            Close();
        }

        private void HandleEntryClick(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            string number = (string)item.Tag;

            if (item.OwnerItem.OwnerItem == mCallMenuItem)
            {
                Dial(number);
            }
            else
            {
                SMS(number);
            }
        }

        private void HandleBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var box = (ToolStripTextBox)sender;
                string number = box.Text;

                if (box.OwnerItem == mCallMenuItem)
                {
                    Dial(number);
                }
                else
                {
                    SMS(number);
                }
            }
        }

        private void HandleInboxClick(object sender, EventArgs e)
        {
            string url;
            byte[] data;
            string headers;
            this.account.GetInboxUrl(out url, out data, out headers);

            var form = new WebDialog(url, data, headers);
            form.Show();
        }

        private void HandleContextMenuOpening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mCallBox.Text = string.Empty;
            mSmsBox.Text = string.Empty;
        }

        private void HandleTimerTick(object sender, EventArgs e)
        {
            mTimer.Enabled = false;
            Hide();

            if (string.IsNullOrEmpty(Properties.Settings.Default.Email) ||
                string.IsNullOrEmpty(Properties.Settings.Default.Password))
            {
                var form = new SettingsDialog();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Logout();
                    Login();
                }
            }
        }

        private void HandleAboutClick(object sender, EventArgs e)
        {
            var form = new AboutDialog();
            form.ShowDialog();
        }
    }
}
