
namespace Inventory_System
{
    partial class formLoading
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
            this.components = new System.ComponentModel.Container();
            this.displayText = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.customPanel1 = new Inventory_System.ui.CustomPanel();
            this.loadingCell = new Inventory_System.ui.CustomPanel();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayText
            // 
            this.displayText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.displayText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayText.ForeColor = System.Drawing.Color.White;
            this.displayText.Location = new System.Drawing.Point(0, 28);
            this.displayText.Multiline = true;
            this.displayText.Name = "displayText";
            this.displayText.ReadOnly = true;
            this.displayText.Size = new System.Drawing.Size(282, 61);
            this.displayText.TabIndex = 2;
            this.displayText.TabStop = false;
            this.displayText.Text = "Loading...";
            this.displayText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 400;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.customPanel1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.customPanel1.BorderColor = System.Drawing.SystemColors.Control;
            this.customPanel1.BorderRadius = 10;
            this.customPanel1.BorderSize = 1;
            this.customPanel1.Controls.Add(this.loadingCell);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.Location = new System.Drawing.Point(12, 95);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(258, 15);
            this.customPanel1.TabIndex = 73;
            this.customPanel1.TextColor = System.Drawing.Color.Black;
            // 
            // loadingCell
            // 
            this.loadingCell.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadingCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(165)))), ((int)(((byte)(252)))));
            this.loadingCell.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(165)))), ((int)(((byte)(252)))));
            this.loadingCell.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.loadingCell.BorderRadius = 10;
            this.loadingCell.BorderSize = 1;
            this.loadingCell.ForeColor = System.Drawing.Color.Black;
            this.loadingCell.Location = new System.Drawing.Point(1, 1);
            this.loadingCell.Name = "loadingCell";
            this.loadingCell.Size = new System.Drawing.Size(70, 13);
            this.loadingCell.TabIndex = 74;
            this.loadingCell.TextColor = System.Drawing.Color.Black;
            // 
            // formLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(282, 122);
            this.ControlBox = false;
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.displayText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formLoading";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "formLoading";
            this.customPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox displayText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private ui.CustomPanel customPanel1;
        private ui.CustomPanel loadingCell;
    }
}