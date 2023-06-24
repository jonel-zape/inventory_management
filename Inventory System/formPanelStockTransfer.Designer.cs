
namespace Inventory_System
{
    partial class formPanelStockTransfer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelContent = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPaginateBack = new System.Windows.Forms.Button();
            this.labelPaginateTotalPage = new System.Windows.Forms.Label();
            this.textBoxPaginatePage = new System.Windows.Forms.TextBox();
            this.buttonPaginateNext = new System.Windows.Forms.Button();
            this.labelListCount = new System.Windows.Forms.Label();
            this.comboBoxSiteFrom = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSiteTo = new System.Windows.Forms.ComboBox();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transferFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transferTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view = new System.Windows.Forms.DataGridViewImageColumn();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.addNew = new System.Windows.Forms.Button();
            this.backgroundWorkerList = new System.ComponentModel.BackgroundWorker();
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
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.buttonPaginateBack);
            this.panelContent.Controls.Add(this.labelPaginateTotalPage);
            this.panelContent.Controls.Add(this.textBoxPaginatePage);
            this.panelContent.Controls.Add(this.buttonPaginateNext);
            this.panelContent.Controls.Add(this.labelListCount);
            this.panelContent.Controls.Add(this.comboBoxSiteFrom);
            this.panelContent.Controls.Add(this.dateTimePickerFrom);
            this.panelContent.Controls.Add(this.dateTimePickerTo);
            this.panelContent.Controls.Add(this.comboBoxSiteTo);
            this.panelContent.Controls.Add(this.dataGridViewList);
            this.panelContent.Controls.Add(this.buttonSearch);
            this.panelContent.Controls.Add(this.textBoxSearch);
            this.panelContent.Controls.Add(this.addNew);
            this.panelContent.Location = new System.Drawing.Point(12, 12);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1230, 720);
            this.panelContent.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(753, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Transfer To";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(951, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Input Search";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(555, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Transfer From";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(447, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Date To";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(339, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Date From";
            // 
            // buttonPaginateBack
            // 
            this.buttonPaginateBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPaginateBack.Image = global::Inventory_System.Properties.Resources.icons8_back_16;
            this.buttonPaginateBack.Location = new System.Drawing.Point(1000, 682);
            this.buttonPaginateBack.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.buttonPaginateBack.Name = "buttonPaginateBack";
            this.buttonPaginateBack.Size = new System.Drawing.Size(50, 23);
            this.buttonPaginateBack.TabIndex = 19;
            this.buttonPaginateBack.UseVisualStyleBackColor = true;
            this.buttonPaginateBack.Click += new System.EventHandler(this.buttonPaginateBack_Click);
            // 
            // labelPaginateTotalPage
            // 
            this.labelPaginateTotalPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPaginateTotalPage.AutoSize = true;
            this.labelPaginateTotalPage.Location = new System.Drawing.Point(1118, 687);
            this.labelPaginateTotalPage.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.labelPaginateTotalPage.Name = "labelPaginateTotalPage";
            this.labelPaginateTotalPage.Size = new System.Drawing.Size(37, 13);
            this.labelPaginateTotalPage.TabIndex = 23;
            this.labelPaginateTotalPage.Text = "of 999";
            // 
            // textBoxPaginatePage
            // 
            this.textBoxPaginatePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPaginatePage.Location = new System.Drawing.Point(1060, 684);
            this.textBoxPaginatePage.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.textBoxPaginatePage.MaxLength = 5;
            this.textBoxPaginatePage.Name = "textBoxPaginatePage";
            this.textBoxPaginatePage.Size = new System.Drawing.Size(48, 20);
            this.textBoxPaginatePage.TabIndex = 20;
            this.textBoxPaginatePage.Text = "1";
            this.textBoxPaginatePage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPaginatePage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPaginatePage_KeyDown);
            // 
            // buttonPaginateNext
            // 
            this.buttonPaginateNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPaginateNext.Image = global::Inventory_System.Properties.Resources.icons8_forward_16;
            this.buttonPaginateNext.Location = new System.Drawing.Point(1165, 682);
            this.buttonPaginateNext.Margin = new System.Windows.Forms.Padding(5, 5, 15, 15);
            this.buttonPaginateNext.Name = "buttonPaginateNext";
            this.buttonPaginateNext.Size = new System.Drawing.Size(50, 23);
            this.buttonPaginateNext.TabIndex = 21;
            this.buttonPaginateNext.UseVisualStyleBackColor = true;
            this.buttonPaginateNext.Click += new System.EventHandler(this.buttonPaginateNext_Click);
            // 
            // labelListCount
            // 
            this.labelListCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelListCount.AutoSize = true;
            this.labelListCount.Location = new System.Drawing.Point(12, 687);
            this.labelListCount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.labelListCount.Name = "labelListCount";
            this.labelListCount.Size = new System.Drawing.Size(43, 13);
            this.labelListCount.TabIndex = 22;
            this.labelListCount.Text = "Total: 0";
            // 
            // comboBoxSiteFrom
            // 
            this.comboBoxSiteFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSiteFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSiteFrom.FormattingEnabled = true;
            this.comboBoxSiteFrom.Items.AddRange(new object[] {
            "From: All Sites",
            "From: Site 1",
            "From: Site 2",
            "From: Site 3"});
            this.comboBoxSiteFrom.Location = new System.Drawing.Point(558, 40);
            this.comboBoxSiteFrom.Margin = new System.Windows.Forms.Padding(5, 40, 5, 5);
            this.comboBoxSiteFrom.Name = "comboBoxSiteFrom";
            this.comboBoxSiteFrom.Size = new System.Drawing.Size(188, 21);
            this.comboBoxSiteFrom.TabIndex = 15;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(342, 40);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(5, 40, 5, 5);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerFrom.TabIndex = 13;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(450, 40);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(5, 40, 5, 5);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerTo.TabIndex = 12;
            // 
            // comboBoxSiteTo
            // 
            this.comboBoxSiteTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSiteTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSiteTo.FormattingEnabled = true;
            this.comboBoxSiteTo.Items.AddRange(new object[] {
            "To: All Sites",
            "To: Site 1",
            "To: Site 2",
            "To: Site 3"});
            this.comboBoxSiteTo.Location = new System.Drawing.Point(756, 40);
            this.comboBoxSiteTo.Margin = new System.Windows.Forms.Padding(5, 40, 5, 5);
            this.comboBoxSiteTo.Name = "comboBoxSiteTo";
            this.comboBoxSiteTo.Size = new System.Drawing.Size(188, 21);
            this.comboBoxSiteTo.TabIndex = 11;
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
            this.dateTime,
            this.transferFrom,
            this.transferTo,
            this.createdBy,
            this.notes,
            this.view});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewList.GridColor = System.Drawing.Color.Silver;
            this.dataGridViewList.Location = new System.Drawing.Point(15, 71);
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
            this.dataGridViewList.Size = new System.Drawing.Size(1200, 601);
            this.dataGridViewList.TabIndex = 3;
            this.dataGridViewList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewList_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "Transaction ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 110;
            // 
            // dateTime
            // 
            this.dateTime.HeaderText = "Date and Time";
            this.dateTime.Name = "dateTime";
            this.dateTime.ReadOnly = true;
            this.dateTime.Width = 200;
            // 
            // transferFrom
            // 
            this.transferFrom.HeaderText = "Transfer From";
            this.transferFrom.Name = "transferFrom";
            this.transferFrom.ReadOnly = true;
            this.transferFrom.Width = 180;
            // 
            // transferTo
            // 
            this.transferTo.HeaderText = "Transfer To";
            this.transferTo.Name = "transferTo";
            this.transferTo.ReadOnly = true;
            this.transferTo.Width = 180;
            // 
            // createdBy
            // 
            this.createdBy.HeaderText = "Created By";
            this.createdBy.Name = "createdBy";
            this.createdBy.ReadOnly = true;
            // 
            // notes
            // 
            this.notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.notes.HeaderText = "Notes";
            this.notes.MinimumWidth = 100;
            this.notes.Name = "notes";
            this.notes.ReadOnly = true;
            // 
            // view
            // 
            this.view.HeaderText = "";
            this.view.Image = global::Inventory_System.Properties.Resources.icons8_show_property_16;
            this.view.Name = "view";
            this.view.ReadOnly = true;
            this.view.Width = 50;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Image = global::Inventory_System.Properties.Resources.icons8_search_16;
            this.buttonSearch.Location = new System.Drawing.Point(1165, 38);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(5, 40, 5, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(50, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(954, 40);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(5, 40, 5, 5);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(201, 20);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            // 
            // addNew
            // 
            this.addNew.BackgroundImage = global::Inventory_System.Properties.Resources.icons8_add_16;
            this.addNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addNew.Location = new System.Drawing.Point(15, 38);
            this.addNew.Margin = new System.Windows.Forms.Padding(15, 40, 15, 5);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(124, 23);
            this.addNew.TabIndex = 0;
            this.addNew.Text = "New Transaction";
            this.addNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addNew.UseVisualStyleBackColor = true;
            this.addNew.Click += new System.EventHandler(this.addNew_Click);
            // 
            // backgroundWorkerList
            // 
            this.backgroundWorkerList.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerList_DoWork);
            this.backgroundWorkerList.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerList_RunWorkerCompleted);
            // 
            // formPanelStockTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 744);
            this.Controls.Add(this.panelContent);
            this.Name = "formPanelStockTransfer";
            this.Text = "formPanelStockTransfer";
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.ComboBox comboBoxSiteTo;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button addNew;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.ComboBox comboBoxSiteFrom;
        private System.Windows.Forms.Button buttonPaginateBack;
        private System.Windows.Forms.Label labelPaginateTotalPage;
        private System.Windows.Forms.TextBox textBoxPaginatePage;
        private System.Windows.Forms.Button buttonPaginateNext;
        private System.Windows.Forms.Label labelListCount;
        private System.ComponentModel.BackgroundWorker backgroundWorkerList;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn transferFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn transferTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
        private System.Windows.Forms.DataGridViewImageColumn view;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}