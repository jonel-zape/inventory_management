
namespace Inventory_System
{
    partial class formSettings
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorkerDeploy = new System.ComponentModel.BackgroundWorker();
            this.textBoxHost = new Inventory_System.ui.CustomTextBox();
            this.labelRemaining = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsername = new Inventory_System.ui.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new Inventory_System.ui.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDatabase = new Inventory_System.ui.CustomTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAuthCode = new Inventory_System.ui.CustomTextBox();
            this.buttonClose = new Inventory_System.ui.CustomButton();
            this.buttonApply = new Inventory_System.ui.CustomButton();
            this.buttonSetup = new Inventory_System.ui.CustomButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(120)))), ((int)(((byte)(181)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(375, 5);
            this.panel8.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonSetup);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonApply);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 60);
            this.panel1.TabIndex = 55;
            // 
            // backgroundWorkerDeploy
            // 
            this.backgroundWorkerDeploy.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerDeploy_DoWork);
            this.backgroundWorkerDeploy.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerDeploy_RunWorkerCompleted);
            // 
            // textBoxHost
            // 
            this.textBoxHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHost.BackColor = System.Drawing.Color.White;
            this.textBoxHost.BorderColor = System.Drawing.Color.Gray;
            this.textBoxHost.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBoxHost.BorderRadius = 1;
            this.textBoxHost.BorderSize = 1;
            this.textBoxHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxHost.Location = new System.Drawing.Point(27, 49);
            this.textBoxHost.Margin = new System.Windows.Forms.Padding(15, 4, 4, 4);
            this.textBoxHost.Multiline = false;
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxHost.PasswordChar = false;
            this.textBoxHost.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxHost.PlaceholderText = "";
            this.textBoxHost.Size = new System.Drawing.Size(324, 31);
            this.textBoxHost.TabIndex = 0;
            this.textBoxHost.TabStop = false;
            this.textBoxHost.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxHost.Texts = "";
            this.textBoxHost.UnderlinedStyle = false;
            // 
            // labelRemaining
            // 
            this.labelRemaining.AutoSize = true;
            this.labelRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemaining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelRemaining.Location = new System.Drawing.Point(24, 24);
            this.labelRemaining.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.labelRemaining.Name = "labelRemaining";
            this.labelRemaining.Size = new System.Drawing.Size(35, 16);
            this.labelRemaining.TabIndex = 67;
            this.labelRemaining.Text = "Host";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(24, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 68;
            this.label1.Text = "Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsername.BackColor = System.Drawing.Color.White;
            this.textBoxUsername.BorderColor = System.Drawing.Color.Gray;
            this.textBoxUsername.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBoxUsername.BorderRadius = 1;
            this.textBoxUsername.BorderSize = 1;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxUsername.Location = new System.Drawing.Point(27, 124);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(15, 4, 4, 4);
            this.textBoxUsername.Multiline = false;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxUsername.PasswordChar = false;
            this.textBoxUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxUsername.PlaceholderText = "";
            this.textBoxUsername.Size = new System.Drawing.Size(324, 31);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.TabStop = false;
            this.textBoxUsername.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxUsername.Texts = "";
            this.textBoxUsername.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(24, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.BackColor = System.Drawing.Color.White;
            this.textBoxPassword.BorderColor = System.Drawing.Color.Gray;
            this.textBoxPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBoxPassword.BorderRadius = 1;
            this.textBoxPassword.BorderSize = 1;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPassword.Location = new System.Drawing.Point(27, 199);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(15, 4, 4, 4);
            this.textBoxPassword.Multiline = false;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxPassword.PasswordChar = true;
            this.textBoxPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxPassword.PlaceholderText = "";
            this.textBoxPassword.Size = new System.Drawing.Size(324, 31);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.TabStop = false;
            this.textBoxPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxPassword.Texts = "";
            this.textBoxPassword.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(24, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 72;
            this.label3.Text = "Database";
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDatabase.BackColor = System.Drawing.Color.White;
            this.textBoxDatabase.BorderColor = System.Drawing.Color.Gray;
            this.textBoxDatabase.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBoxDatabase.BorderRadius = 1;
            this.textBoxDatabase.BorderSize = 1;
            this.textBoxDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxDatabase.Location = new System.Drawing.Point(27, 274);
            this.textBoxDatabase.Margin = new System.Windows.Forms.Padding(15, 4, 4, 4);
            this.textBoxDatabase.Multiline = false;
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxDatabase.PasswordChar = false;
            this.textBoxDatabase.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxDatabase.PlaceholderText = "";
            this.textBoxDatabase.Size = new System.Drawing.Size(324, 31);
            this.textBoxDatabase.TabIndex = 3;
            this.textBoxDatabase.TabStop = false;
            this.textBoxDatabase.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxDatabase.Texts = "";
            this.textBoxDatabase.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(24, 324);
            this.label4.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 74;
            this.label4.Text = "Authorization Code";
            // 
            // textBoxAuthCode
            // 
            this.textBoxAuthCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAuthCode.BackColor = System.Drawing.Color.White;
            this.textBoxAuthCode.BorderColor = System.Drawing.Color.Gray;
            this.textBoxAuthCode.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBoxAuthCode.BorderRadius = 1;
            this.textBoxAuthCode.BorderSize = 1;
            this.textBoxAuthCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuthCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxAuthCode.Location = new System.Drawing.Point(27, 349);
            this.textBoxAuthCode.Margin = new System.Windows.Forms.Padding(15, 4, 4, 4);
            this.textBoxAuthCode.Multiline = false;
            this.textBoxAuthCode.Name = "textBoxAuthCode";
            this.textBoxAuthCode.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxAuthCode.PasswordChar = true;
            this.textBoxAuthCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxAuthCode.PlaceholderText = "";
            this.textBoxAuthCode.Size = new System.Drawing.Size(324, 31);
            this.textBoxAuthCode.TabIndex = 4;
            this.textBoxAuthCode.TabStop = false;
            this.textBoxAuthCode.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxAuthCode.Texts = "";
            this.textBoxAuthCode.UnderlinedStyle = false;
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
            this.buttonClose.Location = new System.Drawing.Point(251, 15);
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
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(173)))), ((int)(((byte)(106)))));
            this.buttonApply.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(173)))), ((int)(((byte)(106)))));
            this.buttonApply.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(146)))), ((int)(((byte)(91)))));
            this.buttonApply.BorderRadius = 10;
            this.buttonApply.BorderSize = 1;
            this.buttonApply.FlatAppearance.BorderSize = 0;
            this.buttonApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApply.ForeColor = System.Drawing.Color.White;
            this.buttonApply.Location = new System.Drawing.Point(39, 15);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(100, 30);
            this.buttonApply.TabIndex = 5;
            this.buttonApply.Text = "Save";
            this.buttonApply.TextColor = System.Drawing.Color.White;
            this.buttonApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonApply.UseVisualStyleBackColor = false;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonSetup
            // 
            this.buttonSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetup.BackColor = System.Drawing.Color.White;
            this.buttonSetup.BackgroundColor = System.Drawing.Color.White;
            this.buttonSetup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.buttonSetup.BorderRadius = 10;
            this.buttonSetup.BorderSize = 1;
            this.buttonSetup.FlatAppearance.BorderSize = 0;
            this.buttonSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetup.ForeColor = System.Drawing.Color.Black;
            this.buttonSetup.Location = new System.Drawing.Point(145, 15);
            this.buttonSetup.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.buttonSetup.Name = "buttonSetup";
            this.buttonSetup.Size = new System.Drawing.Size(100, 30);
            this.buttonSetup.TabIndex = 6;
            this.buttonSetup.Text = "Setup";
            this.buttonSetup.TextColor = System.Drawing.Color.Black;
            this.buttonSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSetup.UseVisualStyleBackColor = false;
            this.buttonSetup.Click += new System.EventHandler(this.buttonSetup_Click);
            // 
            // formSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(375, 477);
            this.Controls.Add(this.textBoxAuthCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDatabase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRemaining);
            this.Controls.Add(this.textBoxHost);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.formSettings_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerDeploy;
        private ui.CustomTextBox textBoxHost;
        private System.Windows.Forms.Label labelRemaining;
        private System.Windows.Forms.Label label1;
        private ui.CustomTextBox textBoxUsername;
        private System.Windows.Forms.Label label2;
        private ui.CustomTextBox textBoxPassword;
        private System.Windows.Forms.Label label3;
        private ui.CustomTextBox textBoxDatabase;
        private System.Windows.Forms.Label label4;
        private ui.CustomTextBox textBoxAuthCode;
        private ui.CustomButton buttonSetup;
        private ui.CustomButton buttonClose;
        private ui.CustomButton buttonApply;
    }
}