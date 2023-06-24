
namespace Inventory_System
{
    partial class formPanelInventoryAdjustment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelContent = new System.Windows.Forms.Panel();
            this.buttonPaginateBack = new System.Windows.Forms.Button();
            this.labelPaginateTotalPage = new System.Windows.Forms.Label();
            this.textBoxPaginatePage = new System.Windows.Forms.TextBox();
            this.buttonPaginateNext = new System.Windows.Forms.Button();
            this.labelListCount = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSites = new System.Windows.Forms.ComboBox();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view = new System.Windows.Forms.DataGridViewImageColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.addNew = new System.Windows.Forms.Button();
            this.backgroundWorkerList = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.buttonPaginateBack);
            this.panelContent.Controls.Add(this.labelPaginateTotalPage);
            this.panelContent.Controls.Add(this.textBoxPaginatePage);
            this.panelContent.Controls.Add(this.buttonPaginateNext);
            this.panelContent.Controls.Add(this.labelListCount);
            this.panelContent.Controls.Add(this.dateTimePickerFrom);
            this.panelContent.Controls.Add(this.dateTimePickerTo);
            this.panelContent.Controls.Add(this.comboBoxSites);
            this.panelContent.Controls.Add(this.dataGridViewList);
            this.panelContent.Controls.Add(this.button2);
            this.panelContent.Controls.Add(this.textBoxSearch);
            this.panelContent.Controls.Add(this.addNew);
            this.panelContent.Location = new System.Drawing.Point(12, 12);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1226, 679);
            this.panelContent.TabIndex = 4;
            // 
            // buttonPaginateBack
            // 
            this.buttonPaginateBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPaginateBack.Image = global::Inventory_System.Properties.Resources.icons8_back_16;
            this.buttonPaginateBack.Location = new System.Drawing.Point(996, 644);
            this.buttonPaginateBack.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.buttonPaginateBack.Name = "buttonPaginateBack";
            this.buttonPaginateBack.Size = new System.Drawing.Size(50, 23);
            this.buttonPaginateBack.TabIndex = 6;
            this.buttonPaginateBack.UseVisualStyleBackColor = true;
            this.buttonPaginateBack.Click += new System.EventHandler(this.buttonPaginateBack_Click);
            // 
            // labelPaginateTotalPage
            // 
            this.labelPaginateTotalPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPaginateTotalPage.AutoSize = true;
            this.labelPaginateTotalPage.Location = new System.Drawing.Point(1114, 649);
            this.labelPaginateTotalPage.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.labelPaginateTotalPage.Name = "labelPaginateTotalPage";
            this.labelPaginateTotalPage.Size = new System.Drawing.Size(37, 13);
            this.labelPaginateTotalPage.TabIndex = 18;
            this.labelPaginateTotalPage.Text = "of 999";
            // 
            // textBoxPaginatePage
            // 
            this.textBoxPaginatePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPaginatePage.Location = new System.Drawing.Point(1056, 646);
            this.textBoxPaginatePage.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.textBoxPaginatePage.MaxLength = 5;
            this.textBoxPaginatePage.Name = "textBoxPaginatePage";
            this.textBoxPaginatePage.Size = new System.Drawing.Size(48, 20);
            this.textBoxPaginatePage.TabIndex = 7;
            this.textBoxPaginatePage.Text = "1";
            this.textBoxPaginatePage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPaginatePage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPaginatePage_KeyDown);
            // 
            // buttonPaginateNext
            // 
            this.buttonPaginateNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPaginateNext.Image = global::Inventory_System.Properties.Resources.icons8_forward_16;
            this.buttonPaginateNext.Location = new System.Drawing.Point(1161, 644);
            this.buttonPaginateNext.Margin = new System.Windows.Forms.Padding(5, 5, 15, 15);
            this.buttonPaginateNext.Name = "buttonPaginateNext";
            this.buttonPaginateNext.Size = new System.Drawing.Size(50, 23);
            this.buttonPaginateNext.TabIndex = 8;
            this.buttonPaginateNext.UseVisualStyleBackColor = true;
            this.buttonPaginateNext.Click += new System.EventHandler(this.buttonPaginateNext_Click);
            // 
            // labelListCount
            // 
            this.labelListCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelListCount.AutoSize = true;
            this.labelListCount.Location = new System.Drawing.Point(12, 649);
            this.labelListCount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.labelListCount.Name = "labelListCount";
            this.labelListCount.Size = new System.Drawing.Size(43, 13);
            this.labelListCount.TabIndex = 15;
            this.labelListCount.Text = "Total: 0";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(536, 40);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(5, 40, 5, 5);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerFrom.TabIndex = 1;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(644, 40);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(5, 40, 5, 5);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerTo.TabIndex = 2;
            // 
            // comboBoxSites
            // 
            this.comboBoxSites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSites.FormattingEnabled = true;
            this.comboBoxSites.Items.AddRange(new object[] {
            "All Sites",
            "Site 1",
            "Site 2",
            "Site 3"});
            this.comboBoxSites.Location = new System.Drawing.Point(752, 40);
            this.comboBoxSites.Margin = new System.Windows.Forms.Padding(5, 40, 5, 5);
            this.comboBoxSites.Name = "comboBoxSites";
            this.comboBoxSites.Size = new System.Drawing.Size(188, 21);
            this.comboBoxSites.TabIndex = 3;
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.AllowUserToAddRows = false;
            this.dataGridViewList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewList.ColumnHeadersHeight = 45;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dateTime,
            this.site,
            this.createdBy,
            this.notes,
            this.view});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewList.DefaultCellStyle = dataGridViewCellStyle9;
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
            this.dataGridViewList.Size = new System.Drawing.Size(1196, 558);
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
            // site
            // 
            this.site.HeaderText = "Site";
            this.site.Name = "site";
            this.site.ReadOnly = true;
            this.site.Width = 200;
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
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Image = global::Inventory_System.Properties.Resources.icons8_search_16;
            this.button2.Location = new System.Drawing.Point(1161, 38);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 40, 5, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(950, 40);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(5, 40, 5, 5);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(201, 20);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            // 
            // addNew
            // 
            this.addNew.BackgroundImage = global::Inventory_System.Properties.Resources.icons8_add_16;
            this.addNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addNew.Location = new System.Drawing.Point(15, 37);
            this.addNew.Margin = new System.Windows.Forms.Padding(15, 40, 15, 5);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(124, 23);
            this.addNew.TabIndex = 0;
            this.addNew.Text = "New Adjustment";
            this.addNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addNew.UseVisualStyleBackColor = true;
            this.addNew.Click += new System.EventHandler(this.addNew_Click);
            // 
            // backgroundWorkerList
            // 
            this.backgroundWorkerList.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerList_DoWork);
            this.backgroundWorkerList.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerList_RunWorkerCompleted);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(533, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Date From";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(641, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Date To";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(749, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Site";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(947, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Input Search";
            // 
            // formPanelInventoryAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 703);
            this.Controls.Add(this.panelContent);
            this.Name = "formPanelInventoryAdjustment";
            this.Text = "formPanelInventoryAdjustment";
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.ComboBox comboBoxSites;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button addNew;
        private System.Windows.Forms.Button buttonPaginateBack;
        private System.Windows.Forms.Label labelPaginateTotalPage;
        private System.Windows.Forms.TextBox textBoxPaginatePage;
        private System.Windows.Forms.Button buttonPaginateNext;
        private System.Windows.Forms.Label labelListCount;
        private System.ComponentModel.BackgroundWorker backgroundWorkerList;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn site;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
        private System.Windows.Forms.DataGridViewImageColumn view;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}