using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Inventory_System
{
    public partial class formAbout : Form
    {
        public formAbout()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://icons8.com");
            Process.Start(sInfo);
        }

        private void formAbout_Load(object sender, EventArgs e)
        {
            this.textBoxLicenseTo.Text = Properties.Settings.Default.license_to;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
