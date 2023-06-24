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
    public partial class formNewStockTransferTransaction : Form
    {
        formPanelStockTransfer FormPanelStockTransfer;
        formLoading formLoading;
        List<string>[] sites;
        List<string>[] head;
        List<string>[] forTransferItems;
        string transactionId;
        string siteIdFrom;
        string siteIdTo;
        string notes;
        bool isNew;

        public formNewStockTransferTransaction(formPanelStockTransfer formPanelStockTransfer)
        {
            InitializeComponent();
            this.FormPanelStockTransfer = formPanelStockTransfer;

            this.forTransferItems = new List<string>[2];
            this.forTransferItems[0] = new List<string>();
            this.forTransferItems[1] = new List<string>();
        }

        public void displayNew()
        {
            this.Text = "New Transaction - Tools and Equipment Transfer";
            this.transactionId = "";
            this.isNew = true;
            this.textBoxId.Enabled = false;
            this.textBoxDateAndTime.Enabled = false;
            this.loadDetails();
        }

        public void displayView(string id)
        {
            this.Text = "View Transaction - Tools and Equipment Transfer";
            this.transactionId = id;
            this.isNew = false;
            this.textBoxId.Enabled = false;
            this.textBoxDateAndTime.Enabled = false;
            this.textBoxNotes.Enabled = false;
            this.buttonSave.Visible = false;
            this.buttonChooseItem.Visible = false;
            this.dataGridViewList.Columns[3].Visible = false;
            this.dataGridViewList.Columns[5].Visible = false;

            this.backgroundWorkerLoadView.RunWorkerAsync();
            this.formLoading = new formLoading("Loading...");
            this.formLoading.ShowDialog();
        }

        public void loadDetails()
        {
            this.backgroundWorkerSites.RunWorkerAsync();
            this.formLoading = new formLoading("Loading...");
            this.formLoading.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formNewStockTransferTransaction_Load(object sender, EventArgs e)
        {

        }

        private void buttonChooseItem_Click(object sender, EventArgs e)
        {
            if (this.comboBoxSitesFrom.SelectedIndex < 0)
            {
                MessageBox.Show("Please specify 'Transfer From' site first", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string siteId = this.sites[0][this.comboBoxSitesFrom.SelectedIndex];
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewList.Rows.Count < 1)
            {
                MessageBox.Show("No item(s) inputted", "Unable to Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.comboBoxSitesTo.SelectedIndex < 0)
            {
                MessageBox.Show("Please specify 'Transfer To' site.", "Unable to Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.comboBoxSitesFrom.SelectedIndex == this.comboBoxSitesTo.SelectedIndex)
            {
                MessageBox.Show("Transfer 'From' and 'To' should no be the same", "Unable to Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.forTransferItems[0].Clear();
            this.forTransferItems[1].Clear();

            for (int i = 0; i < this.dataGridViewList.Rows.Count; i++)
            {
                string id = this.dataGridViewList.Rows[i].Cells[0].Value.ToString().Trim();
                string quantity = this.dataGridViewList.Rows[i].Cells[4].Value.ToString().Trim();
                string currentQuantity = this.dataGridViewList.Rows[i].Cells[3].Value.ToString().Trim();

                string message = string.Format(
                    "Invalid Quantity '{0}' input for Item: \r\n\r\nID: {1} \r\nBarcode: {2} \r\nName: {3}",
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
                if (quantityValue < 1)
                {
                    MessageBox.Show(message + "\r\n\r\nQuantity should be greater than zero", "Unable to Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                float currentQuantityValue = float.Parse(currentQuantity);
                if (quantityValue > currentQuantityValue)
                {
                    MessageBox.Show(message + "\r\n\r\nQuantity to transfer should not be greater than current inventory", "Unable to Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.forTransferItems[0].Add(id);
                this.forTransferItems[1].Add(quantity);
            }

            this.siteIdFrom = this.sites[0][this.comboBoxSitesFrom.SelectedIndex];
            this.siteIdTo = this.sites[0][this.comboBoxSitesTo.SelectedIndex];

            this.notes = this.textBoxNotes.Texts;
            this.backgroundWorkerSave.RunWorkerAsync();

            this.formLoading = new formLoading("Saving...");
            this.formLoading.ShowDialog();
        }

        private void backgroundWorkerSites_DoWork(object sender, DoWorkEventArgs e)
        {
            models.site site = new models.site();
            this.sites = site.getAllActiveSites();
        }

        private void backgroundWorkerSites_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.comboBoxSitesFrom.Items.Clear();
            this.comboBoxSitesTo.Items.Clear();
            for (int i = 0; i < this.sites[0].Count; i++)
            {
                string siteDisplay = this.sites[0][i] + " - " + this.sites[1][i];
                this.comboBoxSitesFrom.Items.Add(siteDisplay);
                this.comboBoxSitesTo.Items.Add(siteDisplay);
            }
            this.formLoading.finish();
        }

        private void dataGridViewList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.comboBoxSitesFrom.Enabled = this.dataGridViewList.Rows.Count < 1;
        }

        private void dataGridViewList_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.comboBoxSitesFrom.Enabled = this.dataGridViewList.Rows.Count < 1;
        }

        private void dataGridViewList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
               
            }

            if (e.ColumnIndex == 5 && MessageBox.Show("Are you sure do you want to remove this item?", "Confirm Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.dataGridViewList.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void backgroundWorkerSave_DoWork(object sender, DoWorkEventArgs e)
        {
            models.inventoryTransfer inventoryTransfer = new models.inventoryTransfer();
            inventoryTransfer.createTransfer(this.siteIdFrom, this.siteIdTo, this.notes, this.forTransferItems);
        }

        private void backgroundWorkerSave_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.formLoading.Close();
            MessageBox.Show("Transaction Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }

        private void backgroundWorkerLoadView_DoWork(object sender, DoWorkEventArgs e)
        {
            models.inventoryTransfer inventoryTransfer = new models.inventoryTransfer();
            this.head = inventoryTransfer.getById(this.transactionId);
            this.forTransferItems = inventoryTransfer.getItemsById(this.transactionId);
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

            this.comboBoxSitesFrom.Items.Clear();
            this.comboBoxSitesFrom.Items.Add(head[5][0]);
            this.comboBoxSitesFrom.SelectedIndex = 0;

            this.comboBoxSitesTo.Items.Clear();
            this.comboBoxSitesTo.Items.Add(head[6][0]);
            this.comboBoxSitesTo.SelectedIndex = 0;

            this.comboBoxSitesTo.Enabled = false;

            DataGridViewRow[] rows = new DataGridViewRow[forTransferItems[0].Count];
            for (int i = 0; i < this.forTransferItems[0].Count; i++)
            {
                rows[i] = (DataGridViewRow)dataGridViewList.RowTemplate.Clone();
                rows[i].CreateCells(dataGridViewList);

                rows[i].Cells[0].Value = this.forTransferItems[0][i];
                rows[i].Cells[1].Value = this.forTransferItems[3][i];
                rows[i].Cells[2].Value = this.forTransferItems[4][i];

                string newDisplay = (float.Parse(this.forTransferItems[2][i]) + 0).ToString();
                rows[i].Cells[4].Value = newDisplay;
            }

            this.dataGridViewList.Rows.Clear();
            this.dataGridViewList.Rows.AddRange(rows);
        }
    }
}
