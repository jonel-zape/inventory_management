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
    public partial class formItemPicker : Form
    {
        public string itemId;
        public string itemBarcode;
        public string itemName;
        public string itemDescription;
        public string itemPrice;

        formLoading formLoading;

        List<string>[] sites;
        List<string>[] items;

        string filterSite;
        string filterStatus;
        string filterSearch;

        int currentPage;
        int totalRow;
        int totalPage;

        string selectedId;
        string selectedSiteId;

        public formItemPicker(string siteId = "")
        {
            InitializeComponent();
            this.itemId = "";
            this.itemBarcode = "";
            this.itemName = "";
            this.itemDescription = "";
            this.itemPrice = "";

            this.comboBoxStatus.SelectedIndex = 1;
            this.comboBoxSites.SelectedIndex = 0;

            this.currentPage = 1;
            this.totalPage = 0;
            this.totalRow = 0;
            this.selectedId = "";

            this.paginationControl1.CurrentPage = 1;

            this.selectedSiteId = siteId;
        }

        /// <summary>
        /// Get Chosen Item
        /// </summary>
        /// <returns>
        /// string[]:  [0] - id; [1] - barcode; [2] - name; [3] - description; [4] - price; [5] - status; [6] - created_by; [7] - date_time_created; [8] - modified_by; [9] - date_time_modified; [10] - date_time_deleted; [11] - inventory; [12] - price_display; [13] - is_assigned;
        /// </returns>
        public string[] getSelectedItem()
        {
            string[] item = new string[14];
            int selectedIndex = int.Parse(this.dataGridViewList.Rows[this.dataGridViewList.CurrentCell.RowIndex].Cells[7].Value.ToString());

            item[0] = this.items[0][selectedIndex]; // id
            item[1] = this.items[1][selectedIndex]; // barcode
            item[2] = this.items[2][selectedIndex]; // name
            item[3] = this.items[3][selectedIndex]; // description
            item[4] = this.items[4][selectedIndex]; // price
            item[5] = this.items[5][selectedIndex]; // status
            item[6] = this.items[6][selectedIndex]; // created_by
            item[7] = this.items[7][selectedIndex]; // date_time_created
            item[8] = this.items[8][selectedIndex]; // modified_by
            item[9] = this.items[9][selectedIndex]; // date_time_modified
            item[10] = this.items[10][selectedIndex]; // date_time_deleted
            item[11] = this.items[11][selectedIndex]; // inventory
            item[12] = this.items[12][selectedIndex]; // price_display
            item[13] = this.items[13][selectedIndex]; // is_assigned

            return item;
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

            if (this.selectedSiteId.Trim() != "")
            {
                this.filterSite = this.selectedSiteId;
            }

            this.backgroundWorkerList.RunWorkerAsync();
            this.formLoading = new formLoading("Loading...");
            this.formLoading.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewList.Rows.Count < 1)
            {
                MessageBox.Show("Please select an item", "Note", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedIndex = this.dataGridViewList.CurrentCell.RowIndex;
            if (selectedIndex < 0 || selectedIndex > this.items[0].Count - 1)
            {
                MessageBox.Show("Please select an item", "Note", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.currentPage = 1;
            this.paginationControl1.CurrentPage = 1;
            this.loadList();
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

            if (originalSelectedIndex > this.sites[0].Count - 1)
            {
                originalSelectedIndex = 0;
            }

            this.comboBoxSites.Items.Clear();
            this.comboBoxSites.Items.Add("All Sites");
            bool enableSitePick = true;
            for (int i = 0; i < this.sites[0].Count; i++)
            {
                if (this.selectedSiteId == this.sites[0][i])
                {
                    originalSelectedIndex = i;
                    enableSitePick = false;
                }

                this.comboBoxSites.Items.Add(this.sites[0][i] + " - " + this.sites[1][i]);
            }

            if (this.selectedSiteId.Trim() != "" && enableSitePick == true)
            {
                MessageBox.Show("Invalid site selected", "Note", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.formLoading.finish();
                this.Close();
                return;
            }

            this.comboBoxSites.SelectedIndex = originalSelectedIndex + 1;
            this.comboBoxSites.Enabled = enableSitePick;

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
                rows[i].Cells[7].Value = i.ToString();
            }

            this.dataGridViewList.Rows.Clear();
            this.dataGridViewList.Rows.AddRange(rows);

            this.paginationControl1.TotalPage = this.totalPage;
            this.paginationControl1.TotalRow = this.totalRow;

            this.formLoading.finish();
        }

        private void formItemPicker_Load(object sender, EventArgs e)
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

        private void dataGridViewList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                this.buttonSelect.PerformClick();
            }
        }

        private void paginationControl1_PageChanged(object sender, EventArgs e)
        {
            this.loadList();
        }
    }
}
