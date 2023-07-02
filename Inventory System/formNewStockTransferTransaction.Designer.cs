
namespace Inventory_System
{
    partial class formNewStockTransferTransaction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new Inventory_System.ui.CustomButton();
            this.buttonSave = new Inventory_System.ui.CustomButton();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRemove = new System.Windows.Forms.DataGridViewImageColumn();
            this.backgroundWorkerSites = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerSave = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerLoadView = new System.ComponentModel.BackgroundWorker();
            this.textBoxId = new Inventory_System.ui.CustomTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDateAndTime = new Inventory_System.ui.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSitesFrom = new Inventory_System.ui.CustomComboBox();
            this.comboBoxSitesTo = new Inventory_System.ui.CustomComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNotes = new Inventory_System.ui.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChooseItem = new Inventory_System.ui.CustomButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(120)))), ((int)(((byte)(181)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(666, 5);
            this.panel8.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 535);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 60);
            this.panel1.TabIndex = 38;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.White;
            this.buttonClose.BackgroundColor = System.Drawing.Color.White;
            this.buttonClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.buttonClose.BorderRadius = 10;
            this.buttonClose.BorderSize = 1;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Black;
            this.buttonClose.Location = new System.Drawing.Point(542, 15);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 3, 15, 15);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 30);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.TextColor = System.Drawing.Color.Black;
            this.buttonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(173)))), ((int)(((byte)(106)))));
            this.buttonSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(173)))), ((int)(((byte)(106)))));
            this.buttonSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(146)))), ((int)(((byte)(91)))));
            this.buttonSave.BorderRadius = 10;
            this.buttonSave.BorderSize = 1;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(436, 15);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 30);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.TextColor = System.Drawing.Color.White;
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.AllowUserToAddRows = false;
            this.dataGridViewList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewList.ColumnHeadersHeight = 45;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.barcode,
            this.name,
            this.currentInventory,
            this.quantity,
            this.buttonRemove});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewList.GridColor = System.Drawing.Color.Silver;
            this.dataGridViewList.Location = new System.Drawing.Point(24, 269);
            this.dataGridViewList.Margin = new System.Windows.Forms.Padding(15, 5, 15, 15);
            this.dataGridViewList.MultiSelect = false;
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewList.RowHeadersVisible = false;
            this.dataGridViewList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewList.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dataGridViewList.RowTemplate.Height = 35;
            this.dataGridViewList.RowTemplate.ReadOnly = true;
            this.dataGridViewList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewList.ShowCellErrors = false;
            this.dataGridViewList.ShowCellToolTips = false;
            this.dataGridViewList.ShowRowErrors = false;
            this.dataGridViewList.Size = new System.Drawing.Size(618, 248);
            this.dataGridViewList.TabIndex = 6;
            this.dataGridViewList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewList_CellClick);
            this.dataGridViewList.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewList_RowsAdded);
            this.dataGridViewList.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewList_RowsRemoved);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 70;
            // 
            // barcode
            // 
            this.barcode.HeaderText = "Item Identification";
            this.barcode.Name = "barcode";
            this.barcode.Width = 130;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.Width = 200;
            // 
            // currentInventory
            // 
            this.currentInventory.HeaderText = "Current Inv.";
            this.currentInventory.Name = "currentInventory";
            this.currentInventory.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.quantity.HeaderText = "Transfer Quantity";
            this.quantity.Name = "quantity";
            // 
            // buttonRemove
            // 
            this.buttonRemove.HeaderText = "";
            this.buttonRemove.Image = global::Inventory_System.Properties.Resources.icons8_trash_16;
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Width = 50;
            // 
            // backgroundWorkerSites
            // 
            this.backgroundWorkerSites.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSites_DoWork);
            this.backgroundWorkerSites.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSites_RunWorkerCompleted);
            // 
            // backgroundWorkerSave
            // 
            this.backgroundWorkerSave.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSave_DoWork);
            this.backgroundWorkerSave.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSave_RunWorkerCompleted);
            // 
            // backgroundWorkerLoadView
            // 
            this.backgroundWorkerLoadView.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerLoadView_DoWork);
            this.backgroundWorkerLoadView.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerLoadView_RunWorkerCompleted);
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.Color.White;
            this.textBoxId.BorderColor = System.Drawing.Color.Gray;
            this.textBoxId.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBoxId.BorderRadius = 1;
            this.textBoxId.BorderSize = 1;
            this.textBoxId.Enabled = false;
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxId.Location = new System.Drawing.Point(27, 49);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(15, 4, 4, 4);
            this.textBoxId.Multiline = false;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxId.PasswordChar = false;
            this.textBoxId.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxId.PlaceholderText = "Auto Generated";
            this.textBoxId.Size = new System.Drawing.Size(275, 31);
            this.textBoxId.TabIndex = 0;
            this.textBoxId.TabStop = false;
            this.textBoxId.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxId.Texts = "";
            this.textBoxId.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(24, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 62;
            this.label8.Text = "Transaction ID";
            // 
            // textBoxDateAndTime
            // 
            this.textBoxDateAndTime.BackColor = System.Drawing.Color.White;
            this.textBoxDateAndTime.BorderColor = System.Drawing.Color.Gray;
            this.textBoxDateAndTime.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBoxDateAndTime.BorderRadius = 1;
            this.textBoxDateAndTime.BorderSize = 1;
            this.textBoxDateAndTime.Enabled = false;
            this.textBoxDateAndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDateAndTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxDateAndTime.Location = new System.Drawing.Point(321, 48);
            this.textBoxDateAndTime.Margin = new System.Windows.Forms.Padding(15, 4, 4, 4);
            this.textBoxDateAndTime.Multiline = false;
            this.textBoxDateAndTime.Name = "textBoxDateAndTime";
            this.textBoxDateAndTime.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxDateAndTime.PasswordChar = false;
            this.textBoxDateAndTime.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxDateAndTime.PlaceholderText = "Auto Generated";
            this.textBoxDateAndTime.Size = new System.Drawing.Size(321, 31);
            this.textBoxDateAndTime.TabIndex = 1;
            this.textBoxDateAndTime.TabStop = false;
            this.textBoxDateAndTime.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxDateAndTime.Texts = "";
            this.textBoxDateAndTime.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(318, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 64;
            this.label3.Text = "Date and Time";
            // 
            // comboBoxSitesFrom
            // 
            this.comboBoxSitesFrom.BackColor = System.Drawing.Color.White;
            this.comboBoxSitesFrom.BorderColor = System.Drawing.Color.Gray;
            this.comboBoxSitesFrom.BorderSize = 1;
            this.comboBoxSitesFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSitesFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxSitesFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxSitesFrom.IconColor = System.Drawing.Color.Gray;
            this.comboBoxSitesFrom.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.comboBoxSitesFrom.ListBackColor = System.Drawing.Color.White;
            this.comboBoxSitesFrom.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxSitesFrom.Location = new System.Drawing.Point(27, 123);
            this.comboBoxSitesFrom.MinimumSize = new System.Drawing.Size(100, 30);
            this.comboBoxSitesFrom.Name = "comboBoxSitesFrom";
            this.comboBoxSitesFrom.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxSitesFrom.Size = new System.Drawing.Size(275, 30);
            this.comboBoxSitesFrom.TabIndex = 2;
            this.comboBoxSitesFrom.Texts = "";
            // 
            // comboBoxSitesTo
            // 
            this.comboBoxSitesTo.BackColor = System.Drawing.Color.White;
            this.comboBoxSitesTo.BorderColor = System.Drawing.Color.Gray;
            this.comboBoxSitesTo.BorderSize = 1;
            this.comboBoxSitesTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSitesTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxSitesTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxSitesTo.IconColor = System.Drawing.Color.Gray;
            this.comboBoxSitesTo.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.comboBoxSitesTo.ListBackColor = System.Drawing.Color.White;
            this.comboBoxSitesTo.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxSitesTo.Location = new System.Drawing.Point(27, 195);
            this.comboBoxSitesTo.MinimumSize = new System.Drawing.Size(100, 30);
            this.comboBoxSitesTo.Name = "comboBoxSitesTo";
            this.comboBoxSitesTo.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxSitesTo.Size = new System.Drawing.Size(275, 30);
            this.comboBoxSitesTo.TabIndex = 4;
            this.comboBoxSitesTo.Texts = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(24, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 67;
            this.label5.Text = "Transfer From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(24, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 68;
            this.label6.Text = "Transfer To";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.BackColor = System.Drawing.Color.White;
            this.textBoxNotes.BorderColor = System.Drawing.Color.Gray;
            this.textBoxNotes.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBoxNotes.BorderRadius = 1;
            this.textBoxNotes.BorderSize = 1;
            this.textBoxNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxNotes.Location = new System.Drawing.Point(321, 124);
            this.textBoxNotes.Margin = new System.Windows.Forms.Padding(15, 4, 4, 4);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxNotes.PasswordChar = false;
            this.textBoxNotes.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxNotes.PlaceholderText = "";
            this.textBoxNotes.Size = new System.Drawing.Size(321, 101);
            this.textBoxNotes.TabIndex = 3;
            this.textBoxNotes.TabStop = false;
            this.textBoxNotes.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxNotes.Texts = "";
            this.textBoxNotes.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(318, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 70;
            this.label1.Text = "Notes";
            // 
            // buttonChooseItem
            // 
            this.buttonChooseItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(173)))), ((int)(((byte)(106)))));
            this.buttonChooseItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(173)))), ((int)(((byte)(106)))));
            this.buttonChooseItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(146)))), ((int)(((byte)(91)))));
            this.buttonChooseItem.BorderRadius = 10;
            this.buttonChooseItem.BorderSize = 1;
            this.buttonChooseItem.FlatAppearance.BorderSize = 0;
            this.buttonChooseItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChooseItem.ForeColor = System.Drawing.Color.White;
            this.buttonChooseItem.Image = global::Inventory_System.Properties.Resources.icons8_add_16_white;
            this.buttonChooseItem.Location = new System.Drawing.Point(24, 231);
            this.buttonChooseItem.Name = "buttonChooseItem";
            this.buttonChooseItem.Size = new System.Drawing.Size(100, 30);
            this.buttonChooseItem.TabIndex = 5;
            this.buttonChooseItem.Text = "Add Item";
            this.buttonChooseItem.TextColor = System.Drawing.Color.White;
            this.buttonChooseItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonChooseItem.UseVisualStyleBackColor = false;
            this.buttonChooseItem.Click += new System.EventHandler(this.buttonChooseItem_Click);
            // 
            // formNewStockTransferTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(666, 595);
            this.Controls.Add(this.buttonChooseItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxSitesTo);
            this.Controls.Add(this.comboBoxSitesFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDateAndTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formNewStockTransferTransaction";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Transaction - Transfer Items";
            this.Load += new System.EventHandler(this.formNewStockTransferTransaction_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSites;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSave;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLoadView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewImageColumn buttonRemove;
        private ui.CustomTextBox textBoxId;
        private System.Windows.Forms.Label label8;
        private ui.CustomTextBox textBoxDateAndTime;
        private System.Windows.Forms.Label label3;
        private ui.CustomComboBox comboBoxSitesFrom;
        private ui.CustomComboBox comboBoxSitesTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private ui.CustomTextBox textBoxNotes;
        private System.Windows.Forms.Label label1;
        private ui.CustomButton buttonChooseItem;
        private ui.CustomButton buttonClose;
        private ui.CustomButton buttonSave;
    }
}