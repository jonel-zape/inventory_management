
namespace Inventory_System.ui
{
    partial class CustomWidget
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContainer = new Inventory_System.ui.CustomPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.countLabel = new System.Windows.Forms.TextBox();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(165)))), ((int)(((byte)(252)))));
            this.panelContainer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(165)))), ((int)(((byte)(252)))));
            this.panelContainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelContainer.BorderRadius = 10;
            this.panelContainer.BorderSize = 1;
            this.panelContainer.Controls.Add(this.titleLabel);
            this.panelContainer.Controls.Add(this.pictureBox1);
            this.panelContainer.Controls.Add(this.countLabel);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.ForeColor = System.Drawing.Color.Black;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(250, 100);
            this.panelContainer.TabIndex = 80;
            this.panelContainer.TextColor = System.Drawing.Color.Black;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(32, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(88, 16);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Widget Label";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventory_System.Properties.Resources.icons8_calendar_16_white;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // countLabel
            // 
            this.countLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.countLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(165)))), ((int)(((byte)(252)))));
            this.countLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countLabel.CausesValidation = false;
            this.countLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.ForeColor = System.Drawing.Color.White;
            this.countLabel.Location = new System.Drawing.Point(5, 32);
            this.countLabel.Name = "countLabel";
            this.countLabel.ReadOnly = true;
            this.countLabel.Size = new System.Drawing.Size(240, 42);
            this.countLabel.TabIndex = 3;
            this.countLabel.TabStop = false;
            this.countLabel.Text = "-";
            this.countLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CustomWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Name = "CustomWidget";
            this.Size = new System.Drawing.Size(250, 100);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel panelContainer;
        private System.Windows.Forms.TextBox countLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titleLabel;
    }
}
