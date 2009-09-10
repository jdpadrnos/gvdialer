using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GVDialer
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
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
