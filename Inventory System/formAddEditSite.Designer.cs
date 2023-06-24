
namespace Inventory_System
{
    partial class formAddEditSite
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
            this.labelId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.backgroundWorkerAddSite = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerUpdateSite = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.customTextBox3 = new Inventory_System.ui.CustomTextBox();
            this.customTextBox2 = new Inventory_System.ui.CustomTextBox();
            this.customComboBox1 = new Inventory_System.ui.CustomComboBox();
            this.comboBoxStatus = new Inventory_System.ui.CustomComboBox();
            this.textBoxDetails = new Inventory_System.ui.CustomTextBox();
            this.textBoxAddress = new Inventory_System.ui.CustomTextBox();
            this.textBoxName = new Inventory_System.ui.CustomTextBox();
            this.customTextBoxID = new Inventory_System.ui.CustomTextBox();
            this.customButtonClose = new Inventory_System.ui.CustomButton();
            this.customButtonSave = new Inventory_System.ui.CustomButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelId.Location = new System.Drawing.Point(21, 23);
            this.labelId.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(144, 16);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "ID (System Generated)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(229, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(21, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(21, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(21, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(120)))), ((int)(((byte)(181)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(451, 5);
            this.panel8.TabIndex = 31;
            // 
            // backgroundWorkerAddSite
            // 
            this.backgroundWorkerAddSite.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerAddSite_DoWork);
            this.backgroundWorkerAddSite.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerAddSite_RunWorkerCompleted);
            // 
            // backgroundWorkerUpdateSite
            // 
            this.backgroundWorkerUpdateSite.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerUpdateSite_DoWork);
            this.backgroundWorkerUpdateSite.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerUpdateSite_RunWorkerCompleted);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.customButtonClose);
            this.panel1.Controls.Add(this.customButtonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 399);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 60);
            this.panel1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(229, 249);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(21, 321);
            this.label6.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 68;
            this.label6.Text = "Contact Person";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(229, 321);
            this.label7.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 70;
            this.label7.Text = "Contact Number";
            // 
            // customTextBox3
            // 
            this.customTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox3.BorderColor = System.Drawing.Color.Gray;
            this.customTextBox3.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.customTextBox3.BorderRadius = 1;
            this.customTextBox3.BorderSize = 1;
            this.customTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customTextBox3.Location = new System.Drawing.Point(232, 346);
            this.customTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox3.Multiline = false;
            this.customTextBox3.Name = "customTextBox3";
            this.customTextBox3.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBox3.PasswordChar = false;
            this.customTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox3.PlaceholderText = "";
            this.customTextBox3.Size = new System.Drawing.Size(195, 31);
            this.customTextBox3.TabIndex = 6;
            this.customTextBox3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.customTextBox3.Texts = "";
            this.customTextBox3.UnderlinedStyle = false;
            // 
            // customTextBox2
            // 
            this.customTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox2.BorderColor = System.Drawing.Color.Gray;
            this.customTextBox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.customTextBox2.BorderRadius = 1;
            this.customTextBox2.BorderSize = 1;
            this.customTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customTextBox2.Location = new System.Drawing.Point(24, 346);
            this.customTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox2.Multiline = false;
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBox2.PasswordChar = false;
            this.customTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox2.PlaceholderText = "";
            this.customTextBox2.Size = new System.Drawing.Size(189, 31);
            this.customTextBox2.TabIndex = 5;
            this.customTextBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.customTextBox2.Texts = "";
            this.customTextBox2.UnderlinedStyle = false;
            // 
            // customComboBox1
            // 
            this.customComboBox1.BackColor = System.Drawing.Color.White;
            this.customComboBox1.BorderColor = System.Drawing.Color.Gray;
            this.customComboBox1.BorderSize = 1;
            this.customComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customComboBox1.IconColor = System.Drawing.Color.Gray;
            this.customComboBox1.Items.AddRange(new object[] {
            "Warehouse",
            "Branch"});
            this.customComboBox1.ListBackColor = System.Drawing.Color.White;
            this.customComboBox1.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customComboBox1.Location = new System.Drawing.Point(24, 273);
            this.customComboBox1.MinimumSize = new System.Drawing.Size(100, 30);
            this.customComboBox1.Name = "customComboBox1";
            this.customComboBox1.Padding = new System.Windows.Forms.Padding(1);
            this.customComboBox1.Size = new System.Drawing.Size(189, 30);
            this.customComboBox1.TabIndex = 3;
            this.customComboBox1.Texts = "";
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
            this.comboBoxStatus.Location = new System.Drawing.Point(232, 273);
            this.comboBoxStatus.MinimumSize = new System.Drawing.Size(100, 30);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxStatus.Size = new System.Drawing.Size(195, 30);
            this.comboBoxStatus.TabIndex = 4;
            this.comboBoxStatus.Texts = "";
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDetails.BorderColor = System.Drawing.Color.Gray;
            this.textBoxDetails.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBoxDetails.BorderRadius = 1;
            this.textBoxDetails.BorderSize = 1;
            this.textBoxDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxDetails.Location = new System.Drawing.Point(24, 199);
            this.textBoxDetails.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDetails.Multiline = false;
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxDetails.PasswordChar = false;
            this.textBoxDetails.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxDetails.PlaceholderText = "";
            this.textBoxDetails.Size = new System.Drawing.Size(403, 31);
            this.textBoxDetails.TabIndex = 2;
            this.textBoxDetails.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxDetails.Texts = "";
            this.textBoxDetails.UnderlinedStyle = false;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxAddress.BorderColor = System.Drawing.Color.Gray;
            this.textBoxAddress.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBoxAddress.BorderRadius = 1;
            this.textBoxAddress.BorderSize = 1;
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxAddress.Location = new System.Drawing.Point(24, 124);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddress.Multiline = false;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxAddress.PasswordChar = false;
            this.textBoxAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxAddress.PlaceholderText = "";
            this.textBoxAddress.Size = new System.Drawing.Size(403, 31);
            this.textBoxAddress.TabIndex = 1;
            this.textBoxAddress.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxAddress.Texts = "";
            this.textBoxAddress.UnderlinedStyle = false;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxName.BorderColor = System.Drawing.Color.Gray;
            this.textBoxName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBoxName.BorderRadius = 1;
            this.textBoxName.BorderSize = 1;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxName.Location = new System.Drawing.Point(232, 49);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(15, 4, 15, 4);
            this.textBoxName.Multiline = false;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxName.PasswordChar = false;
            this.textBoxName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxName.PlaceholderText = "";
            this.textBoxName.Size = new System.Drawing.Size(195, 31);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxName.Texts = "";
            this.textBoxName.UnderlinedStyle = false;
            // 
            // customTextBoxID
            // 
            this.customTextBoxID.BackColor = System.Drawing.Color.White;
            this.customTextBoxID.BorderColor = System.Drawing.Color.Gray;
            this.customTextBoxID.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.customTextBoxID.BorderRadius = 1;
            this.customTextBoxID.BorderSize = 1;
            this.customTextBoxID.Enabled = false;
            this.customTextBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBoxID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customTextBoxID.Location = new System.Drawing.Point(24, 49);
            this.customTextBoxID.Margin = new System.Windows.Forms.Padding(15, 4, 4, 4);
            this.customTextBoxID.Multiline = false;
            this.customTextBoxID.Name = "customTextBoxID";
            this.customTextBoxID.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxID.PasswordChar = false;
            this.customTextBoxID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBoxID.PlaceholderText = "";
            this.customTextBoxID.Size = new System.Drawing.Size(189, 31);
            this.customTextBoxID.TabIndex = 59;
            this.customTextBoxID.TabStop = false;
            this.customTextBoxID.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.customTextBoxID.Texts = "";
            this.customTextBoxID.UnderlinedStyle = false;
            // 
            // customButtonClose
            // 
            this.customButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customButtonClose.BackColor = System.Drawing.Color.White;
            this.customButtonClose.BackgroundColor = System.Drawing.Color.White;
            this.customButtonClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.customButtonClose.BorderRadius = 10;
            this.customButtonClose.BorderSize = 1;
            this.customButtonClose.FlatAppearance.BorderSize = 0;
            this.customButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButtonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButtonClose.ForeColor = System.Drawing.Color.Black;
            this.customButtonClose.Location = new System.Drawing.Point(327, 15);
            this.customButtonClose.Margin = new System.Windows.Forms.Padding(3, 3, 15, 15);
            this.customButtonClose.Name = "customButtonClose";
            this.customButtonClose.Size = new System.Drawing.Size(100, 30);
            this.customButtonClose.TabIndex = 8;
            this.customButtonClose.Text = "Close";
            this.customButtonClose.TextColor = System.Drawing.Color.Black;
            this.customButtonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButtonClose.UseVisualStyleBackColor = false;
            this.customButtonClose.Click += new System.EventHandler(this.customButtonClose_Click);
            // 
            // customButtonSave
            // 
            this.customButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(173)))), ((int)(((byte)(106)))));
            this.customButtonSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(173)))), ((int)(((byte)(106)))));
            this.customButtonSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(146)))), ((int)(((byte)(91)))));
            this.customButtonSave.BorderRadius = 10;
            this.customButtonSave.BorderSize = 1;
            this.customButtonSave.FlatAppearance.BorderSize = 0;
            this.customButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButtonSave.ForeColor = System.Drawing.Color.White;
            this.customButtonSave.Location = new System.Drawing.Point(221, 15);
            this.customButtonSave.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.customButtonSave.Name = "customButtonSave";
            this.customButtonSave.Size = new System.Drawing.Size(100, 30);
            this.customButtonSave.TabIndex = 7;
            this.customButtonSave.Text = "Save";
            this.customButtonSave.TextColor = System.Drawing.Color.White;
            this.customButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButtonSave.UseVisualStyleBackColor = false;
            this.customButtonSave.Click += new System.EventHandler(this.customButtonSave_Click);
            // 
            // formAddEditSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(451, 459);
            this.Controls.Add(this.customTextBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.customTextBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.customComboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.textBoxDetails);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.customTextBoxID);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAddEditSite";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Site";
            this.Load += new System.EventHandler(this.formAddEditSite_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.ComponentModel.BackgroundWorker backgroundWorkerAddSite;
        private System.ComponentModel.BackgroundWorker backgroundWorkerUpdateSite;
        private System.Windows.Forms.Panel panel1;
        private ui.CustomButton customButtonSave;
        private ui.CustomButton customButtonClose;
        private ui.CustomTextBox customTextBoxID;
        private ui.CustomTextBox textBoxName;
        private ui.CustomTextBox textBoxAddress;
        private ui.CustomTextBox textBoxDetails;
        private ui.CustomComboBox comboBoxStatus;
        private ui.CustomComboBox customComboBox1;
        private System.Windows.Forms.Label label1;
        private ui.CustomTextBox customTextBox2;
        private System.Windows.Forms.Label label6;
        private ui.CustomTextBox customTextBox3;
        private System.Windows.Forms.Label label7;
    }
}