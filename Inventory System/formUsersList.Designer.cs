
namespace Inventory_System
{
    partial class formUsersList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.labelPaginateTotalPage = new System.Windows.Forms.Label();
            this.textBoxPaginatePage = new System.Windows.Forms.TextBox();
            this.labelListCount = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.buttonPaginateBack = new System.Windows.Forms.Button();
            this.buttonPaginateNext = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.addNew = new System.Windows.Forms.Button();
            this.backgroundWorkerLoad = new System.ComponentModel.BackgroundWorker();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.backgroundWorkerDelete = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(531, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Input Search";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(373, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Status";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "All",
            "Enabled",
            "Disabled"});
            this.comboBoxStatus.Location = new System.Drawing.Point(376, 49);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(5, 40, 5, 5);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(148, 21);
            this.comboBoxStatus.TabIndex = 1;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(534, 49);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(5, 40, 5, 5);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(260, 20);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.AllowUserToAddRows = false;
            this.dataGridViewList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewList.ColumnHeadersHeight = 45;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.address,
            this.details,
            this.status,
            this.edit,
            this.delete});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewList.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewList.GridColor = System.Drawing.Color.Silver;
            this.dataGridViewList.Location = new System.Drawing.Point(24, 80);
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
            this.dataGridViewList.Size = new System.Drawing.Size(830, 373);
            this.dataGridViewList.TabIndex = 4;
            this.dataGridViewList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewList_CellClick);
            // 
            // labelPaginateTotalPage
            // 
            this.labelPaginateTotalPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPaginateTotalPage.AutoSize = true;
            this.labelPaginateTotalPage.Location = new System.Drawing.Point(757, 468);
            this.labelPaginateTotalPage.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.labelPaginateTotalPage.Name = "labelPaginateTotalPage";
            this.labelPaginateTotalPage.Size = new System.Drawing.Size(37, 13);
            this.labelPaginateTotalPage.TabIndex = 21;
            this.labelPaginateTotalPage.Text = "of 999";
            // 
            // textBoxPaginatePage
            // 
            this.textBoxPaginatePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPaginatePage.Location = new System.Drawing.Point(699, 465);
            this.textBoxPaginatePage.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.textBoxPaginatePage.MaxLength = 5;
            this.textBoxPaginatePage.Name = "textBoxPaginatePage";
            this.textBoxPaginatePage.Size = new System.Drawing.Size(48, 20);
            this.textBoxPaginatePage.TabIndex = 6;
            this.textBoxPaginatePage.Text = "1";
            this.textBoxPaginatePage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPaginatePage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPaginatePage_KeyDown);
            // 
            // labelListCount
            // 
            this.labelListCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelListCount.AutoSize = true;
            this.labelListCount.Location = new System.Drawing.Point(21, 468);
            this.labelListCount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.labelListCount.Name = "labelListCount";
            this.labelListCount.Size = new System.Drawing.Size(47, 13);
            this.labelListCount.TabIndex = 23;
            this.labelListCount.Text = "Count: 0";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(115)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(878, 5);
            this.panel8.TabIndex = 34;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Inventory_System.Properties.Resources.icons8_pencil_16;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Inventory_System.Properties.Resources.icons8_trash_16;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // buttonPaginateBack
            // 
            this.buttonPaginateBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPaginateBack.Image = global::Inventory_System.Properties.Resources.icons8_back_16;
            this.buttonPaginateBack.Location = new System.Drawing.Point(639, 463);
            this.buttonPaginateBack.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.buttonPaginateBack.Name = "buttonPaginateBack";
            this.buttonPaginateBack.Size = new System.Drawing.Size(50, 23);
            this.buttonPaginateBack.TabIndex = 5;
            this.buttonPaginateBack.UseVisualStyleBackColor = true;
            this.buttonPaginateBack.Click += new System.EventHandler(this.buttonPaginateBack_Click);
            // 
            // buttonPaginateNext
            // 
            this.buttonPaginateNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPaginateNext.Image = global::Inventory_System.Properties.Resources.icons8_forward_16;
            this.buttonPaginateNext.Location = new System.Drawing.Point(804, 463);
            this.buttonPaginateNext.Margin = new System.Windows.Forms.Padding(5, 5, 15, 15);
            this.buttonPaginateNext.Name = "buttonPaginateNext";
            this.buttonPaginateNext.Size = new System.Drawing.Size(50, 23);
            this.buttonPaginateNext.TabIndex = 7;
            this.buttonPaginateNext.UseVisualStyleBackColor = true;
            this.buttonPaginateNext.Click += new System.EventHandler(this.buttonPaginateNext_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Image = global::Inventory_System.Properties.Resources.icons8_search_16;
            this.buttonSearch.Location = new System.Drawing.Point(804, 49);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(5, 40, 5, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(50, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // addNew
            // 
            this.addNew.BackgroundImage = global::Inventory_System.Properties.Resources.icons8_add_16;
            this.addNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addNew.Location = new System.Drawing.Point(24, 49);
            this.addNew.Margin = new System.Windows.Forms.Padding(15, 40, 15, 5);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(119, 23);
            this.addNew.TabIndex = 0;
            this.addNew.Text = "Add New User";
            this.addNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addNew.UseVisualStyleBackColor = true;
            this.addNew.Click += new System.EventHandler(this.addNew_Click);
            // 
            // backgroundWorkerLoad
            // 
            this.backgroundWorkerLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerLoad_DoWork);
            this.backgroundWorkerLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerLoad_RunWorkerCompleted);
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.Frozen = true;
            this.name.HeaderText = "Username";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // address
            // 
            this.address.Frozen = true;
            this.address.HeaderText = "First Name";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 200;
            // 
            // details
            // 
            this.details.Frozen = true;
            this.details.HeaderText = "Last Name";
            this.details.Name = "details";
            this.details.ReadOnly = true;
            this.details.Width = 200;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.status.DefaultCellStyle = dataGridViewCellStyle7;
            this.status.Frozen = true;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 127;
            // 
            // edit
            // 
            this.edit.Frozen = true;
            this.edit.HeaderText = "";
            this.edit.Image = global::Inventory_System.Properties.Resources.icons8_pencil_16;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Width = 50;
            // 
            // delete
            // 
            this.delete.Frozen = true;
            this.delete.HeaderText = "";
            this.delete.Image = global::Inventory_System.Properties.Resources.icons8_trash_16;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 50;
            // 
            // backgroundWorkerDelete
            // 
            this.backgroundWorkerDelete.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerDelete_DoWork);
            this.backgroundWorkerDelete.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerDelete_RunWorkerCompleted);
            // 
            // formUsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 510);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.labelListCount);
            this.Controls.Add(this.buttonPaginateBack);
            this.Controls.Add(this.labelPaginateTotalPage);
            this.Controls.Add(this.textBoxPaginatePage);
            this.Controls.Add(this.buttonPaginateNext);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.addNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formUsersList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.formUsersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Button buttonPaginateBack;
        private System.Windows.Forms.Label labelPaginateTotalPage;
        private System.Windows.Forms.TextBox textBoxPaginatePage;
        private System.Windows.Forms.Button buttonPaginateNext;
        private System.Windows.Forms.Label labelListCount;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn details;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.ComponentModel.BackgroundWorker backgroundWorkerDelete;
    }
}