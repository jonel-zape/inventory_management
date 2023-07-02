
namespace Inventory_System
{
    partial class formNewInventoryAdjustment
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
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.before = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRemove = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new Inventory_System.ui.CustomButton();
            this.buttonSave = new Inventory_System.ui.CustomButton();
            this.backgroundWorkerLoad = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerSave = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerLoadView = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDateAndTime = new Inventory_System.ui.CustomTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxId = new Inventory_System.ui.CustomTextBox();
            this.comboBoxSites = new Inventory_System.ui.CustomComboBox();
            this.textBoxNotes = new Inventory_System.ui.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChooseItem = new Inventory_System.ui.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.before,
            this.newQuantity,
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
            this.dataGridViewList.Location = new System.Drawing.Point(24, 248);
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
            this.dataGridViewList.Size = new System.Drawing.Size(650, 269);
            this.dataGridViewList.TabIndex = 5;
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
            this.name.Width = 210;
            // 
            // before
            // 
            this.before.HeaderText = "Before";
            this.before.Name = "before";
            this.before.Width = 70;
            // 
            // newQuantity
            // 
            this.newQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newQuantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.newQuantity.HeaderText = "New Quantity";
            this.newQuantity.Name = "newQuantity";
            // 
            // buttonRemove
            // 
            this.buttonRemove.HeaderText = "";
            this.buttonRemove.Image = global::Inventory_System.Properties.Resources.icons8_trash_16;
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Width = 50;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(120)))), ((int)(((byte)(181)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(698, 5);
            this.panel8.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 535);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 60);
            this.panel1.TabIndex = 53;
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
            this.buttonClose.Location = new System.Drawing.Point(574, 15);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 3, 15, 15);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 30);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Close";
            this.buttonClose.TextColor = System.Drawing.Color.Black;
            this.buttonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click_1);
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
            this.buttonSave.Location = new System.Drawing.Point(468, 15);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 30);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.TextColor = System.Drawing.Color.White;
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // backgroundWorkerLoad
            // 
            this.backgroundWorkerLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerLoad_DoWork);
            this.backgroundWorkerLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerLoad_RunWorkerCompleted);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(315, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 68;
            this.label2.Text = "Date and Time";
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
            this.textBoxDateAndTime.Location = new System.Drawing.Point(318, 49);
            this.textBoxDateAndTime.Margin = new System.Windows.Forms.Padding(15, 4, 4, 4);
            this.textBoxDateAndTime.Multiline = false;
            this.textBoxDateAndTime.Name = "textBoxDateAndTime";
            this.textBoxDateAndTime.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxDateAndTime.PasswordChar = false;
            this.textBoxDateAndTime.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxDateAndTime.PlaceholderText = "Auto Generated";
            this.textBoxDateAndTime.Size = new System.Drawing.Size(356, 31);
            this.textBoxDateAndTime.TabIndex = 1;
            this.textBoxDateAndTime.TabStop = false;
            this.textBoxDateAndTime.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxDateAndTime.Texts = "";
            this.textBoxDateAndTime.UnderlinedStyle = false;
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
            this.label8.TabIndex = 67;
            this.label8.Text = "Transaction ID";
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
            this.textBoxId.Location = new System.Drawing.Point(24, 49);
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
            // comboBoxSites
            // 
            this.comboBoxSites.BackColor = System.Drawing.Color.White;
            this.comboBoxSites.BorderColor = System.Drawing.Color.Gray;
            this.comboBoxSites.BorderSize = 1;
            this.comboBoxSites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSites.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxSites.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxSites.IconColor = System.Drawing.Color.Gray;
            this.comboBoxSites.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.comboBoxSites.ListBackColor = System.Drawing.Color.White;
            this.comboBoxSites.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxSites.Location = new System.Drawing.Point(24, 123);
            this.comboBoxSites.MinimumSize = new System.Drawing.Size(100, 30);
            this.comboBoxSites.Name = "comboBoxSites";
            this.comboBoxSites.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxSites.Size = new System.Drawing.Size(275, 30);
            this.comboBoxSites.TabIndex = 2;
            this.comboBoxSites.Texts = "";
            this.comboBoxSites.OnSelectedIndexChanged += new System.EventHandler(this.comboBoxSites_SelectedIndexChanged);
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
            this.textBoxNotes.Location = new System.Drawing.Point(318, 123);
            this.textBoxNotes.Margin = new System.Windows.Forms.Padding(15, 4, 4, 4);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxNotes.PasswordChar = false;
            this.textBoxNotes.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxNotes.PlaceholderText = "";
            this.textBoxNotes.Size = new System.Drawing.Size(356, 101);
            this.textBoxNotes.TabIndex = 3;
            this.textBoxNotes.TabStop = false;
            this.textBoxNotes.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxNotes.Texts = "";
            this.textBoxNotes.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(315, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 71;
            this.label3.Text = "Notes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(24, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 72;
            this.label1.Text = "Site";
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
            this.buttonChooseItem.Location = new System.Drawing.Point(24, 210);
            this.buttonChooseItem.Name = "buttonChooseItem";
            this.buttonChooseItem.Size = new System.Drawing.Size(100, 30);
            this.buttonChooseItem.TabIndex = 4;
            this.buttonChooseItem.Text = "Add Item";
            this.buttonChooseItem.TextColor = System.Drawing.Color.White;
            this.buttonChooseItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonChooseItem.UseVisualStyleBackColor = false;
            this.buttonChooseItem.Click += new System.EventHandler(this.buttonChooseItem_Click_1);
            // 
            // formNewInventoryAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(698, 595);
            this.Controls.Add(this.buttonChooseItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.comboBoxSites);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDateAndTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formNewInventoryAdjustment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Transaction - Inventory Adjustment";
            this.Load += new System.EventHandler(this.formNewInventoryAdjustment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLoad;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSave;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLoadView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn before;
        private System.Windows.Forms.DataGridViewTextBoxColumn newQuantity;
        private System.Windows.Forms.DataGridViewImageColumn buttonRemove;
        private System.Windows.Forms.Label label2;
        private ui.CustomTextBox textBoxDateAndTime;
        private System.Windows.Forms.Label label8;
        private ui.CustomTextBox textBoxId;
        private ui.CustomComboBox comboBoxSites;
        private ui.CustomTextBox textBoxNotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private ui.CustomButton buttonChooseItem;
        private ui.CustomButton buttonClose;
        private ui.CustomButton buttonSave;
    }
}