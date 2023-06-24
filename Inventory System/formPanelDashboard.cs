using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class formPanelDashboard : Form
    {
        formDashboard FormDashboard;
        public Panel content;
        formLoading formLoading;
        string activeSiteCount;
        string outOfStockItemsCount;
        string totalInventoryCount;

        public formPanelDashboard(formDashboard formDashboard)
        {
            InitializeComponent();
            this.content = this.panelContent;
            this.FormDashboard = formDashboard;
        }

        public void loadDetails()
        {
            this.backgroundWorkerLoad.RunWorkerAsync();
            this.formLoading = new formLoading("Loading...");
            this.formLoading.ShowDialog();
        }

        private void backgroundWorkerLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            models.item item = new models.item();
            this.outOfStockItemsCount = item.getOutOfStockItemsCount();
            this.totalInventoryCount = item.getAllTotalInventory();

            models.site site = new models.site();
            this.activeSiteCount = site.getActiveSitesCount();
        }

        private void backgroundWorkerLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.customWidgetActiveSites.WidgetValue = this.activeSiteCount;
            this.customWidgetOutOfStocks.WidgetValue = this.outOfStockItemsCount;
            this.customWidgetAvailableStocks.WidgetValue = this.totalInventoryCount;
            formLoading.finish();
        }
    }
}
