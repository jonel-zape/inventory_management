
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelContent = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPaginateBack = new System.Windows.Forms.Button();
            this.labelPaginateTotalPage = new System.Windows.Forms.Label();
            this.textBoxPaginatePage = new System.Windows.Forms.TextBox();
            this.buttonPaginateNext = new System.Windows.Forms.Button();
            this.comboBoxSites = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelListCount = new System.Windows.Forms.Label();
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.addNew = new System.Windows.Forms.Button();
            this.backgroundWorkerList = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.backgroundWorkerDeleteItem = new System.ComponentModel.BackgroundWorker();
            this.paginationControl1 = new Inventory_System.ui.PaginationControl();
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
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.buttonPaginateBack);
            this.panelContent.Controls.Add(this.labelPaginateTotalPage);
            this.panelContent.Controls.Add(this.textBoxPaginatePage);
            this.panelContent.Controls.Add(this.buttonPaginateNext);
            this.panelContent.Controls.Add(this.comboBoxSites);
            this.panelContent.Controls.Add(this.comboBoxStatus);
            this.panelContent.Controls.Add(this.labelListCount);
            this.panelContent.Controls.Add(this.dataGridViewList);
            this.panelContent.Controls.Add(this.buttonSearch);
            this.panelContent.Controls.Add(this.textBoxSearch);
            this.panelContent.Controls.Add(this.addNew);
            this.panelContent.Location = new System.Drawing.Point(12, 12);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1193, 666);
            this.panelContent.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(416, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Site";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(855, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Input Search";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(696, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Status";
            // 
            // buttonPaginateBack
            // 
            this.buttonPaginateBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPaginateBack.Image = global::Inventory_System.Properties.Resources.icons8_back_16;
            this.buttonPaginateBack.Location = new System.Drawing.Point(316, 628);
            this.buttonPaginateBack.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.buttonPaginateBack.Name = "buttonPaginateBack";
            this.buttonPaginateBack.Size = new System.Drawing.Size(50, 23);
            this.buttonPaginateBack.TabIndex = 13;
            this.buttonPaginateBack.UseVisualStyleBackColor = true;
            this.buttonPaginateBack.Click += new System.EventHandler(this.buttonPaginateBack_Click);
            // 
            // labelPaginateTotalPage
            // 
            this.labelPaginateTotalPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPaginateTotalPage.AutoSize = true;
            this.labelPaginateTotalPage.Location = new System.Drawing.Point(434, 633);
            this.labelPaginateTotalPage.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.labelPaginateTotalPage.Name = "labelPaginateTotalPage";
            this.labelPaginateTotalPage.Size = new System.Drawing.Size(37, 13);
            this.labelPaginateTotalPage.TabIndex = 12;
            this.labelPaginateTotalPage.Text = "of 999";
            // 
            // textBoxPaginatePage
            // 
            this.textBoxPaginatePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPaginatePage.Location = new System.Drawing.Point(376, 630);
            this.textBoxPaginatePage.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.textBoxPaginatePage.MaxLength = 5;
            this.textBoxPaginatePage.Name = "textBoxPaginatePage";
            this.textBoxPaginatePage.Size = new System.Drawing.Size(48, 20);
            this.textBoxPaginatePage.TabIndex = 11;
            this.textBoxPaginatePage.Text = "1";
            this.textBoxPaginatePage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPaginatePage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPaginatePage_KeyDown);
            // 
            // buttonPaginateNext
            // 
            this.buttonPaginateNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPaginateNext.Image = global::Inventory_System.Properties.Resources.icons8_forward_16;
            this.buttonPaginateNext.Location = new System.Drawing.Point(481, 628);
            this.buttonPaginateNext.Margin = new System.Windows.Forms.Padding(5, 5, 15, 15);
            this.buttonPaginateNext.Name = "buttonPaginateNext";
            this.buttonPaginateNext.Size = new System.Drawing.Size(50, 23);
            this.buttonPaginateNext.TabIndex = 10;
            this.buttonPaginateNext.UseVisualStyleBackColor = true;
            this.buttonPaginateNext.Click += new System.EventHandler(this.buttonPaginateNext_Click);
            // 
            // comboBoxSites
            // 
            this.comboBoxSites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSites.FormattingEnabled = true;
            this.comboBoxSites.Items.AddRange(new object[] {
            "All Sites"});
            this.comboBoxSites.Location = new System.Drawing.Point(419, 40);
            this.comboBoxSites.Margin = new System.Windows.Forms.Padding(5, 40, 5, 5);
            this.comboBoxSites.Name = "comboBoxSites";
            this.comboBoxSites.Size = new System.Drawing.Size(270, 21);
            this.comboBoxSites.TabIndex = 1;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "All",
            "Active",
            "Inactive"});
            this.comboBoxStatus.Location = new System.Drawing.Point(699, 40);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(5, 40, 5, 5);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(148, 21);
            this.comboBoxStatus.TabIndex = 2;
            // 
            // labelListCount
            // 
            this.labelListCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelListCount.AutoSize = true;
            this.labelListCount.Location = new System.Drawing.Point(12, 633);
            this.labelListCount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.labelListCount.Name = "labelListCount";
            this.labelListCount.Size = new System.Drawing.Size(43, 13);
            this.labelListCount.TabIndex = 9;
            this.labelListCount.Text = "Total: 0";
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.AllowUserToAddRows = false;
            this.dataGridViewList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle41;
            this.dataGridViewList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle42;
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
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle45.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewList.DefaultCellStyle = dataGridViewCellStyle45;
            this.dataGridViewList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewList.GridColor = System.Drawing.Color.Silver;
            this.dataGridViewList.Location = new System.Drawing.Point(15, 73);
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
            this.dataGridViewList.Size = new System.Drawing.Size(1163, 528);
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
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.price.DefaultCellStyle = dataGridViewCellStyle43;
            this.price.Frozen = true;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Visible = false;
            // 
            // status
            // 
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.status.DefaultCellStyle = dataGridViewCellStyle44;
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
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Image = global::Inventory_System.Properties.Resources.icons8_search_16;
            this.buttonSearch.Location = new System.Drawing.Point(1128, 38);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(5, 40, 5, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(50, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(858, 40);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(5, 40, 5, 5);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(260, 20);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            // 
            // addNew
            // 
            this.addNew.BackgroundImage = global::Inventory_System.Properties.Resources.icons8_add_16;
            this.addNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addNew.Location = new System.Drawing.Point(15, 40);
            this.addNew.Margin = new System.Windows.Forms.Padding(15, 40, 15, 5);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(119, 23);
            this.addNew.TabIndex = 0;
            this.addNew.Text = "Add New Item";
            this.addNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addNew.UseVisualStyleBackColor = true;
            this.addNew.Click += new System.EventHandler(this.addNew_Click);
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
            // paginationControl1
            // 
            this.paginationControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.paginationControl1.BackColor = System.Drawing.Color.Transparent;
            this.paginationControl1.CurrentPage = 1;
            this.paginationControl1.Location = new System.Drawing.Point(991, 609);
            this.paginationControl1.Name = "paginationControl1";
            this.paginationControl1.Size = new System.Drawing.Size(187, 54);
            this.paginationControl1.TabIndex = 17;
            this.paginationControl1.TotalPage = 100;
            this.paginationControl1.TotalRow = 1000;
            this.paginationControl1.PageChanged += new System.EventHandler(this.paginationControl1_PageChanged);
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
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelListCount;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button addNew;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.ComboBox comboBoxSites;
        private System.ComponentModel.BackgroundWorker backgroundWorkerList;
        private System.Windows.Forms.Button buttonPaginateBack;
        private System.Windows.Forms.Label labelPaginateTotalPage;
        private System.Windows.Forms.TextBox textBoxPaginatePage;
        private System.Windows.Forms.Button buttonPaginateNext;
        private System.ComponentModel.BackgroundWorker backgroundWorkerDeleteItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventory;
        private System.Windows.Forms.DataGridViewImageColumn actionEdit;
        private System.Windows.Forms.DataGridViewImageColumn actionDelete;
        private ui.PaginationControl paginationControl1;
    }
}