using System;
using System.Text;
using System.Windows.Forms;

namespace GVDialer
{
    public partial class ErrorDialog : Form
    {
        public ErrorDialog(string message, Exception exception)
        {
            InitializeComponent();

            mMessageLabel.Text = message;

            StringBuilder detail = new StringBuilder();
            while (exception != null)
            {
                detail.AppendLine(exception.Message);
                detail.AppendLine(exception.StackTrace);
                detail.AppendLine();

                exception = exception.InnerException;
            }
            mDetailLabel.Text = detail.ToString();
        }

        private void HandleDetailClick(object sender, EventArgs e)
        {
            ((Control)sender).Visible = false;
            mDetailLabel.Visible = true;
        }
    }
}
