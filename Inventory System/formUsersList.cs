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
    public partial class formUsersList : Form
    {
        formLoading formLoading;
        List<string>[] items;

        string filterStatus;
        string filterSearch;

        int currentPage;
        int totalRow;
        int totalPage;

        string selectedId;

        public formUsersList()
        {
            InitializeComponent();

            this.comboBoxStatus.SelectedIndex = 0;
            this.currentPage = 1;
            this.totalPage = 0;
            this.totalRow = 0;
        }

        public void loadList()
        {
            this.filterSearch = this.textBoxSearch.Text.Trim();
            this.filterStatus = this.comboBoxStatus.SelectedIndex == 0 ? "" : this.comboBoxStatus.SelectedIndex == 1 ? "1" : "0";

            this.backgroundWorkerLoad.RunWorkerAsync();
            this.formLoading = new formLoading("Loading...");
            this.formLoading.ShowDialog();
        }

        private void addNew_Click(object sender, EventArgs e)
        {
            formAddEditUser formAddEditUser = new formAddEditUser();
            formAddEditUser.displayNew();
            if (formAddEditUser.ShowDialog() == DialogResult.OK)
            {
                this.loadList();
            }
        }

        private void backgroundWorkerLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            models.user user = new models.user();
            this.items = user.list(this.filterStatus, this.filterSearch, this.currentPage);

            this.totalRow = user.getRowCount();
            this.currentPage = user.getCurrentPage();
            this.totalPage = user.getMaxPage();
        }

        private void backgroundWorkerLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DataGridViewRow[] rows = new DataGridViewRow[this.items[0].Count];
            for (int i = 0; i < this.items[0].Count; i++)
            {
                rows[i] = (DataGridViewRow)dataGridViewList.RowTemplate.Clone();
                rows[i].CreateCells(dataGridViewList);

                rows[i].Cells[0].Value = this.items[0][i];
                rows[i].Cells[1].Value = this.items[1][i];
                rows[i].Cells[2].Value = this.items[2][i];
                rows[i].Cells[3].Value = this.items[3][i];
                rows[i].Cells[4].Value = this.items[4][i] == "1" ? "Enabled" : "Disabled";

                if (this.items[4][i] == "1")
                {
                    rows[i].Cells[4].Style.ForeColor = Color.Green;
                }
                else
                {
                    rows[i].Cells[4].Style.ForeColor = Color.Red;
                }
            }

            this.dataGridViewList.Rows.Clear();
            this.dataGridViewList.Rows.AddRange(rows);

            this.labelListCount.Text = "Total: " + this.totalRow.ToString();
            this.labelPaginateTotalPage.Text = "of " + this.totalPage;

            this.formLoading.finish();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.textBoxPaginatePage.Text = "1";
            this.currentPage = 1;

            this.loadList();
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

        private void formUsersList_Load(object sender, EventArgs e)
        {
            this.loadList();
        }

        private void dataGridViewList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string id = this.dataGridViewList.Rows[e.RowIndex].Cells[0].Value.ToString();

            if (e.ColumnIndex == 5)
            {
                formAddEditUser formAddEditUser = new formAddEditUser();                
                formAddEditUser.displayView(id);
                if (formAddEditUser.ShowDialog() == DialogResult.OK)
                {
                    this.loadList();
                }
            }

            if (e.ColumnIndex == 6)
            {
                if (MessageBox.Show("Are you sure do you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.selectedId = id;
                    this.backgroundWorkerDelete.RunWorkerAsync();
                    this.formLoading = new formLoading("Deleting...");
                    this.formLoading.ShowDialog();
                }
            }
        }

        private void backgroundWorkerDelete_DoWork(object sender, DoWorkEventArgs e)
        {
            models.user user = new models.user();
            user.deleteUser(this.selectedId);
        }

        private void backgroundWorkerDelete_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.formLoading.Close();
            this.loadList();
        }
    }
}
