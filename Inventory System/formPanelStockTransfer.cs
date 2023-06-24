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
    public partial class formPanelStockTransfer : Form
    {
        formDashboard FormDashboard;
        public Panel content;
        formLoading formLoading;

        List<string>[] sites;
        List<string>[] transactions;

        string filterSiteFrom;
        string filterSiteTo;
        string filterDateFrom;
        string filterDateTo;
        string filterSearch;

        int currentPage;
        int totalRow;
        int totalPage;
        
        public formPanelStockTransfer(formDashboard formDashboard)
        {
            InitializeComponent();
            this.content = this.panelContent;
            this.FormDashboard = formDashboard;

            this.comboBoxSiteFrom.SelectedIndex = 0;
            this.comboBoxSiteTo.SelectedIndex = 0;
            this.currentPage = 1;
            this.totalPage = 0;
            this.totalRow = 0;
            this.paginationControl1.CurrentPage = 1;
        }

        public void loadList()
        {
            this.filterSearch = this.textBoxSearch.Texts.Trim();

            this.filterDateFrom = string.Format(
                "{0}-{1}-{2}",
                this.dateTimePickerFrom.Value.Year.ToString(),
                this.dateTimePickerFrom.Value.Month.ToString(),
                this.dateTimePickerFrom.Value.Day.ToString()
            );

            this.filterDateTo = string.Format(
                "{0}-{1}-{2}",
                this.dateTimePickerTo.Value.Year.ToString(),
                this.dateTimePickerTo.Value.Month.ToString(),
                this.dateTimePickerTo.Value.Day.ToString()
            );

            if (this.comboBoxSiteFrom.SelectedIndex <= 0)
            {
                this.filterSiteFrom = "";
            }
            else
            {
                if (this.comboBoxSiteFrom.SelectedIndex - 1 < this.sites[0].Count)
                {
                    this.filterSiteFrom = this.sites[0][this.comboBoxSiteFrom.SelectedIndex - 1];
                }
            }

            if (this.comboBoxSiteTo.SelectedIndex <= 0)
            {
                this.filterSiteTo = "";
            }
            else
            {
                if (this.comboBoxSiteTo.SelectedIndex - 1 < this.sites[0].Count)
                {
                    this.filterSiteTo = this.sites[0][this.comboBoxSiteTo.SelectedIndex - 1];
                }
            }

            this.backgroundWorkerList.RunWorkerAsync();
            this.formLoading = new formLoading("Loading...");
            this.formLoading.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addNew_Click(object sender, EventArgs e)
        {
            formNewStockTransferTransaction formNewStockTransferTransaction = new formNewStockTransferTransaction(this);
            formNewStockTransferTransaction.displayNew();
            if (formNewStockTransferTransaction.ShowDialog() == DialogResult.OK)
            {
                this.loadList();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.paginationControl1.CurrentPage = 1;
            this.currentPage = 1;

            this.loadList();
        }

        private void backgroundWorkerList_DoWork(object sender, DoWorkEventArgs e)
        {
            models.site site = new models.site();
            this.sites = site.getAllActiveSites();

            models.inventoryTransfer inventoryTransfer = new models.inventoryTransfer();
            this.transactions = inventoryTransfer.list(this.filterSiteFrom, this.filterSiteTo, this.filterDateFrom, this.filterDateTo, this.filterSearch, this.paginationControl1.CurrentPage);

            this.totalRow = inventoryTransfer.getRowCount();
            this.currentPage = inventoryTransfer.getCurrentPage();
            this.totalPage = inventoryTransfer.getMaxPage();
        }

        private void backgroundWorkerList_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int originalSelectedIndexFrom = this.comboBoxSiteFrom.SelectedIndex;
            if (originalSelectedIndexFrom > this.sites[0].Count)
            {
                originalSelectedIndexFrom = 0;
            }

            int originalSelectedIndexTo = this.comboBoxSiteTo.SelectedIndex;
            if (originalSelectedIndexTo > this.sites[0].Count)
            {
                originalSelectedIndexTo = 0;
            }

            this.comboBoxSiteFrom.Items.Clear();
            this.comboBoxSiteFrom.Items.Add("All Sites");
            this.comboBoxSiteTo.Items.Clear();
            this.comboBoxSiteTo.Items.Add("All Sites");
            for (int i = 0; i < this.sites[0].Count; i++)
            {
                this.comboBoxSiteFrom.Items.Add(this.sites[0][i] + " - " + this.sites[1][i]);
                this.comboBoxSiteTo.Items.Add(this.sites[0][i] + " - " + this.sites[1][i]);
                
            }
            this.comboBoxSiteFrom.SelectedIndex = originalSelectedIndexFrom;
            this.comboBoxSiteTo.SelectedIndex = originalSelectedIndexTo;

            DataGridViewRow[] rows = new DataGridViewRow[this.transactions[0].Count];
            for (int i = 0; i < this.transactions[0].Count; i++)
            {
                rows[i] = (DataGridViewRow)dataGridViewList.RowTemplate.Clone();
                rows[i].CreateCells(dataGridViewList);

                rows[i].Cells[0].Value = this.transactions[0][i];
                rows[i].Cells[1].Value = this.transactions[4][i];
                rows[i].Cells[2].Value = this.transactions[5][i];
                rows[i].Cells[3].Value = this.transactions[6][i];
                rows[i].Cells[4].Value = this.transactions[3][i];
                rows[i].Cells[5].Value = this.transactions[2][i];
            }

            this.dataGridViewList.Rows.Clear();
            this.dataGridViewList.Rows.AddRange(rows);

            this.paginationControl1.TotalPage = this.totalPage;
            this.paginationControl1.TotalRow = this.totalRow;

            this.formLoading.finish();
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.currentPage = 1;
                this.paginationControl1.CurrentPage = 1;

                this.loadList();
            }
        }

        private void dataGridViewList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 6)
            {
                string id = this.dataGridViewList.Rows[e.RowIndex].Cells[0].Value.ToString();
                formNewStockTransferTransaction formNewStockTransferTransaction = new formNewStockTransferTransaction(this);
                formNewStockTransferTransaction.displayView(id);
                if (formNewStockTransferTransaction.ShowDialog() == DialogResult.OK)
                {
                    this.loadList();
                }
            }
        }

        private void paginationControl1_PageChanged(object sender, EventArgs e)
        {
            this.loadList();
        }
    }
}
