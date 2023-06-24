
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSitesFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxSitesTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.buttonChooseItem = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDateAndTime = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transfer From:";
            // 
            // comboBoxSitesFrom
            // 
            this.comboBoxSitesFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSitesFrom.FormattingEnabled = true;
            this.comboBoxSitesFrom.Items.AddRange(new object[] {
            "From: All Sites",
            "From: Site 1",
            "From: Site 2",
            "From: Site 3"});
            this.comboBoxSitesFrom.Location = new System.Drawing.Point(24, 110);
            this.comboBoxSitesFrom.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.comboBoxSitesFrom.Name = "comboBoxSitesFrom";
            this.comboBoxSitesFrom.Size = new System.Drawing.Size(307, 21);
            this.comboBoxSitesFrom.TabIndex = 2;
            // 
            // comboBoxSitesTo
            // 
            this.comboBoxSitesTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSitesTo.FormattingEnabled = true;
            this.comboBoxSitesTo.Items.AddRange(new object[] {
            "From: All Sites",
            "From: Site 1",
            "From: Site 2",
            "From: Site 3"});
            this.comboBoxSitesTo.Location = new System.Drawing.Point(24, 174);
            this.comboBoxSitesTo.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.comboBoxSitesTo.Name = "comboBoxSitesTo";
            this.comboBoxSitesTo.Size = new System.Drawing.Size(307, 21);
            this.comboBoxSitesTo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Transfer To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Notes:";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(351, 111);
            this.textBoxNotes.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(323, 84);
            this.textBoxNotes.TabIndex = 4;
            // 
            // buttonChooseItem
            // 
            this.buttonChooseItem.Image = global::Inventory_System.Properties.Resources.icons8_add_16;
            this.buttonChooseItem.Location = new System.Drawing.Point(24, 215);
            this.buttonChooseItem.Margin = new System.Windows.Forms.Padding(5, 15, 15, 5);
            this.buttonChooseItem.Name = "buttonChooseItem";
            this.buttonChooseItem.Size = new System.Drawing.Size(75, 23);
            this.buttonChooseItem.TabIndex = 5;
            this.buttonChooseItem.Text = "Add Item";
            this.buttonChooseItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonChooseItem.UseVisualStyleBackColor = true;
            this.buttonChooseItem.Click += new System.EventHandler(this.buttonChooseItem_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(514, 16);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(5, 15, 5, 15);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
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
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(115)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(698, 5);
            this.panel8.TabIndex = 32;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Transaction ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Date and Time:";
            // 
            // textBoxDateAndTime
            // 
            this.textBoxDateAndTime.Location = new System.Drawing.Point(351, 47);
            this.textBoxDateAndTime.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.textBoxDateAndTime.Name = "textBoxDateAndTime";
            this.textBoxDateAndTime.ReadOnly = true;
            this.textBoxDateAndTime.Size = new System.Drawing.Size(323, 20);
            this.textBoxDateAndTime.TabIndex = 1;
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
            this.panel1.TabIndex = 38;
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
            this.barcode,
            this.name,
            this.currentInventory,
            this.quantity,
            this.buttonRemove});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewList.DefaultCellStyle = dataGridViewCellStyle8;
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
            this.dataGridViewList.Size = new System.Drawing.Size(650, 274);
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
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.DefaultCellStyle = dataGridViewCellStyle7;
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
            // formNewStockTransferTransaction
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
            this.Controls.Add(this.comboBoxSitesTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSitesFrom);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSitesFrom;
        private System.Windows.Forms.ComboBox comboBoxSitesTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Button buttonChooseItem;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDateAndTime;
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
    }
}