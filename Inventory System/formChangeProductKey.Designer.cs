
namespace Inventory_System
{
    partial class formChangeProductKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formChangeProductKey));
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new Inventory_System.ui.CustomButton();
            this.buttonApply = new Inventory_System.ui.CustomButton();
            this.backgroundWorkerValidate = new System.ComponentModel.BackgroundWorker();
            this.labelAppliedKey = new System.Windows.Forms.Label();
            this.labelRemaining = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKey = new Inventory_System.ui.CustomTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(120)))), ((int)(((byte)(181)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(413, 5);
            this.panel8.TabIndex = 49;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonApply);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 60);
            this.panel1.TabIndex = 55;
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
            this.buttonClose.Location = new System.Drawing.Point(289, 15);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 3, 15, 15);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 30);
            this.buttonClose.TabIndex = 3;
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
            this.buttonApply.Location = new System.Drawing.Point(183, 15);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(100, 30);
            this.buttonApply.TabIndex = 2;
            this.buttonApply.Text = "Save";
            this.buttonApply.TextColor = System.Drawing.Color.White;
            this.buttonApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonApply.UseVisualStyleBackColor = false;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // backgroundWorkerValidate
            // 
            this.backgroundWorkerValidate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerValidate_DoWork);
            this.backgroundWorkerValidate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerValidate_RunWorkerCompleted);
            // 
            // labelAppliedKey
            // 
            this.labelAppliedKey.AutoSize = true;
            this.labelAppliedKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppliedKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelAppliedKey.Location = new System.Drawing.Point(24, 24);
            this.labelAppliedKey.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.labelAppliedKey.Name = "labelAppliedKey";
            this.labelAppliedKey.Size = new System.Drawing.Size(206, 16);
            this.labelAppliedKey.TabIndex = 62;
            this.labelAppliedKey.Text = "Applied Key: XLKJSDIERLIE******";
            // 
            // labelRemaining
            // 
            this.labelRemaining.AutoSize = true;
            this.labelRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemaining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelRemaining.Location = new System.Drawing.Point(24, 60);
            this.labelRemaining.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.labelRemaining.Name = "labelRemaining";
            this.labelRemaining.Size = new System.Drawing.Size(144, 16);
            this.labelRemaining.TabIndex = 63;
            this.labelRemaining.Text = "Key Expires In 0 Day(s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(24, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 15, 5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "Apply New Key:";
            // 
            // textBoxKey
            // 
            this.textBoxKey.BackColor = System.Drawing.Color.White;
            this.textBoxKey.BorderColor = System.Drawing.Color.Gray;
            this.textBoxKey.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBoxKey.BorderRadius = 1;
            this.textBoxKey.BorderSize = 1;
            this.textBoxKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxKey.Location = new System.Drawing.Point(24, 121);
            this.textBoxKey.Margin = new System.Windows.Forms.Padding(15, 4, 4, 4);
            this.textBoxKey.Multiline = false;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxKey.PasswordChar = false;
            this.textBoxKey.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxKey.PlaceholderText = "";
            this.textBoxKey.Size = new System.Drawing.Size(365, 31);
            this.textBoxKey.TabIndex = 1;
            this.textBoxKey.TabStop = false;
            this.textBoxKey.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxKey.Texts = "";
            this.textBoxKey.UnderlinedStyle = false;
            // 
            // formChangeProductKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(413, 234);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRemaining);
            this.Controls.Add(this.labelAppliedKey);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formChangeProductKey";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Activation Key";
            this.Load += new System.EventHandler(this.formChangeProductKey_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerValidate;
        private System.Windows.Forms.Label labelAppliedKey;
        private System.Windows.Forms.Label labelRemaining;
        private System.Windows.Forms.Label label1;
        private ui.CustomTextBox textBoxKey;
        private ui.CustomButton buttonClose;
        private ui.CustomButton buttonApply;
    }
}