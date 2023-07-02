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
    public partial class formChangeProductKey : Form
    {
        formLoading formLoading;
        string serverDateTime;
        string inputKey;
        bool isValid;

        public formChangeProductKey()
        {
            InitializeComponent();

            serverDateTime = "";
        }

        private void formChangeProductKey_Load(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.product_key.Trim() != "")
            {
                this.labelAppliedKey.Text = "Applied Key: " + Properties.Settings.Default.product_key.Substring(0, 15) + "*********";
            }
            else
            {
                this.labelAppliedKey.Text = "No Key Applied";
            }

            int minutes = 0;
            int.TryParse(Properties.Settings.Default.remaining_time, out minutes);
            this.labelRemaining.Text = "Key Expires In " + (minutes / 1440).ToString() + " Day(s)";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            this.inputKey = this.textBoxKey.Texts.Trim();
            this.isValid = false;

            this.backgroundWorkerValidate.RunWorkerAsync();

            this.formLoading = new formLoading("Validating...");
            this.formLoading.ShowDialog();
        }

        private void backgroundWorkerValidate_DoWork(object sender, DoWorkEventArgs e)
        {
            this.serverDateTime = tools.getNetworkDateTime();

            license l = new license();
            if (l.validate(this.inputKey))
            {
                string validity = l.getDateValidity();
                int duration = l.getDuration();
                string licenseTo = l.getLicenseTo();

                DateTime dateTimeValidity = DateTime.Parse(validity);
                DateTime dateTimeNow = DateTime.Parse(this.serverDateTime);

                int result = DateTime.Compare(dateTimeValidity, dateTimeNow);
                this.isValid = result > 0;

                if (this.isValid)
                {
                    if (Properties.Settings.Default.product_key.Trim().ToLower() != this.inputKey.ToLower())
                    {
                        Properties.Settings.Default.product_key = this.inputKey;
                        Properties.Settings.Default.remaining_time = (duration * 1440).ToString();
                        Properties.Settings.Default.license_to = licenseTo;
                        Properties.Settings.Default.Save();
                    }
                }
            }
        }

        public void setMessage(string message, string title)
        {
            this.labelAppliedKey.Text = message;
            this.Text = title;
        }

        private void backgroundWorkerValidate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.formLoading.finish();

            if (this.serverDateTime.Trim() == "")
            {
                MessageBox.Show("Unable to validate license key. Please check your internet connection and try again", "Unable to Activate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.isValid)
            {
                MessageBox.Show("Activation Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid Key or Expired", "Unable to Activate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
