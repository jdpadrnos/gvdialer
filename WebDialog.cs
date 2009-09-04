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
    public partial class WebDialog : Form
    {
        public WebDialog(string url, byte[] data, string headers)
        {
            InitializeComponent();

            mWebBrowser.Navigate(url, null, data, headers);
        }
    }
}
