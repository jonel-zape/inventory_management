
namespace Inventory_System
{
    partial class formPanelSites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPanelSites));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelContent = new System.Windows.Forms.Panel();
            this.paginationControl1 = new Inventory_System.ui.PaginationControl();
            this.addNew = new Inventory_System.ui.CustomButton();
            this.buttonSearch = new Inventory_System.ui.CustomButton();
            this.textBoxSearch = new Inventory_System.ui.CustomTextBox();
            this.comboBoxStatus = new Inventory_System.ui.CustomComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.backgroundWorkerList = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerDeleteSite = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.panelContent.Controls.Add(this.addNew);
            this.panelContent.Controls.Add(this.buttonSearch);
            this.panelContent.Controls.Add(this.textBoxSearch);
            this.panelContent.Controls.Add(this.comboBoxStatus);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.dataGridViewList);
            this.panelContent.Location = new System.Drawing.Point(12, 12);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1044, 584);
            this.panelContent.TabIndex = 1;
            // 
            // paginationControl1
            // 
            this.paginationControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.paginationControl1.BackColor = System.Drawing.Color.Transparent;
            this.paginationControl1.CurrentPage = 1;
            this.paginationControl1.Location = new System.Drawing.Point(842, 515);
            this.paginationControl1.Margin = new System.Windows.Forms.Padding(3, 3, 15, 15);
            this.paginationControl1.Name = "paginationControl1";
            this.paginationControl1.Size = new System.Drawing.Size(187, 54);
            this.paginationControl1.TabIndex = 5;
            this.paginationControl1.TotalPage = 100;
            this.paginationControl1.TotalRow = 999;
            this.paginationControl1.PageChanged += new System.EventHandler(this.paginationControl1_PageChanged);
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
            this.addNew.Location = new System.Drawing.Point(15, 39);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(100, 30);
            this.addNew.TabIndex = 0;
            this.addNew.Text = "New";
            this.addNew.TextColor = System.Drawing.Color.White;
            this.addNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addNew.UseVisualStyleBackColor = false;
            this.addNew.Click += new System.EventHandler(this.addNew_Click);
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
            this.buttonSearch.Location = new System.Drawing.Point(985, 39);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(44, 30);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
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
            this.textBoxSearch.Location = new System.Drawing.Point(728, 39);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Multiline = false;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxSearch.PasswordChar = false;
            this.textBoxSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxSearch.PlaceholderText = "Search by Name, Address, Details";
            this.textBoxSearch.Size = new System.Drawing.Size(250, 31);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxSearch.Texts = "";
            this.textBoxSearch.UnderlinedStyle = false;
            this.textBoxSearch._TextChanged += new System.EventHandler(this.textBoxSearch__TextChanged);
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
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
            "Active",
            "Inactive"});
            this.comboBoxStatus.ListBackColor = System.Drawing.Color.White;
            this.comboBoxStatus.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxStatus.Location = new System.Drawing.Point(521, 39);
            this.comboBoxStatus.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxStatus.Size = new System.Drawing.Size(200, 30);
            this.comboBoxStatus.TabIndex = 1;
            this.comboBoxStatus.Texts = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(725, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Input Search";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(518, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Status";
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
            this.name,
            this.address,
            this.details,
            this.status,
            this.inventory,
            this.edit,
            this.delete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewList.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.dataGridViewList.Size = new System.Drawing.Size(1014, 428);
            this.dataGridViewList.TabIndex = 4;
            this.dataGridViewList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewList_CellClick);
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 60;
            // 
            // name
            // 
            this.name.Frozen = true;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // address
            // 
            this.address.Frozen = true;
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 200;
            // 
            // details
            // 
            this.details.Frozen = true;
            this.details.HeaderText = "Details";
            this.details.Name = "details";
            this.details.ReadOnly = true;
            this.details.Width = 200;
            // 
            // status
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.status.DefaultCellStyle = dataGridViewCellStyle3;
            this.status.Frozen = true;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // inventory
            // 
            this.inventory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.inventory.HeaderText = "Total Inventory (All Items)";
            this.inventory.Name = "inventory";
            this.inventory.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.HeaderText = "";
            this.edit.Image = global::Inventory_System.Properties.Resources.icons8_pencil_16;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Width = 50;
            // 
            // delete
            // 
            this.delete.HeaderText = "";
            this.delete.Image = global::Inventory_System.Properties.Resources.icons8_trash_16;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 50;
            // 
            // backgroundWorkerList
            // 
            this.backgroundWorkerList.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerList_DoWork);
            this.backgroundWorkerList.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerList_RunWorkerCompleted);
            // 
            // backgroundWorkerDeleteSite
            // 
            this.backgroundWorkerDeleteSite.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerDeleteSite_DoWork);
            this.backgroundWorkerDeleteSite.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerDeleteSite_RunWorkerCompleted);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Inventory_System.Properties.Resources.icons8_pencil_16;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.ToolTipText = "Edit";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Inventory_System.Properties.Resources.icons8_trash_16;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.ToolTipText = "Delete";
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // formPanelSites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 608);
            this.Controls.Add(this.panelContent);
            this.Name = "formPanelSites";
            this.Text = "formPanelSites";
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
        private System.ComponentModel.BackgroundWorker backgroundWorkerList;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn details;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventory;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.ComponentModel.BackgroundWorker backgroundWorkerDeleteSite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ui.CustomComboBox comboBoxStatus;
        private ui.CustomTextBox textBoxSearch;
        private ui.CustomButton buttonSearch;
        private ui.CustomButton addNew;
        private ui.PaginationControl paginationControl1;
    }
}