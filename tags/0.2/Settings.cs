using System;
using System.Text;
using System.Security.Cryptography;

namespace GVDialer
{
    namespace Properties
    {
        internal sealed partial class Settings
        {
            static byte[] _entropy = { 65, 34, 87, 33 };

            public string Password
            {
                get
                {
                    if (this.EncryptedPassword == string.Empty)
                    {
                        return string.Empty;
                    }

                    var encrypted = Convert.FromBase64String(this.EncryptedPassword);
                    var data = ProtectedData.Unprotect(encrypted, _entropy, DataProtectionScope.CurrentUser);
                    var password = Encoding.UTF8.GetString(data);
                    return password;
                }
                set
                {
                    if (value == string.Empty)
                    {
                        this.EncryptedPassword = string.Empty;
                        return;
                    }

                    var data = Encoding.UTF8.GetBytes(value);
                    var encrypted = ProtectedData.Protect(data, _entropy, DataProtectionScope.CurrentUser);
                    var stored = Convert.ToBase64String(encrypted);
                    this.EncryptedPassword = stored;
                }
            }
        }
    }
}
