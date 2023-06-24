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
    public partial class formInputCurrentPassword : Form
    {
        formLoading formLoading;
        string password = "";
        bool isAuthenticated;

        public formInputCurrentPassword()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundWorkerValidate_DoWork(object sender, DoWorkEventArgs e)
        {
            models.user user = new models.user();
            this.isAuthenticated = user.authMyPassword(this.password);
        }

        private void backgroundWorkerValidate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.formLoading.finish();

            if (this.isAuthenticated)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Incorrect Password", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.isAuthenticated = false;

            this.password = this.textBoxPassword.Text;
            if (this.password == "")
            {
                MessageBox.Show("Please input your password", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.backgroundWorkerValidate.RunWorkerAsync();
            this.formLoading = new formLoading("Authenticating...");
            this.formLoading.ShowDialog();
        }
    }
}
