
namespace Inventory_System
{
    partial class formAddEditItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBoxSites = new System.Windows.Forms.CheckedListBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCreationInfo = new System.Windows.Forms.Label();
            this.backgroundWorkerGetAllSites = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerAdd = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxDescription = new Inventory_System.ui.CustomTextBox();
            this.comboBoxStatus = new Inventory_System.ui.CustomComboBox();
            this.textBoxName = new Inventory_System.ui.CustomTextBox();
            this.textBoxBarcode = new Inventory_System.ui.CustomTextBox();
            this.buttonSelectAll = new Inventory_System.ui.CustomButton();
            this.buttonClose = new Inventory_System.ui.CustomButton();
            this.buttonSave = new Inventory_System.ui.CustomButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // checkedListBoxSites
            // 
            this.checkedListBoxSites.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxSites.CheckOnClick = true;
            this.checkedListBoxSites.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxSites.FormattingEnabled = true;
            this.checkedListBoxSites.Location = new System.Drawing.Point(312, 57);
            this.checkedListBoxSites.Margin = new System.Windows.Forms.Padding(15);
            this.checkedListBoxSites.Name = "checkedListBoxSites";
            this.checkedListBoxSites.Size = new System.Drawing.Size(476, 260);
            this.checkedListBoxSites.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(120)))), ((int)(((byte)(181)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(812, 5);
            this.panel8.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.labelCreationInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 60);
            this.panel1.TabIndex = 33;
            // 
            // labelCreationInfo
            // 
            this.labelCreationInfo.AllowDrop = true;
            this.labelCreationInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCreationInfo.AutoSize = true;
            this.labelCreationInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelCreationInfo.Location = new System.Drawing.Point(24, 26);
            this.labelCreationInfo.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.labelCreationInfo.Name = "labelCreationInfo";
            this.labelCreationInfo.Size = new System.Drawing.Size(0, 13);
            this.labelCreationInfo.TabIndex = 30;
            // 
            // backgroundWorkerGetAllSites
            // 
            this.backgroundWorkerGetAllSites.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerGetAllSites_DoWork);
            this.backgroundWorkerGetAllSites.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerGetAllSites_RunWorkerCompleted);
            // 
            // backgroundWorkerAdd
            // 
            this.backgroundWorkerAdd.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerAdd_DoWork);
            this.backgroundWorkerAdd.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerAdd_RunWorkerCompleted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(309, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Sites Assigned";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(15, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 61;
            this.label8.Text = "Item Identification";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(15, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 62;
            this.label2.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(15, 257);
            this.label9.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 65;
            this.label9.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(15, 182);
            this.label10.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 66;
            this.label10.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.White;
            this.textBoxDescription.BorderColor = System.Drawing.Color.Gray;
            this.textBoxDescription.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBoxDescription.BorderRadius = 1;
            this.textBoxDescription.BorderSize = 1;
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxDescription.Location = new System.Drawing.Point(18, 207);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(15, 4, 4, 4);
            this.textBoxDescription.Multiline = false;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxDescription.PasswordChar = false;
            this.textBoxDescription.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxDescription.PlaceholderText = "";
            this.textBoxDescription.Size = new System.Drawing.Size(275, 31);
            this.textBoxDescription.TabIndex = 2;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxDescription.Texts = "";
            this.textBoxDescription.UnderlinedStyle = false;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.BackColor = System.Drawing.Color.White;
            this.comboBoxStatus.BorderColor = System.Drawing.Color.Gray;
            this.comboBoxStatus.BorderSize = 1;
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxStatus.IconColor = System.Drawing.Color.Gray;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.comboBoxStatus.ListBackColor = System.Drawing.Color.White;
            this.comboBoxStatus.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxStatus.Location = new System.Drawing.Point(18, 281);
            this.comboBoxStatus.MinimumSize = new System.Drawing.Size(100, 30);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxStatus.Size = new System.Drawing.Size(275, 30);
            this.comboBoxStatus.TabIndex = 3;
            this.comboBoxStatus.Texts = "";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.White;
            this.textBoxName.BorderColor = System.Drawing.Color.Gray;
            this.textBoxName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBoxName.BorderRadius = 1;
            this.textBoxName.BorderSize = 1;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxName.Location = new System.Drawing.Point(18, 132);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(15, 4, 4, 4);
            this.textBoxName.Multiline = false;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxName.PasswordChar = false;
            this.textBoxName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxName.PlaceholderText = "";
            this.textBoxName.Size = new System.Drawing.Size(275, 31);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TabStop = false;
            this.textBoxName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxName.Texts = "";
            this.textBoxName.UnderlinedStyle = false;
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.BackColor = System.Drawing.Color.White;
            this.textBoxBarcode.BorderColor = System.Drawing.Color.Gray;
            this.textBoxBarcode.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBoxBarcode.BorderRadius = 1;
            this.textBoxBarcode.BorderSize = 1;
            this.textBoxBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxBarcode.Location = new System.Drawing.Point(18, 57);
            this.textBoxBarcode.Margin = new System.Windows.Forms.Padding(15, 4, 4, 4);
            this.textBoxBarcode.Multiline = false;
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxBarcode.PasswordChar = false;
            this.textBoxBarcode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxBarcode.PlaceholderText = "";
            this.textBoxBarcode.Size = new System.Drawing.Size(275, 31);
            this.textBoxBarcode.TabIndex = 0;
            this.textBoxBarcode.TabStop = false;
            this.textBoxBarcode.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxBarcode.Texts = "";
            this.textBoxBarcode.UnderlinedStyle = false;
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectAll.BackColor = System.Drawing.Color.White;
            this.buttonSelectAll.BackgroundColor = System.Drawing.Color.White;
            this.buttonSelectAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.buttonSelectAll.BorderRadius = 10;
            this.buttonSelectAll.BorderSize = 1;
            this.buttonSelectAll.FlatAppearance.BorderSize = 0;
            this.buttonSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectAll.ForeColor = System.Drawing.Color.Black;
            this.buttonSelectAll.Location = new System.Drawing.Point(688, 15);
            this.buttonSelectAll.Margin = new System.Windows.Forms.Padding(3, 3, 15, 15);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(100, 30);
            this.buttonSelectAll.TabIndex = 4;
            this.buttonSelectAll.Text = "Assign to All";
            this.buttonSelectAll.TextColor = System.Drawing.Color.Black;
            this.buttonSelectAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSelectAll.UseVisualStyleBackColor = false;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
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
            this.buttonClose.Location = new System.Drawing.Point(688, 15);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 3, 15, 15);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 30);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Close";
            this.buttonClose.TextColor = System.Drawing.Color.Black;
            this.buttonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
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
            this.buttonSave.Location = new System.Drawing.Point(582, 15);
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
            // formAddEditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(812, 400);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxBarcode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSelectAll);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.checkedListBoxSites);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAddEditItem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.formAddEditItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBoxSites;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerGetAllSites;
        private System.ComponentModel.BackgroundWorker backgroundWorkerAdd;
        private System.Windows.Forms.Label labelCreationInfo;
        private ui.CustomButton buttonClose;
        private ui.CustomButton buttonSave;
        private ui.CustomButton buttonSelectAll;
        private System.Windows.Forms.Label label6;
        private ui.CustomTextBox textBoxBarcode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private ui.CustomTextBox textBoxName;
        private ui.CustomComboBox comboBoxStatus;
        private System.Windows.Forms.Label label9;
        private ui.CustomTextBox textBoxDescription;
        private System.Windows.Forms.Label label10;
    }
}