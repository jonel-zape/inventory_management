
namespace Inventory_System.ui
{
    partial class PaginationControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginationControl));
            this.customButtonPrev = new Inventory_System.ui.CustomButton();
            this.customButtonNext = new Inventory_System.ui.CustomButton();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotalRows = new System.Windows.Forms.Label();
            this.textBoxPage = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTotalPage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customButtonPrev
            // 
            this.customButtonPrev.BackColor = System.Drawing.Color.White;
            this.customButtonPrev.BackgroundColor = System.Drawing.Color.White;
            this.customButtonPrev.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.customButtonPrev.BorderRadius = 10;
            this.customButtonPrev.BorderSize = 1;
            this.customButtonPrev.FlatAppearance.BorderSize = 0;
            this.customButtonPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButtonPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButtonPrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.customButtonPrev.Image = ((System.Drawing.Image)(resources.GetObject("customButtonPrev.Image")));
            this.customButtonPrev.Location = new System.Drawing.Point(0, 0);
            this.customButtonPrev.Name = "customButtonPrev";
            this.customButtonPrev.Size = new System.Drawing.Size(44, 30);
            this.customButtonPrev.TabIndex = 0;
            this.customButtonPrev.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.customButtonPrev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButtonPrev.UseVisualStyleBackColor = false;
            this.customButtonPrev.Click += new System.EventHandler(this.customButtonPrev_Click);
            // 
            // customButtonNext
            // 
            this.customButtonNext.BackColor = System.Drawing.Color.White;
            this.customButtonNext.BackgroundColor = System.Drawing.Color.White;
            this.customButtonNext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.customButtonNext.BorderRadius = 10;
            this.customButtonNext.BorderSize = 1;
            this.customButtonNext.FlatAppearance.BorderSize = 0;
            this.customButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButtonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButtonNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.customButtonNext.Image = ((System.Drawing.Image)(resources.GetObject("customButtonNext.Image")));
            this.customButtonNext.Location = new System.Drawing.Point(143, 0);
            this.customButtonNext.Name = "customButtonNext";
            this.customButtonNext.Size = new System.Drawing.Size(44, 30);
            this.customButtonNext.TabIndex = 2;
            this.customButtonNext.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.customButtonNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButtonNext.UseVisualStyleBackColor = false;
            this.customButtonNext.Click += new System.EventHandler(this.customButtonNext_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(99, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 22);
            this.label4.TabIndex = 77;
            this.label4.Text = "/";
            // 
            // labelTotalRows
            // 
            this.labelTotalRows.AutoSize = true;
            this.labelTotalRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalRows.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTotalRows.Location = new System.Drawing.Point(-3, 35);
            this.labelTotalRows.Name = "labelTotalRows";
            this.labelTotalRows.Size = new System.Drawing.Size(124, 15);
            this.labelTotalRows.TabIndex = 78;
            this.labelTotalRows.Text = "Total Records: 99999";
            // 
            // textBoxPage
            // 
            this.textBoxPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPage.Location = new System.Drawing.Point(5, 7);
            this.textBoxPage.Name = "textBoxPage";
            this.textBoxPage.Size = new System.Drawing.Size(31, 15);
            this.textBoxPage.TabIndex = 1;
            this.textBoxPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPage_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBoxPage);
            this.panel1.Location = new System.Drawing.Point(50, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(41, 30);
            this.panel1.TabIndex = 80;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(1, 29);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(39, 1);
            this.panel5.TabIndex = 85;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(39, 1);
            this.panel4.TabIndex = 84;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(40, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 30);
            this.panel3.TabIndex = 83;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 30);
            this.panel2.TabIndex = 82;
            // 
            // labelTotalPage
            // 
            this.labelTotalPage.AutoSize = true;
            this.labelTotalPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTotalPage.Location = new System.Drawing.Point(112, 7);
            this.labelTotalPage.Name = "labelTotalPage";
            this.labelTotalPage.Size = new System.Drawing.Size(28, 15);
            this.labelTotalPage.TabIndex = 81;
            this.labelTotalPage.Text = "999";
            // 
            // PaginationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelTotalPage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTotalRows);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customButtonNext);
            this.Controls.Add(this.customButtonPrev);
            this.Name = "PaginationControl";
            this.Size = new System.Drawing.Size(187, 54);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton customButtonPrev;
        private CustomButton customButtonNext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotalRows;
        private System.Windows.Forms.TextBox textBoxPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTotalPage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}
