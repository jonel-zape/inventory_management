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
    public partial class formNewInventoryAdjustment : Form
    {
        formPanelInventoryAdjustment FormPanelInventoryAdjustment;
        formLoading formLoading;
        List<string>[] sites;
        List<string>[] head;
        List<string>[] forAdjusmentItems;
        string transactionId;
        string siteId;
        string notes;
        bool isNew;

        public formNewInventoryAdjustment(formPanelInventoryAdjustment formPanelInventoryAdjustment)
        {
            InitializeComponent();
            this.FormPanelInventoryAdjustment = formPanelInventoryAdjustment;

            this.forAdjusmentItems = new List<string>[2];
            this.forAdjusmentItems[0] = new List<string>();
            this.forAdjusmentItems[1] = new List<string>();
        }

        public void displayNew()
        {
            this.Text = "New Transaction - Inventory Adjustment";
            this.transactionId = "";
            this.isNew = true;
            this.textBoxId.Enabled = false;
            this.textBoxDateAndTime.Enabled = false;
            this.loadDetails();
        }

        public void displayView(string id)
        {
            this.Text = "View Transaction - Inventory Adjustment";
            this.transactionId = id;
            this.isNew = false;
            this.textBoxId.Enabled = false;
            this.textBoxDateAndTime.Enabled = false;
            this.textBoxNotes.Enabled = false;
            this.buttonSave.Visible = false;
            this.buttonChooseItem.Visible = false;
            this.dataGridViewList.Columns[5].Visible = false;

            this.backgroundWorkerLoadView.RunWorkerAsync();
            this.formLoading = new formLoading("Loading...");
            this.formLoading.ShowDialog();
        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChooseItem_Click_1(object sender, EventArgs e)
        {
            if (this.comboBoxSites.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a site first", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string siteId = this.sites[0][this.comboBoxSites.SelectedIndex];
            formItemPicker formItemPicker = new formItemPicker(siteId);
            if (formItemPicker.ShowDialog() == DialogResult.OK)
            {
                string[] selectedItem = formItemPicker.getSelectedItem();
                if (selectedItem.Length < 1)
                {
                    MessageBox.Show("Invalid item", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                for (int i = 0; i < this.dataGridViewList.Rows.Count; i++)
                {
                    if (this.dataGridViewList.Rows[i].Cells[0].Value.ToString().Trim() == selectedItem[0].Trim())
                    {
                        MessageBox.Show("Item already added", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                DataGridViewRow row = (DataGridViewRow)this.dataGridViewList.RowTemplate.Clone();
                row.CreateCells(this.dataGridViewList);

                row.Cells[0].Value = selectedItem[0];
                row.Cells[1].Value = selectedItem[1];
                row.Cells[2].Value = selectedItem[2];

                float before = 0;
                float.TryParse(selectedItem[11], out before);
                row.Cells[3].Value = (before + 0).ToString();

                row.Cells[4].Value = "0";

                row.Cells[4].ReadOnly = false;
                row.Cells[4].Style.BackColor = Color.LightYellow;
                
                this.dataGridViewList.Rows.Add(row);
            }
        }

        public void loadDetails()
        {
            this.backgroundWorkerLoad.RunWorkerAsync();
            this.formLoading = new formLoading("Loading...");
            this.formLoading.ShowDialog();
        }

        private void formNewInventoryAdjustment_Load(object sender, EventArgs e)
        {
          
        }

        private void backgroundWorkerLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            models.site site = new models.site();
            this.sites = site.getAllActiveSites();
        }

        private void backgroundWorkerLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.comboBoxSites.Items.Clear();
            for (int i = 0; i < this.sites[0].Count; i++)
            {
                string siteDisplay = this.sites[0][i] + " - " + this.sites[1][i];
                this.comboBoxSites.Items.Add(siteDisplay);
            }

            this.formLoading.finish();
        }

        private void dataGridViewList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.comboBoxSites.Enabled = this.dataGridViewList.Rows.Count < 1;
        }

        private void dataGridViewList_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.comboBoxSites.Enabled = this.dataGridViewList.Rows.Count < 1;
        }

        private void dataGridViewList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 5 && MessageBox.Show("Are you sure do you want to remove this item?", "Confirm Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.dataGridViewList.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewList.Rows.Count < 1)
            {
                MessageBox.Show("No item(s) inputted", "Unable to Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.forAdjusmentItems[0].Clear();
            this.forAdjusmentItems[1].Clear();

            for (int i = 0; i < this.dataGridViewList.Rows.Count; i++)
            {
                string id = this.dataGridViewList.Rows[i].Cells[0].Value.ToString().Trim();
                string quantity = this.dataGridViewList.Rows[i].Cells[4].Value.ToString().Trim();

                string message = string.Format(
                    "Invalid Quantity '{0}' input for Item: \r\n\r\nID: {1} \r\nItem Identification: {2} \r\nName: {3}",
                    quantity,
                    this.dataGridViewList.Rows[i].Cells[0].Value.ToString(),
                    this.dataGridViewList.Rows[i].Cells[1].Value.ToString(),
                    this.dataGridViewList.Rows[i].Cells[2].Value.ToString()
                );

                if (!float.TryParse(quantity, out _))
                {
                    MessageBox.Show(message, "Unable to Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                float quantityValue = float.Parse(quantity);
                if (quantityValue < 0)
                {
                    MessageBox.Show(message, "Unable to Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.forAdjusmentItems[0].Add(id);
                this.forAdjusmentItems[1].Add(quantity);
            }

            this.notes = this.textBoxNotes.Texts;
            this.backgroundWorkerSave.RunWorkerAsync();

            this.formLoading = new formLoading("Saving...");
            this.formLoading.ShowDialog();
        }

        private void comboBoxSites_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.isNew)
            {
                this.siteId = this.sites[0][this.comboBoxSites.SelectedIndex];
            }
        }

        private void backgroundWorkerSave_DoWork(object sender, DoWorkEventArgs e)
        {
            models.inventoryAdjustment inventory = new models.inventoryAdjustment();
            inventory.createAdjustments(this.siteId, this.notes, this.forAdjusmentItems);
        }

        private void backgroundWorkerSave_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.formLoading.Close();
            MessageBox.Show("Transaction Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }

        private void backgroundWorkerLoadView_DoWork(object sender, DoWorkEventArgs e)
        {
            models.inventoryAdjustment inventoryAdjustment = new models.inventoryAdjustment();
            this.head = inventoryAdjustment.getById(this.transactionId);
            this.forAdjusmentItems = inventoryAdjustment.getItemsById(this.transactionId);
        }

        private void backgroundWorkerLoadView_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.formLoading.finish();
            if (head[0].Count < 1)
            {
                MessageBox.Show("Transaction not foud", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.OK;
                return;
            }

            this.textBoxId.Texts = head[0][0];
            this.textBoxDateAndTime.Texts = head[4][0];
            this.textBoxNotes.Texts = head[2][0];

            this.comboBoxSites.Items.Clear();
            this.comboBoxSites.Items.Add(head[5][0]);
            this.comboBoxSites.SelectedIndex = 0;

            DataGridViewRow[] rows = new DataGridViewRow[forAdjusmentItems[0].Count];
            for (int i = 0; i < this.forAdjusmentItems[0].Count; i++)
            {
                rows[i] = (DataGridViewRow)dataGridViewList.RowTemplate.Clone();
                rows[i].CreateCells(dataGridViewList);

                rows[i].Cells[0].Value = this.forAdjusmentItems[0][i];
                rows[i].Cells[1].Value = this.forAdjusmentItems[4][i];
                rows[i].Cells[2].Value = this.forAdjusmentItems[5][i];

                string beforeDisplay = (float.Parse(this.forAdjusmentItems[2][i]) + 0).ToString();
                rows[i].Cells[3].Value = beforeDisplay;

                string newDisplay = (float.Parse(this.forAdjusmentItems[3][i]) + 0).ToString();
                rows[i].Cells[4].Value = newDisplay;
            }

            this.dataGridViewList.Rows.Clear();
            this.dataGridViewList.Rows.AddRange(rows);
        }
    }
}
