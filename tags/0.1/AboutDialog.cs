using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace GVDialer
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();

            var assembly = Assembly.GetExecutingAssembly();
            var version = assembly.GetName().Version;

            mVersionLabel.Text += string.Format("{0}.{1}", version.Major, version.Minor);
            if (version.Build > 0)
            {
                mVersionLabel.Text += string.Format(".{0}", version.Build);
            }

            if (version.Revision > 0)
            {
                mVersionLabel.Text += string.Format(" (revision {0})", version.Revision);
            }
        }

        private void HandleOkClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void HandleLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Control control = (Control)sender;
            Process.Start(control.Text);
        }
    }
}
