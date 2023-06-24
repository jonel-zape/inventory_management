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
    public partial class formAddEditUser : Form
    {
        formLoading formLoading;
        bool isNew;
        string selectedUserId;
        string username;
        string password;
        string firstName;
        string lastName;
        string status;
        string errorMessage;
        bool isMe;

        public formAddEditUser()
        {
            InitializeComponent();
            this.isMe = false;
        }

        public void displayNew()
        {
            this.isNew = true;
            this.Text = "New User";
            this.selectedUserId = "0";
        }

        public void displayView(string userId, bool isMe = false)
        {
            this.isNew = false;
            this.Text = "View User";
            this.selectedUserId = userId;
            this.labelPassword.Text = "Password (Leave blank to do not Update):";
            this.isMe = isMe;

            if (this.isMe)
            {
                this.comboBoxStatus.Enabled = false;
            }

            this.backgroundWorkerLoadDetails.RunWorkerAsync();
            this.formLoading = new formLoading("Loading...");
            this.formLoading.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (this.textBoxFirstName.Text.Trim() == "")
            {
                MessageBox.Show("First Name is required", "Unable to Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.textBoxLastName.Text.Trim() == "")
            {
                MessageBox.Show("Last Name is required", "Unable to Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.textBoxUsername.Text.Trim() == "")
            {
                MessageBox.Show("Username is required", "Unable to Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.textBoxPassword.Text.Trim() == "" && this.isNew == true)
            {
                MessageBox.Show("Password is required", "Unable to Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.textBoxPassword.Text != this.textBoxRepeatPassword.Text)
            {
                MessageBox.Show("Password not match", "Unable to Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.comboBoxStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Status is required", "Unable to Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.isMe)
            {
                formInputCurrentPassword formInputCurrentPassword = new formInputCurrentPassword();
                if (formInputCurrentPassword.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
            }

            this.username = this.textBoxUsername.Text.Trim();
            this.password = this.textBoxPassword.Text.Trim();
            this.firstName = this.textBoxFirstName.Text.Trim();
            this.lastName = this.textBoxLastName.Text.Trim();
            this.status = this.comboBoxStatus.SelectedIndex == 0 ? "1" : "0";

            this.backgroundWorkerSave.RunWorkerAsync();
            this.formLoading = new formLoading("Saving...");
            this.formLoading.ShowDialog();
        }

        private void backgroundWorkerSave_DoWork(object sender, DoWorkEventArgs e)
        {
            this.errorMessage = "";
            models.user user = new models.user();
            if (user.isUsernameExists(this.username, this.selectedUserId))
            {
                this.errorMessage = "Username already taken";
                return;
            }

            if (this.isNew)
            {
                user.create(this.username, this.password, this.status, this.firstName, this.lastName);
            }
            else
            {
                user.update(this.selectedUserId, this.username, this.password, this.status, this.firstName, this.lastName);
            }
        }

        private void backgroundWorkerSave_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.formLoading.finish();
            if (this.errorMessage.Trim() != "")
            {
                MessageBox.Show(this.errorMessage, "Unable to Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }

        private void backgroundWorkerLoadDetails_DoWork(object sender, DoWorkEventArgs e)
        {
            models.user user = new models.user();
            List<string>[] data = user.getById(this.selectedUserId);

            if (data[0].Count < 1)
            {
                this.selectedUserId = "0";
                return;
            }

            this.username = data[1][0];
            this.firstName = data[2][0];
            this.lastName = data[3][0];
            this.status = data[4][0];
        }

        private void backgroundWorkerLoadDetails_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.formLoading.finish();
            if (this.selectedUserId == "0")
            {
                MessageBox.Show("User not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.OK;
                return;
            }

            this.textBoxFirstName.Text = this.firstName;
            this.textBoxLastName.Text = this.lastName;
            this.textBoxUsername.Text = this.username;
            this.comboBoxStatus.SelectedIndex = this.status == "1" ? 0 : 1;
        }
    }
}
