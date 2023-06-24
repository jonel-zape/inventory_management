
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
            this.textBoxDateAndTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonChooseItem = new System.Windows.Forms.Button();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSites = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorkerLoad = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerSave = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerLoadView = new System.ComponentModel.BackgroundWorker();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.before = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRemove = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.dataGridViewList.Size = new System.Drawing.Size(650, 270);
            this.dataGridViewList.TabIndex = 5;
            this.dataGridViewList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewList_CellClick);
            this.dataGridViewList.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewList_RowsAdded);
            this.dataGridViewList.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewList_RowsRemoved);
            // 
            // textBoxDateAndTime
            // 
            this.textBoxDateAndTime.Location = new System.Drawing.Point(351, 47);
            this.textBoxDateAndTime.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.textBoxDateAndTime.Name = "textBoxDateAndTime";
            this.textBoxDateAndTime.ReadOnly = true;
            this.textBoxDateAndTime.Size = new System.Drawing.Size(323, 20);
            this.textBoxDateAndTime.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Date and Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Transaction ID:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(24, 47);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(307, 20);
            this.textBoxId.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(115)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(698, 5);
            this.panel8.TabIndex = 47;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(514, 16);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(5, 15, 5, 15);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(599, 16);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(5, 15, 15, 15);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click_1);
            // 
            // buttonChooseItem
            // 
            this.buttonChooseItem.Image = global::Inventory_System.Properties.Resources.icons8_add_16;
            this.buttonChooseItem.Location = new System.Drawing.Point(24, 215);
            this.buttonChooseItem.Margin = new System.Windows.Forms.Padding(5, 15, 15, 5);
            this.buttonChooseItem.Name = "buttonChooseItem";
            this.buttonChooseItem.Size = new System.Drawing.Size(75, 23);
            this.buttonChooseItem.TabIndex = 4;
            this.buttonChooseItem.Text = "Add Item";
            this.buttonChooseItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonChooseItem.UseVisualStyleBackColor = true;
            this.buttonChooseItem.Click += new System.EventHandler(this.buttonChooseItem_Click_1);
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(351, 111);
            this.textBoxNotes.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.textBoxNotes.MaxLength = 1024;
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(323, 84);
            this.textBoxNotes.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Notes:";
            // 
            // comboBoxSites
            // 
            this.comboBoxSites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSites.FormattingEnabled = true;
            this.comboBoxSites.Location = new System.Drawing.Point(24, 110);
            this.comboBoxSites.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.comboBoxSites.Name = "comboBoxSites";
            this.comboBoxSites.Size = new System.Drawing.Size(307, 21);
            this.comboBoxSites.TabIndex = 2;
            this.comboBoxSites.SelectedIndexChanged += new System.EventHandler(this.comboBoxSites_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Site:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 540);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 55);
            this.panel1.TabIndex = 53;
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
            // formNewInventoryAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(698, 595);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.textBoxDateAndTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.buttonChooseItem);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSites);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.TextBox textBoxDateAndTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonChooseItem;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSites;
        private System.Windows.Forms.Label label1;
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
    }
}