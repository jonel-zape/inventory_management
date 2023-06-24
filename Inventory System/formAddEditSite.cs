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
    public partial class formAddEditSite : Form
    {
        formPanelSites FormPanelSites;
        formLoading formLoading;
        bool isEdit;
        bool isSaveSuccess;
        string name;
        string address;
        string details;
        string status;
        string id;

        public formAddEditSite(formPanelSites formPanelSites)
        {
            InitializeComponent();
            this.isEdit = false;
            this.isSaveSuccess = false;
            this.FormPanelSites = formPanelSites;
        }

        public void displayAdd()
        {
            this.Text = "Add New Site";
            this.textBoxName.Texts = "";
            this.textBoxDetails.Texts = "";
            this.textBoxAddress.Texts = "";
            this.comboBoxStatus.SelectedIndex = -1;

            this.isEdit = false;
        }

        public void displayEdit(string siteId, string name, string address, string details, string status)
        {
            this.Text = "Edit Site";
            this.isEdit = true;
            this.id = siteId;
            this.customTextBoxID.Texts = siteId;
            this.textBoxName.Texts = name;
            this.textBoxAddress.Texts = address;
            this.textBoxDetails.Texts = details;
            this.comboBoxStatus.SelectedIndex = status == "Active" ? 0 : 1;
        }

        private void backgroundWorkerAddSite_DoWork(object sender, DoWorkEventArgs e)
        {
            database database = new database();
            this.name = database.escapeString(this.name);
            this.address = database.escapeString(this.address);
            this.details = database.escapeString(this.details);
            this.status = database.escapeString(this.status);

            string query = string.Format(
                "INSERT INTO `site` (`name`, `address`, `details`, `status`, `created_by`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                name,
                address,
                details,
                status,
                database.escapeString(Properties.Settings.Default.user_id)
            );

            this.isSaveSuccess = database.execute(query);
        }

        private void backgroundWorkerAddSite_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ui.CustomMessageBox customMessageBox;
            formLoading.Close();
            if (this.isSaveSuccess)
            {
                customMessageBox = new ui.CustomMessageBox(ui.CustomMessageBox.ICON_SUCCESS, ui.CustomMessageBox.BUTTON_OK, "Success", "Site Added");
                customMessageBox.ShowDialog();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                customMessageBox = new ui.CustomMessageBox(ui.CustomMessageBox.ICON_FAILED, ui.CustomMessageBox.BUTTON_OK, "Failed", "Unable to Add New Site");
                customMessageBox.ShowDialog();
            }
        }

        private void backgroundWorkerUpdateSite_DoWork(object sender, DoWorkEventArgs e)
        {
            database database = new database();
            this.name = database.escapeString(this.name);
            this.address = database.escapeString(this.address);
            this.details = database.escapeString(this.details);
            this.status = database.escapeString(this.status);
            this.id = database.escapeString(this.id);

            string query = string.Format(
                "UPDATE`site` SET `name` = '{0}', `address` = '{1}', `details` = '{2}', `status` = '{3}', `modified_by` = '{4}', `date_time_modifed` = NOW() WHERE `id` = '{5}'",
                name,
                address,
                details,
                status,
                database.escapeString(Properties.Settings.Default.user_id),
                this.id
            );

            this.isSaveSuccess = database.execute(query);
        }

        private void backgroundWorkerUpdateSite_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ui.CustomMessageBox customMessageBox;
            formLoading.Close();
            if (this.isSaveSuccess)
            {
                customMessageBox = new ui.CustomMessageBox(ui.CustomMessageBox.ICON_SUCCESS, ui.CustomMessageBox.BUTTON_OK, "Success", "Site Updated");
                customMessageBox.ShowDialog();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                customMessageBox = new ui.CustomMessageBox(ui.CustomMessageBox.ICON_FAILED, ui.CustomMessageBox.BUTTON_OK, "Failed", "Unable to Update Site");
                customMessageBox.ShowDialog();
            }
        }

        private void customButtonSave_Click(object sender, EventArgs e)
        {
            this.isSaveSuccess = false;

            ui.CustomMessageBox customMessageBox;

            if (textBoxName.Texts.Trim() == "")
            {
                customMessageBox = new ui.CustomMessageBox(ui.CustomMessageBox.ICON_FAILED, ui.CustomMessageBox.BUTTON_OK, "Unable to Save", "Site Name is required");
                customMessageBox.ShowDialog();
                return;
            }

            if (comboBoxStatus.SelectedIndex < 0)
            {
                customMessageBox = new ui.CustomMessageBox(ui.CustomMessageBox.ICON_FAILED, ui.CustomMessageBox.BUTTON_OK, "Unable to Save", "Status is required");
                customMessageBox.ShowDialog();
                return;
            }

            this.name = textBoxName.Texts.Trim();
            this.address = textBoxAddress.Texts.Trim();
            this.details = textBoxDetails.Texts.Trim();
            this.status = comboBoxStatus.SelectedIndex == 0 ? "1" : "0";

            if (isEdit)
            {
                this.backgroundWorkerUpdateSite.RunWorkerAsync();
            }
            else
            {
                this.backgroundWorkerAddSite.RunWorkerAsync();
            }

            this.formLoading = new formLoading("Saving...");
            this.formLoading.ShowDialog();
        }

        private void customButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formAddEditSite_Load(object sender, EventArgs e)
        {

        }
    }
}
