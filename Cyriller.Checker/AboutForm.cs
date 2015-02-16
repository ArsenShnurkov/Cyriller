using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cyriller.Checker
{
    public partial class AboutForm : UserControl
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void lblEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:" + lblEmail.Text);
        }

        private void lblWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(lblWebsite.Text);
        }
    }
}
