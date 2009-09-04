using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GVDialer
{
    public partial class SMSDialog : Form
    {
        public SMSDialog(string recipient)
        {
            InitializeComponent();
            mToLabel.Text += recipient;
        }

        public string Message
        {
            get
            {
                return mMessageBox.Text;
            }
        }

        private void HandleOkClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
