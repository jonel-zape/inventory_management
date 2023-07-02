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
    public partial class formDashboard : Form
    {
        private formLogin formLogin;
        private formPanelDashboard formPanelDashboard;
        private formPanelSites formPanelSites;
        private formPanelItems formPanelItems;
        private formUsersList formUsersList;
        private formPanelStockTransfer formPanelStockTransfer;
        private formPanelInventoryAdjustment formPanelInventoryAdjustment;
        private bool askExit;
        private bool exitConfirmed;
        private bool isCollapse;
        private List<string> menuLabels;

        public formDashboard(formLogin formLogin)
        {
            InitializeComponent();
            if (Properties.Settings.Default.admin != "1")
            {
                //this.toolStripMenuItemManageUsers.Visible = false;
            }

            this.isCollapse = false;
            this.menuLabels = new List<string>();

            this.askExit = true;
            this.exitConfirmed = false;
            this.formLogin = formLogin;
            this.formPanelDashboard = new formPanelDashboard(this);
            this.formPanelSites = new formPanelSites(this);
            this.formPanelItems = new formPanelItems(this);
            this.formPanelStockTransfer = new formPanelStockTransfer(this);
            this.formPanelInventoryAdjustment = new formPanelInventoryAdjustment(this);
            this.formUsersList = new formUsersList();
        }

        private void loadPanelDashboard() 
        {
            string username = Properties.Settings.Default.log_username;
            if (username.Length > 18)
            {
                username = username.Substring(0, 18) + "...";

            }
            this.labelUsername.Text = username;

            this.labelTitle.Text = "Dashboard";
            this.SuspendLayout();
            this.formPanelDashboard.content.Top = 0;
            this.formPanelDashboard.content.Left = 0;
            this.formPanelDashboard.content.Size = this.panelContainer.Size;
            this.panelContainer.Controls.Clear();
            this.panelContainer.Controls.Add(this.formPanelDashboard.content);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.formPanelDashboard.loadDetails();
        }

        private void loadPanelSites()
        {
            this.labelTitle.Text = "Sites";
            this.SuspendLayout();
            this.formPanelSites.content.Top = 0;
            this.formPanelSites.content.Left = 0;
            this.formPanelSites.content.Size = this.panelContainer.Size;
            this.panelContainer.Controls.Clear();
            this.panelContainer.Controls.Add(this.formPanelSites.content);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.formPanelSites.loadList();
        }

        private void loadPanelItems()
        {
            this.labelTitle.Text = "Items";
            this.SuspendLayout();
            this.formPanelItems.content.Top = 0;
            this.formPanelItems.content.Left = 0;
            this.formPanelItems.content.Size = this.panelContainer.Size;
            this.panelContainer.Controls.Clear();
            this.panelContainer.Controls.Add(this.formPanelItems.content);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.formPanelItems.loadList();
        }

        private void loadPanelUsers()
        {
            this.labelTitle.Text = "Users";
            this.SuspendLayout();
            this.formUsersList.content.Top = 0;
            this.formUsersList.content.Left = 0;
            this.formUsersList.content.Size = this.panelContainer.Size;
            this.panelContainer.Controls.Clear();
            this.panelContainer.Controls.Add(this.formUsersList.content);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.formUsersList.loadList();
        }

        private void loadPanelStockTransfer()
        {
            this.labelTitle.Text = "Transfer Items";
            this.SuspendLayout();
            this.formPanelStockTransfer.content.Top = 0;
            this.formPanelStockTransfer.content.Left = 0;
            this.formPanelStockTransfer.content.Size = this.panelContainer.Size;
            this.panelContainer.Controls.Clear();
            this.panelContainer.Controls.Add(this.formPanelStockTransfer.content);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.formPanelStockTransfer.loadList();
        }

        private void loadPanelInventoryAdjustment()
        {
            this.labelTitle.Text = "Inventory Adjustment";
            this.SuspendLayout();
            this.formPanelInventoryAdjustment.content.Top = 0;
            this.formPanelInventoryAdjustment.content.Left = 0;
            this.formPanelInventoryAdjustment.content.Size = this.panelContainer.Size;
            this.panelContainer.Controls.Clear();
            this.panelContainer.Controls.Add(this.formPanelInventoryAdjustment.content);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.formPanelInventoryAdjustment.loadList();
        }

        private void formDashboard_Load(object sender, EventArgs e)
        {
            this.loadPanelDashboard();
        }

        private void formDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.exitConfirmed)
            {
                Application.Exit();
            }
        }

        private void formDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.askExit)
            {
                this.exitConfirmed = true;
            }

            ui.CustomMessageBox customMessageBox = new ui.CustomMessageBox(ui.CustomMessageBox.ICON_QUESTION, ui.CustomMessageBox.BUTTON_YES_NO, "Confirm Exit", "Are you sure you want to exit?");

            if (this.askExit && customMessageBox.ShowDialog() != DialogResult.Yes)
            {
                e.Cancel = true;
                this.exitConfirmed = false;
            }
        }

        private void customButtonCollapseMenus_Click(object sender, EventArgs e)
        {
            this.isCollapse = !isCollapse;
            int menuButtonLocationX = 0;

            if (isCollapse)
            {
                this.customButtonCollapseMenus.Image = Properties.Resources.icons8_forward_16_white;

                this.menuLabels.Clear();

                foreach (Control control in this.customPanelMenus.Controls)
                {
                    if (control is ui.CustomButton)
                    {
                        this.menuLabels.Add((control as ui.CustomButton).Text);
                        (control as ui.CustomButton).Text = "";
                        menuButtonLocationX = (control as ui.CustomButton).Location.X;
                    }

                    if (control is Label)
                    {
                        (control as Label).Visible = false;
                    }
                }

                this.customPanelMenus.Width = 60;
                this.customButtonCollapseMenus.Location = new Point(menuButtonLocationX, this.customButtonCollapseMenus.Location.Y);
            }
            else
            {
                this.customButtonCollapseMenus.Image = Properties.Resources.icons8_back_16_white;

                this.customPanelMenus.Width = 225;

                int controlIndex = 0;

                foreach (Control control in this.customPanelMenus.Controls)
                {
                    if (control is ui.CustomButton)
                    {
                        this.menuLabels.Add((control as ui.CustomButton).Text);
                        (control as ui.CustomButton).Text = this.menuLabels[controlIndex];
                        controlIndex++;
                    }

                    if (control is Label)
                    {
                        (control as Label).Visible = true;
                    }
                }

                this.customButtonCollapseMenus.Location = new Point(172, this.customButtonCollapseMenus.Location.Y);
            }

            this.panelContainer.Left = this.customPanelMenus.Width + 10 + this.customPanelMenus.Left;
            this.panelHorizontalLine.Left = this.panelContainer.Left;
            this.labelTitle.Left = this.panelContainer.Left;
            this.panelContainer.Width = (this.Width - 28) - this.panelContainer.Left;
            this.panelHorizontalLine.Width = this.panelContainer.Width;
        }

        private void menuSelected(object sender)
        {
            foreach (Control control in this.customPanelMenus.Controls)
            {
                if (control is ui.CustomButton)
                {
                    var button = (control as ui.CustomButton);
                    button.BackColor = Color.FromArgb(255, 64, 64, 64);
                    button.BorderColor = Color.FromArgb(255, 64, 64, 64);
                }
            }

            if (sender is ui.CustomButton)
            {
                var button = (sender as ui.CustomButton);
                button.BackColor = Color.FromArgb(255, 3, 165, 252);
                button.BorderColor = Color.FromArgb(255, 5, 120, 181);
            }
        }

        private void customButtonLogout_Click(object sender, EventArgs e)
        {
            ui.CustomMessageBox customMessageBox = new ui.CustomMessageBox(ui.CustomMessageBox.ICON_QUESTION, ui.CustomMessageBox.BUTTON_YES_NO, "Confirm Log Out", "Are you sure you want to log out?");

            if (customMessageBox.ShowDialog() != DialogResult.Yes)
            {
                return;
            }

            Properties.Settings.Default.user_id = "";
            Properties.Settings.Default.Save();

            this.askExit = false;
            this.exitConfirmed = false;

            formLogin.Show();
            this.Close();
        }

        private void customButtonDashboard_Click(object sender, EventArgs e)
        {
            this.menuSelected(sender);
            this.loadPanelDashboard();
        }

        private void customButtonSites_Click(object sender, EventArgs e)
        {
            this.menuSelected(sender);
            this.loadPanelSites();
        }

        private void customButtonItems_Click(object sender, EventArgs e)
        {
            this.menuSelected(sender);
            this.loadPanelItems();
        }

        private void customButtonTransferItems_Click(object sender, EventArgs e)
        {
            this.menuSelected(sender);
            this.loadPanelStockTransfer();
        }

        private void customButtonInventoryAdjustments_Click(object sender, EventArgs e)
        {
            this.menuSelected(sender);
            this.loadPanelInventoryAdjustment();
        }

        private void customButtonSales_Click(object sender, EventArgs e)
        {
            
        }

        private void customButtonManageUsers_Click(object sender, EventArgs e)
        {
            this.menuSelected(sender);
            this.loadPanelUsers();
        }

        private void customButtonMyAccount_Click(object sender, EventArgs e)
        {
            formAddEditUser formAddEditUser = new formAddEditUser();
            formAddEditUser.displayView(Properties.Settings.Default.user_id, true);
            formAddEditUser.ShowDialog();
        }

        private void customButtonSettings_Click(object sender, EventArgs e)
        {
            this.customPanelSettingsMenu.Visible = !this.customPanelSettingsMenu.Visible;

            if (this.customPanelSettingsMenu.Visible)
            {
                this.customPanelSettingsMenu.Select();
            }
        }

        private void customPanelSettingsMenu_Leave(object sender, EventArgs e)
        {
            this.customPanelSettingsMenu.Visible = false;
        }

        private void formDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            this.customPanelSettingsMenu.Visible = false;
        }

        private void formDashboard_MouseClick(object sender, MouseEventArgs e)
        {
            this.customPanelSettingsMenu.Visible = false;
        }

        private void customButtonAbout_Click(object sender, EventArgs e)
        {
            formAbout formAbout = new formAbout();
            formAbout.ShowDialog();
        }

        private void customButtonUpdateProductKey_Click(object sender, EventArgs e)
        {
            formChangeProductKey formChangeProductKey = new formChangeProductKey();
            formChangeProductKey.ShowDialog();
        }
    }
}
