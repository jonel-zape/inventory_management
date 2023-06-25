
namespace Inventory_System
{
    partial class formPanelItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPanelItems));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelContent = new System.Windows.Forms.Panel();
            this.paginationControl1 = new Inventory_System.ui.PaginationControl();
            this.comboBoxSites = new Inventory_System.ui.CustomComboBox();
            this.comboBoxStatus = new Inventory_System.ui.CustomComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new Inventory_System.ui.CustomButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSearch = new Inventory_System.ui.CustomTextBox();
            this.addNew = new Inventory_System.ui.CustomButton();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.actionDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.backgroundWorkerList = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.backgroundWorkerDeleteItem = new System.ComponentModel.BackgroundWorker();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.BackColor = System.Drawing.SystemColors.Control;
            this.panelContent.Controls.Add(this.paginationControl1);
            this.panelContent.Controls.Add(this.comboBoxSites);
            this.panelContent.Controls.Add(this.comboBoxStatus);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.buttonSearch);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.textBoxSearch);
            this.panelContent.Controls.Add(this.addNew);
            this.panelContent.Controls.Add(this.dataGridViewList);
            this.panelContent.Location = new System.Drawing.Point(12, 12);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1193, 666);
            this.panelContent.TabIndex = 2;
            // 
            // paginationControl1
            // 
            this.paginationControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.paginationControl1.BackColor = System.Drawing.Color.Transparent;
            this.paginationControl1.CurrentPage = 0;
            this.paginationControl1.Location = new System.Drawing.Point(991, 597);
            this.paginationControl1.Margin = new System.Windows.Forms.Padding(3, 3, 15, 15);
            this.paginationControl1.Name = "paginationControl1";
            this.paginationControl1.Size = new System.Drawing.Size(187, 54);
            this.paginationControl1.TabIndex = 25;
            this.paginationControl1.TotalPage = 0;
            this.paginationControl1.TotalRow = 0;
            this.paginationControl1.PageChanged += new System.EventHandler(this.paginationControl1_PageChanged_1);
            // 
            // comboBoxSites
            // 
            this.comboBoxSites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSites.BackColor = System.Drawing.Color.White;
            this.comboBoxSites.BorderColor = System.Drawing.Color.Gray;
            this.comboBoxSites.BorderSize = 1;
            this.comboBoxSites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSites.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxSites.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxSites.IconColor = System.Drawing.Color.Gray;
            this.comboBoxSites.Items.AddRange(new object[] {
            "All",
            "Active",
            "Inactive"});
            this.comboBoxSites.ListBackColor = System.Drawing.Color.White;
            this.comboBoxSites.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxSites.Location = new System.Drawing.Point(464, 38);
            this.comboBoxSites.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBoxSites.Name = "comboBoxSites";
            this.comboBoxSites.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxSites.Size = new System.Drawing.Size(200, 30);
            this.comboBoxSites.TabIndex = 24;
            this.comboBoxSites.Texts = "";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStatus.BackColor = System.Drawing.Color.White;
            this.comboBoxStatus.BorderColor = System.Drawing.Color.Gray;
            this.comboBoxStatus.BorderSize = 1;
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxStatus.IconColor = System.Drawing.Color.Gray;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "All",
            "Condition",
            "Uncondition"});
            this.comboBoxStatus.ListBackColor = System.Drawing.Color.White;
            this.comboBoxStatus.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxStatus.Location = new System.Drawing.Point(670, 38);
            this.comboBoxStatus.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxStatus.Size = new System.Drawing.Size(200, 30);
            this.comboBoxStatus.TabIndex = 23;
            this.comboBoxStatus.Texts = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(461, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Site";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(667, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Status";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.BackColor = System.Drawing.Color.White;
            this.buttonSearch.BackgroundColor = System.Drawing.Color.White;
            this.buttonSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.buttonSearch.BorderRadius = 10;
            this.buttonSearch.BorderSize = 1;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.Location = new System.Drawing.Point(1134, 38);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(44, 30);
            this.buttonSearch.TabIndex = 20;
            this.buttonSearch.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(874, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Input Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSearch.BorderColor = System.Drawing.Color.Gray;
            this.textBoxSearch.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBoxSearch.BorderRadius = 1;
            this.textBoxSearch.BorderSize = 1;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxSearch.Location = new System.Drawing.Point(877, 38);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Multiline = false;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxSearch.PasswordChar = false;
            this.textBoxSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxSearch.PlaceholderText = "Search by Name, Identification";
            this.textBoxSearch.Size = new System.Drawing.Size(250, 31);
            this.textBoxSearch.TabIndex = 18;
            this.textBoxSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxSearch.Texts = "";
            this.textBoxSearch.UnderlinedStyle = false;
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            // 
            // addNew
            // 
            this.addNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(173)))), ((int)(((byte)(106)))));
            this.addNew.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(173)))), ((int)(((byte)(106)))));
            this.addNew.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(146)))), ((int)(((byte)(91)))));
            this.addNew.BorderRadius = 10;
            this.addNew.BorderSize = 1;
            this.addNew.FlatAppearance.BorderSize = 0;
            this.addNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNew.ForeColor = System.Drawing.Color.White;
            this.addNew.Image = global::Inventory_System.Properties.Resources.icons8_add_16_white;
            this.addNew.Location = new System.Drawing.Point(15, 38);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(100, 30);
            this.addNew.TabIndex = 17;
            this.addNew.Text = "New";
            this.addNew.TextColor = System.Drawing.Color.White;
            this.addNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addNew.UseVisualStyleBackColor = false;
            this.addNew.Click += new System.EventHandler(this.addNew_Click);
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
            this.description,
            this.price,
            this.status,
            this.inventory,
            this.actionEdit,
            this.actionDelete});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewList.GridColor = System.Drawing.Color.Silver;
            this.dataGridViewList.Location = new System.Drawing.Point(15, 79);
            this.dataGridViewList.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.dataGridViewList.MultiSelect = false;
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.ReadOnly = true;
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
            this.dataGridViewList.ShowEditingIcon = false;
            this.dataGridViewList.ShowRowErrors = false;
            this.dataGridViewList.Size = new System.Drawing.Size(1163, 510);
            this.dataGridViewList.TabIndex = 5;
            this.dataGridViewList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewList_CellClick);
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 60;
            // 
            // barcode
            // 
            this.barcode.Frozen = true;
            this.barcode.HeaderText = "Item Identification";
            this.barcode.Name = "barcode";
            this.barcode.ReadOnly = true;
            this.barcode.Width = 130;
            // 
            // name
            // 
            this.name.Frozen = true;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // description
            // 
            this.description.Frozen = true;
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 200;
            // 
            // price
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.price.DefaultCellStyle = dataGridViewCellStyle3;
            this.price.Frozen = true;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Visible = false;
            // 
            // status
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.status.DefaultCellStyle = dataGridViewCellStyle4;
            this.status.Frozen = true;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // inventory
            // 
            this.inventory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.inventory.HeaderText = "Inventory Quantity";
            this.inventory.Name = "inventory";
            this.inventory.ReadOnly = true;
            // 
            // actionEdit
            // 
            this.actionEdit.HeaderText = "";
            this.actionEdit.Image = global::Inventory_System.Properties.Resources.icons8_pencil_16;
            this.actionEdit.Name = "actionEdit";
            this.actionEdit.ReadOnly = true;
            this.actionEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.actionEdit.ToolTipText = "Edit";
            this.actionEdit.Width = 50;
            // 
            // actionDelete
            // 
            this.actionDelete.HeaderText = "";
            this.actionDelete.Image = global::Inventory_System.Properties.Resources.icons8_trash_16;
            this.actionDelete.Name = "actionDelete";
            this.actionDelete.ReadOnly = true;
            this.actionDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.actionDelete.ToolTipText = "Delete";
            this.actionDelete.Width = 50;
            // 
            // backgroundWorkerList
            // 
            this.backgroundWorkerList.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerList_DoWork);
            this.backgroundWorkerList.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerList_RunWorkerCompleted);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Inventory_System.Properties.Resources.icons8_show_property_16;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.ToolTipText = "View Sites Inventory";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Inventory_System.Properties.Resources.icons8_pencil_16;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.ToolTipText = "Edit";
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::Inventory_System.Properties.Resources.icons8_trash_16;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn3.ToolTipText = "Delete";
            this.dataGridViewImageColumn3.Width = 50;
            // 
            // backgroundWorkerDeleteItem
            // 
            this.backgroundWorkerDeleteItem.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerDeleteItem_DoWork);
            this.backgroundWorkerDeleteItem.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerDeleteItem_RunWorkerCompleted);
            // 
            // formPanelItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 690);
            this.Controls.Add(this.panelContent);
            this.Name = "formPanelItems";
            this.Text = "formPanelItems";
            this.Load += new System.EventHandler(this.formPanelItems_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.ComponentModel.BackgroundWorker backgroundWorkerList;
        private System.ComponentModel.BackgroundWorker backgroundWorkerDeleteItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventory;
        private System.Windows.Forms.DataGridViewImageColumn actionEdit;
        private System.Windows.Forms.DataGridViewImageColumn actionDelete;
        private ui.CustomButton addNew;
        private ui.CustomTextBox textBoxSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ui.CustomButton buttonSearch;
        private ui.CustomComboBox comboBoxStatus;
        private ui.CustomComboBox comboBoxSites;
        private ui.PaginationControl paginationControl1;
    }
}