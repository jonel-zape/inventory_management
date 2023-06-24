
namespace Inventory_System
{
    partial class formDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDashboard));
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelHorizontalLine = new System.Windows.Forms.Panel();
            this.customPanelSettingsMenu = new Inventory_System.ui.CustomPanel();
            this.customButtonAbout = new Inventory_System.ui.CustomButton();
            this.customButtonUpdateProductKey = new Inventory_System.ui.CustomButton();
            this.customButtonSettings = new Inventory_System.ui.CustomButton();
            this.panelContainer = new Inventory_System.ui.CustomPanel();
            this.customButtonLogout = new Inventory_System.ui.CustomButton();
            this.customButtonMyAccount = new Inventory_System.ui.CustomButton();
            this.customPanelMenus = new Inventory_System.ui.CustomPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customButtonCollapseMenus = new Inventory_System.ui.CustomButton();
            this.customButtonManageUsers = new Inventory_System.ui.CustomButton();
            this.customButtonInventoryAdjustments = new Inventory_System.ui.CustomButton();
            this.customButtonDashboard = new Inventory_System.ui.CustomButton();
            this.customButtonTransferItems = new Inventory_System.ui.CustomButton();
            this.customButtonSites = new Inventory_System.ui.CustomButton();
            this.customButtonItems = new Inventory_System.ui.CustomButton();
            this.labelUsername = new System.Windows.Forms.TextBox();
            this.customPanelSettingsMenu.SuspendLayout();
            this.customPanelMenus.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTitle.Location = new System.Drawing.Point(248, 18);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(88, 20);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Dashboard";
            // 
            // panelHorizontalLine
            // 
            this.panelHorizontalLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHorizontalLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(120)))), ((int)(((byte)(181)))));
            this.panelHorizontalLine.Location = new System.Drawing.Point(247, 57);
            this.panelHorizontalLine.Name = "panelHorizontalLine";
            this.panelHorizontalLine.Size = new System.Drawing.Size(1013, 1);
            this.panelHorizontalLine.TabIndex = 78;
            // 
            // customPanelSettingsMenu
            // 
            this.customPanelSettingsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanelSettingsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customPanelSettingsMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customPanelSettingsMenu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customPanelSettingsMenu.BorderRadius = 10;
            this.customPanelSettingsMenu.BorderSize = 0;
            this.customPanelSettingsMenu.Controls.Add(this.customButtonAbout);
            this.customPanelSettingsMenu.Controls.Add(this.customButtonUpdateProductKey);
            this.customPanelSettingsMenu.ForeColor = System.Drawing.Color.Black;
            this.customPanelSettingsMenu.Location = new System.Drawing.Point(989, 48);
            this.customPanelSettingsMenu.Name = "customPanelSettingsMenu";
            this.customPanelSettingsMenu.Size = new System.Drawing.Size(225, 92);
            this.customPanelSettingsMenu.TabIndex = 73;
            this.customPanelSettingsMenu.TabStop = true;
            this.customPanelSettingsMenu.TextColor = System.Drawing.Color.Black;
            this.customPanelSettingsMenu.Visible = false;
            this.customPanelSettingsMenu.Leave += new System.EventHandler(this.customPanelSettingsMenu_Leave);
            // 
            // customButtonAbout
            // 
            this.customButtonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customButtonAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtonAbout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtonAbout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtonAbout.BorderRadius = 10;
            this.customButtonAbout.BorderSize = 1;
            this.customButtonAbout.FlatAppearance.BorderSize = 0;
            this.customButtonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButtonAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButtonAbout.ForeColor = System.Drawing.Color.White;
            this.customButtonAbout.Image = global::Inventory_System.Properties.Resources.icons8_about_16_white;
            this.customButtonAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButtonAbout.Location = new System.Drawing.Point(10, 50);
            this.customButtonAbout.Margin = new System.Windows.Forms.Padding(5);
            this.customButtonAbout.Name = "customButtonAbout";
            this.customButtonAbout.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.customButtonAbout.Size = new System.Drawing.Size(202, 30);
            this.customButtonAbout.TabIndex = 3;
            this.customButtonAbout.Text = "About";
            this.customButtonAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButtonAbout.TextColor = System.Drawing.Color.White;
            this.customButtonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButtonAbout.UseVisualStyleBackColor = false;
            this.customButtonAbout.Click += new System.EventHandler(this.customButtonAbout_Click);
            // 
            // customButtonUpdateProductKey
            // 
            this.customButtonUpdateProductKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customButtonUpdateProductKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtonUpdateProductKey.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtonUpdateProductKey.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtonUpdateProductKey.BorderRadius = 10;
            this.customButtonUpdateProductKey.BorderSize = 1;
            this.customButtonUpdateProductKey.FlatAppearance.BorderSize = 0;
            this.customButtonUpdateProductKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButtonUpdateProductKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButtonUpdateProductKey.ForeColor = System.Drawing.Color.White;
            this.customButtonUpdateProductKey.Image = global::Inventory_System.Properties.Resources.icons8_key_16_white;
            this.customButtonUpdateProductKey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButtonUpdateProductKey.Location = new System.Drawing.Point(10, 10);
            this.customButtonUpdateProductKey.Margin = new System.Windows.Forms.Padding(5);
            this.customButtonUpdateProductKey.Name = "customButtonUpdateProductKey";
            this.customButtonUpdateProductKey.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.customButtonUpdateProductKey.Size = new System.Drawing.Size(202, 30);
            this.customButtonUpdateProductKey.TabIndex = 2;
            this.customButtonUpdateProductKey.Text = "Update Product Key";
            this.customButtonUpdateProductKey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButtonUpdateProductKey.TextColor = System.Drawing.Color.White;
            this.customButtonUpdateProductKey.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButtonUpdateProductKey.UseVisualStyleBackColor = false;
            this.customButtonUpdateProductKey.Click += new System.EventHandler(this.customButtonUpdateProductKey_Click);
            // 
            // customButtonSettings
            // 
            this.customButtonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customButtonSettings.BackColor = System.Drawing.Color.White;
            this.customButtonSettings.BackgroundColor = System.Drawing.Color.White;
            this.customButtonSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.customButtonSettings.BorderRadius = 10;
            this.customButtonSettings.BorderSize = 1;
            this.customButtonSettings.FlatAppearance.BorderSize = 0;
            this.customButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButtonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButtonSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.customButtonSettings.Image = global::Inventory_System.Properties.Resources.icons8_gear_16;
            this.customButtonSettings.Location = new System.Drawing.Point(1174, 12);
            this.customButtonSettings.Name = "customButtonSettings";
            this.customButtonSettings.Size = new System.Drawing.Size(40, 30);
            this.customButtonSettings.TabIndex = 101;
            this.customButtonSettings.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.customButtonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButtonSettings.UseVisualStyleBackColor = false;
            this.customButtonSettings.Click += new System.EventHandler(this.customButtonSettings_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.BackColor = System.Drawing.SystemColors.Control;
            this.panelContainer.BackgroundColor = System.Drawing.SystemColors.Control;
            this.panelContainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelContainer.BorderRadius = 10;
            this.panelContainer.BorderSize = 1;
            this.panelContainer.ForeColor = System.Drawing.Color.Black;
            this.panelContainer.Location = new System.Drawing.Point(247, 73);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1013, 610);
            this.panelContainer.TabIndex = 79;
            this.panelContainer.TextColor = System.Drawing.Color.Black;
            // 
            // customButtonLogout
            // 
            this.customButtonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customButtonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(87)))), ((int)(((byte)(76)))));
            this.customButtonLogout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(87)))), ((int)(((byte)(76)))));
            this.customButtonLogout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(82)))), ((int)(((byte)(74)))));
            this.customButtonLogout.BorderRadius = 10;
            this.customButtonLogout.BorderSize = 1;
            this.customButtonLogout.FlatAppearance.BorderSize = 0;
            this.customButtonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButtonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButtonLogout.ForeColor = System.Drawing.Color.White;
            this.customButtonLogout.Image = global::Inventory_System.Properties.Resources.icons8_logout_16_white;
            this.customButtonLogout.Location = new System.Drawing.Point(1220, 12);
            this.customButtonLogout.Name = "customButtonLogout";
            this.customButtonLogout.Size = new System.Drawing.Size(40, 30);
            this.customButtonLogout.TabIndex = 103;
            this.customButtonLogout.TextColor = System.Drawing.Color.White;
            this.customButtonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButtonLogout.UseVisualStyleBackColor = false;
            this.customButtonLogout.Click += new System.EventHandler(this.customButtonLogout_Click);
            // 
            // customButtonMyAccount
            // 
            this.customButtonMyAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customButtonMyAccount.BackColor = System.Drawing.Color.White;
            this.customButtonMyAccount.BackgroundColor = System.Drawing.Color.White;
            this.customButtonMyAccount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.customButtonMyAccount.BorderRadius = 10;
            this.customButtonMyAccount.BorderSize = 1;
            this.customButtonMyAccount.FlatAppearance.BorderSize = 0;
            this.customButtonMyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButtonMyAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButtonMyAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.customButtonMyAccount.Image = global::Inventory_System.Properties.Resources.icons8_user_16;
            this.customButtonMyAccount.Location = new System.Drawing.Point(1128, 12);
            this.customButtonMyAccount.Name = "customButtonMyAccount";
            this.customButtonMyAccount.Size = new System.Drawing.Size(40, 30);
            this.customButtonMyAccount.TabIndex = 102;
            this.customButtonMyAccount.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.customButtonMyAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButtonMyAccount.UseVisualStyleBackColor = false;
            this.customButtonMyAccount.Click += new System.EventHandler(this.customButtonMyAccount_Click);
            // 
            // customPanelMenus
            // 
            this.customPanelMenus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.customPanelMenus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customPanelMenus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customPanelMenus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customPanelMenus.BorderRadius = 10;
            this.customPanelMenus.BorderSize = 1;
            this.customPanelMenus.Controls.Add(this.label1);
            this.customPanelMenus.Controls.Add(this.label4);
            this.customPanelMenus.Controls.Add(this.customButtonCollapseMenus);
            this.customPanelMenus.Controls.Add(this.customButtonManageUsers);
            this.customPanelMenus.Controls.Add(this.customButtonInventoryAdjustments);
            this.customPanelMenus.Controls.Add(this.customButtonDashboard);
            this.customPanelMenus.Controls.Add(this.customButtonTransferItems);
            this.customPanelMenus.Controls.Add(this.customButtonSites);
            this.customPanelMenus.Controls.Add(this.customButtonItems);
            this.customPanelMenus.ForeColor = System.Drawing.Color.Black;
            this.customPanelMenus.Location = new System.Drawing.Point(11, 11);
            this.customPanelMenus.Margin = new System.Windows.Forms.Padding(2);
            this.customPanelMenus.Name = "customPanelMenus";
            this.customPanelMenus.Size = new System.Drawing.Size(225, 673);
            this.customPanelMenus.TabIndex = 73;
            this.customPanelMenus.TextColor = System.Drawing.Color.Black;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(10, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 75;
            this.label1.Text = "Transactions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(10, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 74;
            this.label4.Text = "Data";
            // 
            // customButtonCollapseMenus
            // 
            this.customButtonCollapseMenus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customButtonCollapseMenus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtonCollapseMenus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtonCollapseMenus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtonCollapseMenus.BorderRadius = 10;
            this.customButtonCollapseMenus.BorderSize = 1;
            this.customButtonCollapseMenus.FlatAppearance.BorderSize = 0;
            this.customButtonCollapseMenus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButtonCollapseMenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButtonCollapseMenus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.customButtonCollapseMenus.Image = global::Inventory_System.Properties.Resources.icons8_back_16_white;
            this.customButtonCollapseMenus.Location = new System.Drawing.Point(172, 631);
            this.customButtonCollapseMenus.Name = "customButtonCollapseMenus";
            this.customButtonCollapseMenus.Size = new System.Drawing.Size(40, 30);
            this.customButtonCollapseMenus.TabIndex = 100;
            this.customButtonCollapseMenus.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.customButtonCollapseMenus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButtonCollapseMenus.UseVisualStyleBackColor = false;
            this.customButtonCollapseMenus.Click += new System.EventHandler(this.customButtonCollapseMenus_Click);
            // 
            // customButtonManageUsers
            // 
            this.customButtonManageUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customButtonManageUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtonManageUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtonManageUsers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtonManageUsers.BorderRadius = 10;
            this.customButtonManageUsers.BorderSize = 1;
            this.customButtonManageUsers.FlatAppearance.BorderSize = 0;
            this.customButtonManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButtonManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButtonManageUsers.ForeColor = System.Drawing.Color.White;
            this.customButtonManageUsers.Image = global::Inventory_System.Properties.Resources.icons8_conference_16_white;
            this.customButtonManageUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButtonManageUsers.Location = new System.Drawing.Point(10, 155);
            this.customButtonManageUsers.Margin = new System.Windows.Forms.Padding(5);
            this.customButtonManageUsers.Name = "customButtonManageUsers";
            this.customButtonManageUsers.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.customButtonManageUsers.Size = new System.Drawing.Size(202, 30);
            this.customButtonManageUsers.TabIndex = 3;
            this.customButtonManageUsers.Text = "Users";
            this.customButtonManageUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButtonManageUsers.TextColor = System.Drawing.Color.White;
            this.customButtonManageUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButtonManageUsers.UseVisualStyleBackColor = false;
            this.customButtonManageUsers.Click += new System.EventHandler(this.customButtonManageUsers_Click);
            // 
            // customButtonInventoryAdjustments
            // 
            this.customButtonInventoryAdjustments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customButtonInventoryAdjustments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtonInventoryAdjustments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtonInventoryAdjustments.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtonInventoryAdjustments.BorderRadius = 10;
            this.customButtonInventoryAdjustments.BorderSize = 1;
            this.customButtonInventoryAdjustments.FlatAppearance.BorderSize = 0;
            this.customButtonInventoryAdjustments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButtonInventoryAdjustments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButtonInventoryAdjustments.ForeColor = System.Drawing.Color.White;
            this.customButtonInventoryAdjustments.Image = global::Inventory_System.Properties.Resources.icons8_adjust_16_white;
            this.customButtonInventoryAdjustments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButtonInventoryAdjustments.Location = new System.Drawing.Point(10, 260);
            this.customButtonInventoryAdjustments.Margin = new System.Windows.Forms.Padding(5);
            this.customButtonInventoryAdjustments.Name = "customButtonInventoryAdjustments";
            this.customButtonInventoryAdjustments.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.customButtonInventoryAdjustments.Size = new System.Drawing.Size(202, 30);
            this.customButtonInventoryAdjustments.TabIndex = 5;
            this.customButtonInventoryAdjustments.Text = "Inventory Adjustments";
            this.customButtonInventoryAdjustments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButtonInventoryAdjustments.TextColor = System.Drawing.Color.White;
            this.customButtonInventoryAdjustments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButtonInventoryAdjustments.UseVisualStyleBackColor = false;
            this.customButtonInventoryAdjustments.Click += new System.EventHandler(this.customButtonInventoryAdjustments_Click);
            // 
            // customButtonDashboard
            // 
            this.customButtonDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customButtonDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(165)))), ((int)(((byte)(252)))));
            this.customButtonDashboard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(165)))), ((int)(((byte)(252)))));
            this.customButtonDashboard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(120)))), ((int)(((byte)(181)))));
            this.customButtonDashboard.BorderRadius = 10;
            this.customButtonDashboard.BorderSize = 1;
            this.customButtonDashboard.FlatAppearance.BorderSize = 0;
            this.customButtonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButtonDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButtonDashboard.ForeColor = System.Drawing.Color.White;
            this.customButtonDashboard.Image = global::Inventory_System.Properties.Resources.icons8_control_panel_16__1__white;
            this.customButtonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButtonDashboard.Location = new System.Drawing.Point(10, 10);
            this.customButtonDashboard.Margin = new System.Windows.Forms.Padding(5);
            this.customButtonDashboard.Name = "customButtonDashboard";
            this.customButtonDashboard.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.customButtonDashboard.Size = new System.Drawing.Size(202, 30);
            this.customButtonDashboard.TabIndex = 0;
            this.customButtonDashboard.Text = "Dashboard";
            this.customButtonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButtonDashboard.TextColor = System.Drawing.Color.White;
            this.customButtonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButtonDashboard.UseVisualStyleBackColor = false;
            this.customButtonDashboard.Click += new System.EventHandler(this.customButtonDashboard_Click);
            // 
            // customButtonTransferItems
            // 
            this.customButtonTransferItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customButtonTransferItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtonTransferItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtonTransferItems.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtonTransferItems.BorderRadius = 10;
            this.customButtonTransferItems.BorderSize = 1;
            this.customButtonTransferItems.FlatAppearance.BorderSize = 0;
            this.customButtonTransferItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButtonTransferItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButtonTransferItems.ForeColor = System.Drawing.Color.White;
            this.customButtonTransferItems.Image = global::Inventory_System.Properties.Resources.icons8_data_transfer_16_white;
            this.customButtonTransferItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButtonTransferItems.Location = new System.Drawing.Point(10, 220);
            this.customButtonTransferItems.Margin = new System.Windows.Forms.Padding(5);
            this.customButtonTransferItems.Name = "customButtonTransferItems";
            this.customButtonTransferItems.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.customButtonTransferItems.Size = new System.Drawing.Size(202, 30);
            this.customButtonTransferItems.TabIndex = 4;
            this.customButtonTransferItems.Text = "Transfer Items";
            this.customButtonTransferItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButtonTransferItems.TextColor = System.Drawing.Color.White;
            this.customButtonTransferItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButtonTransferItems.UseVisualStyleBackColor = false;
            this.customButtonTransferItems.Click += new System.EventHandler(this.customButtonTransferItems_Click);
            // 
            // customButtonSites
            // 
            this.customButtonSites.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customButtonSites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtonSites.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtonSites.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtonSites.BorderRadius = 10;
            this.customButtonSites.BorderSize = 1;
            this.customButtonSites.FlatAppearance.BorderSize = 0;
            this.customButtonSites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButtonSites.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButtonSites.ForeColor = System.Drawing.Color.White;
            this.customButtonSites.Image = global::Inventory_System.Properties.Resources.icons8_city_buildings_16_white;
            this.customButtonSites.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButtonSites.Location = new System.Drawing.Point(10, 75);
            this.customButtonSites.Margin = new System.Windows.Forms.Padding(5);
            this.customButtonSites.Name = "customButtonSites";
            this.customButtonSites.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.customButtonSites.Size = new System.Drawing.Size(202, 30);
            this.customButtonSites.TabIndex = 1;
            this.customButtonSites.Text = "Sites";
            this.customButtonSites.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButtonSites.TextColor = System.Drawing.Color.White;
            this.customButtonSites.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButtonSites.UseVisualStyleBackColor = false;
            this.customButtonSites.Click += new System.EventHandler(this.customButtonSites_Click);
            // 
            // customButtonItems
            // 
            this.customButtonItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customButtonItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtonItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtonItems.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButtonItems.BorderRadius = 10;
            this.customButtonItems.BorderSize = 1;
            this.customButtonItems.FlatAppearance.BorderSize = 0;
            this.customButtonItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButtonItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButtonItems.ForeColor = System.Drawing.Color.White;
            this.customButtonItems.Image = global::Inventory_System.Properties.Resources.icons8_product_16_white;
            this.customButtonItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButtonItems.Location = new System.Drawing.Point(10, 115);
            this.customButtonItems.Margin = new System.Windows.Forms.Padding(5);
            this.customButtonItems.Name = "customButtonItems";
            this.customButtonItems.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.customButtonItems.Size = new System.Drawing.Size(202, 30);
            this.customButtonItems.TabIndex = 2;
            this.customButtonItems.Text = "Items";
            this.customButtonItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButtonItems.TextColor = System.Drawing.Color.White;
            this.customButtonItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButtonItems.UseVisualStyleBackColor = false;
            this.customButtonItems.Click += new System.EventHandler(this.customButtonItems_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsername.BackColor = System.Drawing.Color.White;
            this.labelUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelUsername.Location = new System.Drawing.Point(876, 18);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.ReadOnly = true;
            this.labelUsername.Size = new System.Drawing.Size(243, 17);
            this.labelUsername.TabIndex = 104;
            this.labelUsername.TabStop = false;
            this.labelUsername.Text = "Username";
            this.labelUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // formDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1272, 695);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.customPanelSettingsMenu);
            this.Controls.Add(this.customButtonSettings);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelHorizontalLine);
            this.Controls.Add(this.customButtonLogout);
            this.Controls.Add(this.customButtonMyAccount);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.customPanelMenus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1288, 734);
            this.Name = "formDashboard";
            this.Text = "Inventory Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formDashboard_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formDashboard_FormClosed);
            this.Load += new System.EventHandler(this.formDashboard_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.formDashboard_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formDashboard_MouseDown);
            this.customPanelSettingsMenu.ResumeLayout(false);
            this.customPanelMenus.ResumeLayout(false);
            this.customPanelMenus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private ui.CustomPanel customPanelMenus;
        private ui.CustomButton customButtonDashboard;
        private ui.CustomButton customButtonInventoryAdjustments;
        private ui.CustomButton customButtonTransferItems;
        private ui.CustomButton customButtonItems;
        private ui.CustomButton customButtonSites;
        private ui.CustomButton customButtonMyAccount;
        private ui.CustomButton customButtonLogout;
        private System.Windows.Forms.Panel panelHorizontalLine;
        private ui.CustomButton customButtonManageUsers;
        private ui.CustomPanel panelContainer;
        private ui.CustomButton customButtonCollapseMenus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private ui.CustomButton customButtonSettings;
        private ui.CustomPanel customPanelSettingsMenu;
        private ui.CustomButton customButtonAbout;
        private ui.CustomButton customButtonUpdateProductKey;
        private System.Windows.Forms.TextBox labelUsername;
    }
}