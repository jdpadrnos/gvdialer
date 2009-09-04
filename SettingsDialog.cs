using System;
using System.Windows.Forms;

namespace GVDialer
{
    public partial class SettingsDialog : Form
    {
        public SettingsDialog()
        {
            InitializeComponent();

            mEmailBox.Text = Properties.Settings.Default.Email;
            mPasswordBox.Text = Properties.Settings.Default.Password;
            mCallbackBox.Text = Properties.Settings.Default.CallbackNumber;
        }

        private void HandleFormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                Properties.Settings.Default.Email = mEmailBox.Text;
                Properties.Settings.Default.Password = mPasswordBox.Text;
                Properties.Settings.Default.CallbackNumber = mCallbackBox.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void HandleOkClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
