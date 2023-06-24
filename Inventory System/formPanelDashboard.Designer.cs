
namespace Inventory_System
{
    partial class formPanelDashboard
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.customWidgetAvailableStocks = new Inventory_System.ui.CustomWidget();
            this.customWidgetOutOfStocks = new Inventory_System.ui.CustomWidget();
            this.customWidgetActiveSites = new Inventory_System.ui.CustomWidget();
            this.backgroundWorkerLoad = new System.ComponentModel.BackgroundWorker();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.BackColor = System.Drawing.SystemColors.Control;
            this.panelContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContent.Controls.Add(this.customWidgetAvailableStocks);
            this.panelContent.Controls.Add(this.customWidgetOutOfStocks);
            this.panelContent.Controls.Add(this.customWidgetActiveSites);
            this.panelContent.Location = new System.Drawing.Point(12, 12);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1133, 615);
            this.panelContent.TabIndex = 0;
            // 
            // customWidgetAvailableStocks
            // 
            this.customWidgetAvailableStocks.Location = new System.Drawing.Point(271, 15);
            this.customWidgetAvailableStocks.Name = "customWidgetAvailableStocks";
            this.customWidgetAvailableStocks.Size = new System.Drawing.Size(250, 100);
            this.customWidgetAvailableStocks.TabIndex = 7;
            this.customWidgetAvailableStocks.WidgetColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(173)))), ((int)(((byte)(106)))));
            this.customWidgetAvailableStocks.WidgetIcon = global::Inventory_System.Properties.Resources.icons8_product_16_white;
            this.customWidgetAvailableStocks.WidgetLabel = "Available Stocks";
            this.customWidgetAvailableStocks.WidgetValue = "0";
            // 
            // customWidgetOutOfStocks
            // 
            this.customWidgetOutOfStocks.Location = new System.Drawing.Point(527, 15);
            this.customWidgetOutOfStocks.Name = "customWidgetOutOfStocks";
            this.customWidgetOutOfStocks.Size = new System.Drawing.Size(250, 100);
            this.customWidgetOutOfStocks.TabIndex = 6;
            this.customWidgetOutOfStocks.WidgetColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(73)))));
            this.customWidgetOutOfStocks.WidgetIcon = global::Inventory_System.Properties.Resources.icons8_product_16_white;
            this.customWidgetOutOfStocks.WidgetLabel = "Out of Stocks";
            this.customWidgetOutOfStocks.WidgetValue = "0";
            // 
            // customWidgetActiveSites
            // 
            this.customWidgetActiveSites.Location = new System.Drawing.Point(15, 15);
            this.customWidgetActiveSites.Margin = new System.Windows.Forms.Padding(15, 15, 3, 3);
            this.customWidgetActiveSites.Name = "customWidgetActiveSites";
            this.customWidgetActiveSites.Size = new System.Drawing.Size(250, 100);
            this.customWidgetActiveSites.TabIndex = 5;
            this.customWidgetActiveSites.WidgetColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(165)))), ((int)(((byte)(252)))));
            this.customWidgetActiveSites.WidgetIcon = global::Inventory_System.Properties.Resources.icons8_city_buildings_16_white;
            this.customWidgetActiveSites.WidgetLabel = "Active Sites";
            this.customWidgetActiveSites.WidgetValue = "0";
            // 
            // backgroundWorkerLoad
            // 
            this.backgroundWorkerLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerLoad_DoWork);
            this.backgroundWorkerLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerLoad_RunWorkerCompleted);
            // 
            // formPanelDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 639);
            this.Controls.Add(this.panelContent);
            this.Name = "formPanelDashboard";
            this.Text = "formPanelDashboard";
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLoad;
        private ui.CustomWidget customWidgetActiveSites;
        private ui.CustomWidget customWidgetOutOfStocks;
        private ui.CustomWidget customWidgetAvailableStocks;
    }
}