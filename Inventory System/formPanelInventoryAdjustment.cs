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
    public partial class formPanelInventoryAdjustment : Form
    {
        formDashboard FormDashboard;
        public Panel content;

        formLoading formLoading;

        List<string>[] sites;
        List<string>[] transactions;

        string filterSite;
        string filterDateFrom;
        string filterDateTo;
        string filterSearch;

        int currentPage;
        int totalRow;
        int totalPage;

        public formPanelInventoryAdjustment(formDashboard formDashboard)
        {
            InitializeComponent();
            this.content = this.panelContent;
            this.FormDashboard = formDashboard;

            this.comboBoxSites.SelectedIndex = 0;
            this.currentPage = 1;
            this.totalPage = 0;
            this.totalRow = 0;
        }

        public void loadList()
        {
            this.filterSearch = this.textBoxSearch.Text.Trim();
            this.filterSite = "";

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

            if (this.comboBoxSites.SelectedIndex <= 0)
            {
                this.filterSite = "";
            }
            else
            {
                if (this.comboBoxSites.SelectedIndex - 1 < this.sites[0].Count)
                {
                    this.filterSite = this.sites[0][this.comboBoxSites.SelectedIndex - 1];
                }
            }

            this.backgroundWorkerList.RunWorkerAsync();
            this.formLoading = new formLoading("Loading...");
            this.formLoading.ShowDialog();
        }


        private void addNew_Click(object sender, EventArgs e)
        {
            formNewInventoryAdjustment formNewInventoryAdjustment = new formNewInventoryAdjustment(this);
            formNewInventoryAdjustment.displayNew();
            if (formNewInventoryAdjustment.ShowDialog() == DialogResult.OK)
            {
                this.loadList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBoxPaginatePage.Text = "1";
            this.currentPage = 1;

            this.loadList();
        }

        private void buttonPaginateBack_Click(object sender, EventArgs e)
        {
            this.currentPage--;
            if (this.currentPage <= 0)
            {
                this.currentPage = 1;
                return;
            }
            this.textBoxPaginatePage.Text = this.currentPage.ToString();
            this.loadList();
        }

        private void buttonPaginateNext_Click(object sender, EventArgs e)
        {
            this.currentPage++;
            if (this.currentPage > this.totalPage)
            {
                this.currentPage = this.totalPage;
                return;
            }
            this.textBoxPaginatePage.Text = this.currentPage.ToString();
            this.loadList();
        }

        private void backgroundWorkerList_DoWork(object sender, DoWorkEventArgs e)
        {
            models.site site = new models.site();
            this.sites = site.getAllActiveSites();

            models.inventoryAdjustment inventoryAdjustment = new models.inventoryAdjustment();

            this.transactions = inventoryAdjustment.list(this.filterSite, this.filterDateFrom, this.filterDateTo, this.filterSearch, this.currentPage);

            this.totalRow = inventoryAdjustment.getRowCount();
            this.currentPage = inventoryAdjustment.getCurrentPage();
            this.totalPage = inventoryAdjustment.getMaxPage();
        }

        private void backgroundWorkerList_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int originalSelectedIndex = this.comboBoxSites.SelectedIndex;

            if (originalSelectedIndex > this.sites[0].Count)
            {
                originalSelectedIndex = 0;
            }

            this.comboBoxSites.Items.Clear();
            this.comboBoxSites.Items.Add("All Sites");
            for (int i = 0; i < this.sites[0].Count; i++)
            {
                this.comboBoxSites.Items.Add(this.sites[0][i] + " - " + this.sites[1][i]);
            }

            this.comboBoxSites.SelectedIndex = originalSelectedIndex;

            DataGridViewRow[] rows = new DataGridViewRow[this.transactions[0].Count];
            for (int i = 0; i < this.transactions[0].Count; i++)
            {
                rows[i] = (DataGridViewRow)dataGridViewList.RowTemplate.Clone();
                rows[i].CreateCells(dataGridViewList);

                rows[i].Cells[0].Value = this.transactions[0][i];
                rows[i].Cells[1].Value = this.transactions[4][i];
                rows[i].Cells[2].Value = this.transactions[5][i];
                rows[i].Cells[3].Value = this.transactions[3][i];
                rows[i].Cells[4].Value = this.transactions[2][i];
            }

            this.dataGridViewList.Rows.Clear();
            this.dataGridViewList.Rows.AddRange(rows);

            this.labelListCount.Text = "Total: " + this.totalRow.ToString();
            this.labelPaginateTotalPage.Text = "of " + this.totalPage;

            this.formLoading.finish();
        }

        private void textBoxPaginatePage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool isNumeric = int.TryParse(this.textBoxPaginatePage.Text, out this.currentPage);
                if (isNumeric)
                {
                    if (this.currentPage <= 0)
                    {
                        this.currentPage = 1;
                    }
                    if (this.currentPage > this.totalPage)
                    {
                        this.currentPage = this.totalPage;
                    }
                    this.textBoxPaginatePage.Text = this.currentPage.ToString();
                    this.loadList();
                }
            }
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.textBoxPaginatePage.Text = "1";
                this.currentPage = 1;

                this.loadList();
            }
        }

        private void dataGridViewList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 5)
            {
                string id = this.dataGridViewList.Rows[e.RowIndex].Cells[0].Value.ToString();
                formNewInventoryAdjustment formNewInventoryAdjustment = new formNewInventoryAdjustment(this);
                formNewInventoryAdjustment.displayView(id);
                if (formNewInventoryAdjustment.ShowDialog() == DialogResult.OK)
                {
                    this.loadList();
                }
            }
        }
    }
}
