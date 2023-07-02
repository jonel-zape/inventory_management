using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class formSettings : Form
    {
        formLoading formLoading;
        string errorMessage;

        public formSettings()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (this.saveSettings())
            {
                MessageBox.Show("Settings Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid Code", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool saveSettings()
        {
            // inv12262021
            string authCode = "9d24b721031df3fd455b3502b3452c21c829bbbc38e1df78f2509766d0efb6aa";
            if (authCode != tools.hashString(textBoxAuthCode.Texts))
            {
                return false;
            }

            Properties.Settings.Default.host = textBoxHost.Texts;
            Properties.Settings.Default.username = textBoxUsername.Texts;
            Properties.Settings.Default.password = textBoxPassword.Texts;
            Properties.Settings.Default.db = textBoxDatabase.Texts;
            Properties.Settings.Default.Save();

            textBoxAuthCode.Texts = "";
            return true;
        }


        private void formSettings_Load(object sender, EventArgs e)
        {
            textBoxHost.Texts = Properties.Settings.Default.host;
            textBoxUsername.Texts = Properties.Settings.Default.username;
            textBoxPassword.Texts = Properties.Settings.Default.password;
            textBoxDatabase.Texts = Properties.Settings.Default.db;
        }

        private void buttonSetup_Click(object sender, EventArgs e)
        {
            if (!this.saveSettings())
            {
                MessageBox.Show("Invalid Code", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to deploy database?", "Confirm Deployment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.errorMessage = "";
                this.backgroundWorkerDeploy.RunWorkerAsync();
                this.formLoading = new formLoading("Deploying...");
                this.formLoading.ShowDialog();
            }
        }

        private void backgroundWorkerDeploy_DoWork(object sender, DoWorkEventArgs e)
        {
            deploy d = new deploy();
            if (!d.deployDatabase())
            {
                this.errorMessage = d.getErrorMessage();
            }
        }

        private void backgroundWorkerDeploy_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.formLoading.Close();
            if (this.errorMessage != "")
            {
                MessageBox.Show(this.errorMessage, "Unable to Deploy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Deployment Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
