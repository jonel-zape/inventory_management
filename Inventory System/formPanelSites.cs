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
    public partial class formPanelSites : Form
    {
        formDashboard FormDashboard;
        public Panel content;
        formLoading formLoading;
        List<string>[] list;
        int selectedSite;
        string inputSearch;

        int rowCount;
        int rowsPerPage;
        int currentPage;
        int maxPage;

        public formPanelSites(formDashboard formDashboard)
        {
            InitializeComponent();
            this.list = new List<string>[9];
            this.list[0] = new List<string>(); // id
            this.list[1] = new List<string>(); // name
            this.list[2] = new List<string>(); // address
            this.list[3] = new List<string>(); // details
            this.list[4] = new List<string>(); // status
            this.list[5] = new List<string>(); // created_by
            this.list[6] = new List<string>(); // date_time_created
            this.list[7] = new List<string>(); // created_by_username
            this.list[8] = new List<string>(); // has_items_assgined

            this.rowCount = 0;
            this.rowsPerPage = 50;
            this.currentPage = 1;
            this.maxPage = 0;

            this.content = this.panelContent;
            this.FormDashboard = formDashboard;
            this.comboBoxStatus.SelectedIndex = 0;
        }

        private void addNew_Click(object sender, EventArgs e)
        {
            formAddEditSite formAddEditSite = new formAddEditSite(this);
            formAddEditSite.displayAdd();

            if (formAddEditSite.ShowDialog() == DialogResult.OK) 
            {
                this.loadList();
            }
        }

        public void loadList()
        {
            this.selectedSite = comboBoxStatus.SelectedIndex;
            this.inputSearch = textBoxSearch.Texts.Trim();

            backgroundWorkerList.RunWorkerAsync();
            this.formLoading = new formLoading("Loading...");
            this.formLoading.ShowDialog();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.paginationControl1.CurrentPage = 1;
            this.loadList();
        }

        private void backgroundWorkerList_DoWork(object sender, DoWorkEventArgs e)
        {
            database database = new database();

            string statusFilter = "";
            string searchFilter = "";
            if (selectedSite > 0)
            {
                statusFilter = "AND S.status = '" + (selectedSite == 1 ? "1" : "0") + "'";
            }

            if (inputSearch != "")
            {
                searchFilter = "AND S.name LIKE '%" + database.escapeString(inputSearch) + "%'";
            }

            string queryCount = string.Format(
               @"SELECT 
                    COUNT(S.id) AS count
                FROM site AS S                
                WHERE S.date_time_deleted IS NULL
                {0}
                {1}",
               statusFilter,
               searchFilter
            );

            database databaseCount = new database();
            var dataCount = databaseCount.getData(queryCount);
            if (dataCount == null)
            {
                return;
            }

            this.rowCount = 0;
            while (dataCount.Read())
            {
                this.rowCount = int.Parse(dataCount["count"].ToString());
            }
            databaseCount.closeConnection();

            int offSet = (this.currentPage * this.rowsPerPage) - this.rowsPerPage;
            double pageCompute = double.Parse(this.rowCount.ToString()) / double.Parse(this.rowsPerPage.ToString());
            this.maxPage = (int)Math.Ceiling(pageCompute);

            string query = string.Format(
                @"SELECT 
                    S.`id`,
                    S.`name`,
                    S.`address`,
                    S.`details`,
                    S.`status`,
                    S.`created_by`,
                    S.`date_time_created`,
                    S.`modified_by`,
                    S.`date_time_modifed`,
                    S.`date_time_deleted`,
                    ROUND(SUM(COALESCE(II.inventory, 0)), 2) AS total_inventory,
                    COALESCE(U.username, '') AS created_by_username,
                    IF (II.inventory IS NOT NULL, 1, 0) AS has_items_assgined
                FROM site AS S
                LEFT JOIN item_site AS II ON II.site_id = S.id
                LEFT JOIN user AS U ON U.id = S.created_by
                WHERE S.date_time_deleted IS NULL
                {0}
                {1}
                GROUP BY S.id
                LIMIT {2}, {3}",
                statusFilter,
                searchFilter,
                offSet.ToString(),
                rowsPerPage.ToString()
            );

            var data = database.getData(query);
            if (data == null)
            {
                return;
            }

            this.list[0].Clear();
            this.list[1].Clear();
            this.list[2].Clear();
            this.list[3].Clear();
            this.list[4].Clear();
            this.list[5].Clear();
            this.list[6].Clear();
            this.list[7].Clear();
            this.list[8].Clear();

            while (data.Read())
            {
                this.list[0].Add(data["id"].ToString());
                this.list[1].Add(data["name"].ToString());
                this.list[2].Add(data["address"].ToString());
                this.list[3].Add(data["details"].ToString());
                this.list[4].Add(data["status"].ToString());
                this.list[5].Add(data["total_inventory"].ToString());
                this.list[6].Add(data["date_time_created"].ToString());
                this.list[7].Add(data["created_by_username"].ToString());
                this.list[8].Add(data["has_items_assgined"].ToString());
            }

            database.closeConnection();
        }

        private void backgroundWorkerList_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.paginationControl1.TotalRow = this.rowCount;
            this.paginationControl1.TotalPage = this.maxPage;

            DataGridViewRow[] rows = new DataGridViewRow[list[0].Count];
            for (int i = 0; i < list[0].Count; i++)
            {
                rows[i] = (DataGridViewRow)dataGridViewList.RowTemplate.Clone();
                rows[i].CreateCells(dataGridViewList);

                rows[i].Cells[0].Value = list[0][i];
                rows[i].Cells[1].Value = list[1][i];
                rows[i].Cells[2].Value = list[2][i];
                rows[i].Cells[3].Value = list[3][i];
                rows[i].Cells[4].Value = list[4][i] == "1" ? "Active" : "Inactive"; 
                rows[i].Cells[5].Value = (float.Parse(list[5][i]) + 0).ToString();

                if (list[4][i] == "1")
                {
                    rows[i].Cells[4].Style.ForeColor = Color.Green;
                }
                else
                {
                    rows[i].Cells[4].Style.ForeColor = Color.Red;
                }

                if (float.Parse(list[5][i]) < 1)
                {
                    rows[i].Cells[5].Style.ForeColor = Color.Red;
                }
                else
                {
                    rows[i].Cells[5].Style.ForeColor = Color.Green;
                }

                if (list[8][i] == "0")
                {
                    rows[i].Cells[5].Value = "No Item(s) Assigned";
                    rows[i].Cells[5].Style.ForeColor = Color.Gray;
                }

                
            }

            this.dataGridViewList.Rows.Clear();
            this.dataGridViewList.Rows.AddRange(rows);

            formLoading.finish();
        }

        private void dataGridViewList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 6)
            {
                string id = dataGridViewList.Rows[e.RowIndex].Cells[0].Value.ToString();
                string name = dataGridViewList.Rows[e.RowIndex].Cells[1].Value.ToString();
                string address = dataGridViewList.Rows[e.RowIndex].Cells[2].Value.ToString();
                string details = dataGridViewList.Rows[e.RowIndex].Cells[3].Value.ToString();
                string status = dataGridViewList.Rows[e.RowIndex].Cells[4].Value.ToString();

                formAddEditSite formAddEditSite = new formAddEditSite(this);
                formAddEditSite.displayEdit(id, name, address, details, status);

                if (formAddEditSite.ShowDialog() == DialogResult.OK)
                {
                    this.loadList();
                }
            }

            if (e.ColumnIndex == 7)
            {
                string message = string.Format(
                    "Are you sure do you want to delete this site? \r\n\r\nID: {0} \r\nName: {1} \r\nAddress: {2} \r\nDetails: {3}",
                    dataGridViewList.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    dataGridViewList.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    dataGridViewList.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    dataGridViewList.Rows[e.RowIndex].Cells[3].Value.ToString()
                );

                if (MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.selectedSite = int.Parse(dataGridViewList.Rows[e.RowIndex].Cells[0].Value.ToString());

                    backgroundWorkerDeleteSite.RunWorkerAsync();
                    this.formLoading = new formLoading("Deleting...");
                    this.formLoading.ShowDialog();
                }
            }
        }

        private void backgroundWorkerDeleteSite_DoWork(object sender, DoWorkEventArgs e)
        {
            database database = new database();
            string query = string.Format(
                "UPDATE`site` SET `modified_by` = '{0}', `date_time_deleted` = NOW() WHERE `id` = '{1}'",
                database.escapeString(Properties.Settings.Default.user_id),
                selectedSite.ToString()
            );

            database.execute(query);
        }

        private void backgroundWorkerDeleteSite_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            formLoading.Close();
            this.loadList();
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.paginationControl1.CurrentPage = 1;
                this.loadList();
            }
        }

        private void textBoxSearch__TextChanged(object sender, EventArgs e)
        {

        }

        private void paginationControl1_PageChanged(object sender, EventArgs e)
        {
            this.loadList();
        }
    }
}
