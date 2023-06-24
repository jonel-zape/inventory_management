
namespace Inventory_System
{
    partial class formItemPicker
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originalIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPaginateBack = new System.Windows.Forms.Button();
            this.labelPaginateTotalPage = new System.Windows.Forms.Label();
            this.textBoxPaginatePage = new System.Windows.Forms.TextBox();
            this.buttonPaginateNext = new System.Windows.Forms.Button();
            this.labelListCount = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.backgroundWorkerList = new System.ComponentModel.BackgroundWorker();
            this.comboBoxSites = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(569, 26);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(293, 20);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
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
            this.originalIndex});
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
            this.dataGridViewList.Location = new System.Drawing.Point(24, 57);
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
            this.dataGridViewList.Size = new System.Drawing.Size(898, 336);
            this.dataGridViewList.TabIndex = 4;
            this.dataGridViewList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewList_CellDoubleClick);
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
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 200;
            // 
            // price
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.price.DefaultCellStyle = dataGridViewCellStyle3;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Visible = false;
            // 
            // status
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.status.DefaultCellStyle = dataGridViewCellStyle4;
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
            // originalIndex
            // 
            this.originalIndex.HeaderText = "Index";
            this.originalIndex.Name = "originalIndex";
            this.originalIndex.ReadOnly = true;
            this.originalIndex.Visible = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(115)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(946, 5);
            this.panel8.TabIndex = 33;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelect.Location = new System.Drawing.Point(762, 16);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 8;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(847, 16);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(5, 5, 15, 15);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonSelect);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 438);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 55);
            this.panel1.TabIndex = 54;
            // 
            // buttonPaginateBack
            // 
            this.buttonPaginateBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPaginateBack.Image = global::Inventory_System.Properties.Resources.icons8_back_16;
            this.buttonPaginateBack.Location = new System.Drawing.Point(707, 403);
            this.buttonPaginateBack.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.buttonPaginateBack.Name = "buttonPaginateBack";
            this.buttonPaginateBack.Size = new System.Drawing.Size(50, 23);
            this.buttonPaginateBack.TabIndex = 5;
            this.buttonPaginateBack.UseVisualStyleBackColor = true;
            this.buttonPaginateBack.Click += new System.EventHandler(this.buttonPaginateBack_Click);
            // 
            // labelPaginateTotalPage
            // 
            this.labelPaginateTotalPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPaginateTotalPage.AutoSize = true;
            this.labelPaginateTotalPage.Location = new System.Drawing.Point(825, 408);
            this.labelPaginateTotalPage.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.labelPaginateTotalPage.Name = "labelPaginateTotalPage";
            this.labelPaginateTotalPage.Size = new System.Drawing.Size(37, 13);
            this.labelPaginateTotalPage.TabIndex = 57;
            this.labelPaginateTotalPage.Text = "of 999";
            // 
            // textBoxPaginatePage
            // 
            this.textBoxPaginatePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPaginatePage.Location = new System.Drawing.Point(767, 405);
            this.textBoxPaginatePage.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.textBoxPaginatePage.MaxLength = 5;
            this.textBoxPaginatePage.Name = "textBoxPaginatePage";
            this.textBoxPaginatePage.Size = new System.Drawing.Size(48, 20);
            this.textBoxPaginatePage.TabIndex = 6;
            this.textBoxPaginatePage.Text = "1";
            this.textBoxPaginatePage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPaginatePage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPaginatePage_KeyDown);
            // 
            // buttonPaginateNext
            // 
            this.buttonPaginateNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPaginateNext.Image = global::Inventory_System.Properties.Resources.icons8_forward_16;
            this.buttonPaginateNext.Location = new System.Drawing.Point(872, 403);
            this.buttonPaginateNext.Margin = new System.Windows.Forms.Padding(5, 5, 15, 15);
            this.buttonPaginateNext.Name = "buttonPaginateNext";
            this.buttonPaginateNext.Size = new System.Drawing.Size(50, 23);
            this.buttonPaginateNext.TabIndex = 7;
            this.buttonPaginateNext.UseVisualStyleBackColor = true;
            this.buttonPaginateNext.Click += new System.EventHandler(this.buttonPaginateNext_Click);
            // 
            // labelListCount
            // 
            this.labelListCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelListCount.AutoSize = true;
            this.labelListCount.Location = new System.Drawing.Point(21, 408);
            this.labelListCount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.labelListCount.Name = "labelListCount";
            this.labelListCount.Size = new System.Drawing.Size(43, 13);
            this.labelListCount.TabIndex = 59;
            this.labelListCount.Text = "Total: 0";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Image = global::Inventory_System.Properties.Resources.icons8_search_16;
            this.buttonSearch.Location = new System.Drawing.Point(872, 24);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(50, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // backgroundWorkerList
            // 
            this.backgroundWorkerList.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerList_DoWork);
            this.backgroundWorkerList.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerList_RunWorkerCompleted);
            // 
            // comboBoxSites
            // 
            this.comboBoxSites.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSites.FormattingEnabled = true;
            this.comboBoxSites.Items.AddRange(new object[] {
            "All Sites"});
            this.comboBoxSites.Location = new System.Drawing.Point(24, 26);
            this.comboBoxSites.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.comboBoxSites.Name = "comboBoxSites";
            this.comboBoxSites.Size = new System.Drawing.Size(377, 21);
            this.comboBoxSites.TabIndex = 0;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "All Status",
            "Active",
            "Inactive"});
            this.comboBoxStatus.Location = new System.Drawing.Point(411, 26);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(148, 21);
            this.comboBoxStatus.TabIndex = 1;
            // 
            // formItemPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(946, 493);
            this.Controls.Add(this.comboBoxSites);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelListCount);
            this.Controls.Add(this.buttonPaginateBack);
            this.Controls.Add(this.labelPaginateTotalPage);
            this.Controls.Add(this.textBoxPaginatePage);
            this.Controls.Add(this.buttonPaginateNext);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formItemPicker";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose Item";
            this.Load += new System.EventHandler(this.formItemPicker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPaginateBack;
        private System.Windows.Forms.Label labelPaginateTotalPage;
        private System.Windows.Forms.TextBox textBoxPaginatePage;
        private System.Windows.Forms.Button buttonPaginateNext;
        private System.Windows.Forms.Label labelListCount;
        private System.Windows.Forms.Button buttonSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorkerList;
        private System.Windows.Forms.ComboBox comboBoxSites;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalIndex;
    }
}