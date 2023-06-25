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
    public partial class formPanelItems : Form
    {
     
        formDashboard FormDashboard;
        formLoading formLoading;
        public Panel content;

        List<string>[] sites;
        List<string>[] items;

        string filterSite;
        string filterStatus;
        string filterSearch;

        int currentPage;
        int totalRow;
        int totalPage;

        string selectedId;

        public formPanelItems(formDashboard formDashboard)
        {
            InitializeComponent();
            this.content = this.panelContent;
            this.FormDashboard = formDashboard;
            this.comboBoxStatus.SelectedIndex = 0;
            this.comboBoxSites.SelectedIndex = 0;

            this.currentPage = 1;
            this.totalPage = 0;
            this.totalRow = 0;
            this.selectedId = "";

            this.paginationControl1.CurrentPage = 1;
        }

        private void addNew_Click(object sender, EventArgs e)
        {
            formAddEditItem formAddEditItem = new formAddEditItem(this);
            formAddEditItem.displayAdd();
            if (formAddEditItem.ShowDialog() == DialogResult.OK)
            {
                this.loadList();
            }
        }

        public void loadList()
        {
            this.filterStatus = this.comboBoxStatus.SelectedIndex <= 0 ? "" : this.comboBoxStatus.SelectedIndex == 1 ? "1" : "0";
            this.filterSearch = this.textBoxSearch.Texts.Trim();

            this.filterSite = "";

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

        private void backgroundWorkerList_DoWork(object sender, DoWorkEventArgs e)
        {
            models.site site = new models.site();
            this.sites = site.getAllActiveSites();

            models.item item = new models.item();
            this.items = item.list(this.filterSite, this.filterStatus, this.filterSearch, this.paginationControl1.CurrentPage);

            int[] paginationData = item.paginationData();

            this.totalRow = paginationData[0];
            this.currentPage = paginationData[1];
            this.totalPage = paginationData[3];
        }

        private void backgroundWorkerList_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int originalSelectedIndex = this.comboBoxSites.SelectedIndex;

            if (originalSelectedIndex > this.sites[0].Count)
            {
                originalSelectedIndex = 0;
            }

            this.comboBoxSites.Items.Clear();
            this.comboBoxSites.Items.Add("All");
            for (int i = 0; i < this.sites[0].Count; i++)
            {
                this.comboBoxSites.Items.Add(this.sites[0][i] + " - " + this.sites[1][i]);
            }

            this.comboBoxSites.SelectedIndex = originalSelectedIndex;

            DataGridViewRow[] rows = new DataGridViewRow[items[0].Count];
            for (int i = 0; i < this.items[0].Count; i++)
            {
                rows[i] = (DataGridViewRow)dataGridViewList.RowTemplate.Clone();
                rows[i].CreateCells(dataGridViewList);

                rows[i].Cells[0].Value = this.items[0][i];
                rows[i].Cells[1].Value = this.items[1][i];
                rows[i].Cells[2].Value = this.items[2][i];
                rows[i].Cells[3].Value = this.items[3][i];
                rows[i].Cells[4].Value = this.items[12][i];


                rows[i].Cells[5].Value = this.items[5][i] == "1" ? "Condition" : "Uncondition";
                if (this.items[5][i] == "1")
                {
                    rows[i].Cells[5].Style.ForeColor = Color.Green;
                }
                else
                {
                    rows[i].Cells[5].Style.ForeColor = Color.Red;
                }

                string inventoryDisply = (float.Parse(this.items[11][i]) + 0).ToString();
                if (this.items[13][i] != "1")
                {
                    inventoryDisply = "No Site(s) Assigned";
                    rows[i].Cells[6].Style.ForeColor = Color.Gray;
                }
                else if (float.Parse(this.items[11][i]) < 1)
                {
                    rows[i].Cells[6].Style.ForeColor = Color.Red;
                }
                else
                {
                    rows[i].Cells[6].Style.ForeColor = Color.Green;
                }

                rows[i].Cells[6].Value = inventoryDisply;
            }

            this.dataGridViewList.Rows.Clear();
            this.dataGridViewList.Rows.AddRange(rows);

            this.paginationControl1.TotalPage = this.totalPage;
            this.paginationControl1.TotalRow = this.totalRow;

            this.formLoading.finish();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.currentPage = 1;
            this.paginationControl1.CurrentPage = 1;
            this.loadList();
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
            if (e.ColumnIndex == 7)
            {
                formAddEditItem formAddEditItem = new formAddEditItem(this);
                formAddEditItem.displayEdit(this.dataGridViewList.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (formAddEditItem.ShowDialog() == DialogResult.OK)
                {
                    this.loadList();
                }
            }

            if (e.ColumnIndex == 8)
            {
                string message = string.Format(
                    "Are you sure do you want to delete this item? \r\n\r\nItem Identification: {0} \r\nName: {1} \r\nDescription: {2}",
                    dataGridViewList.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    dataGridViewList.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    dataGridViewList.Rows[e.RowIndex].Cells[3].Value.ToString()
                );

                if (MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.selectedId = dataGridViewList.Rows[e.RowIndex].Cells[0].Value.ToString();
                    backgroundWorkerDeleteItem.RunWorkerAsync();
                    this.formLoading = new formLoading("Deleting...");
                    this.formLoading.ShowDialog();
                }
            }
        }

        private void backgroundWorkerDeleteItem_DoWork(object sender, DoWorkEventArgs e)
        {
            models.item itemDelete = new models.item();
            itemDelete.delete(this.selectedId);
        }

        private void backgroundWorkerDeleteItem_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.formLoading.Close();
            this.loadList();
        }

        private void formPanelItems_Load(object sender, EventArgs e)
        {

        }

        private void paginationControl1_PageChanged_1(object sender, EventArgs e)
        {
            this.loadList();
        }
    }
}
