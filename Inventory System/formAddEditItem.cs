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
    public partial class formAddEditItem : Form
    {
        formPanelItems FormPanelItems;
        formLoading formLoading;
        List<string>[] allActiveSites;

        string id;
        string barcode;
        string name;
        string description;
        string price;
        string status;
        List<string> assignedSites;

        bool isAdd;
        bool isSaveSuccess;
        string errorMessage;

        public formAddEditItem(formPanelItems formPanelItems)
        {
            InitializeComponent();
            this.FormPanelItems = formPanelItems;
            this.id = "";
            this.barcode = "";
            this.name = "";
            this.description = "";
            this.price = "";
            this.status = "";
            this.assignedSites = new List<string>();
        }

        public void displayEdit(string id)
        {
            this.id = id;
            this.Text = "Update Item";
            this.isAdd = false;
        }

        public void displayAdd()
        {
            this.Text = "Add New Item";
            this.isAdd = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formAddEditItem_Load(object sender, EventArgs e)
        {
            backgroundWorkerGetAllSites.RunWorkerAsync();
            this.formLoading = new formLoading("Loading...");
            this.formLoading.ShowDialog();
        }

        private void backgroundWorkerGetAllSites_DoWork(object sender, DoWorkEventArgs e)
        {
            models.site site = new models.site();
            allActiveSites = site.getAllActiveSites();
            models.item item = new models.item();

            if (this.isAdd)
            {                
                this.barcode = item.getSuggestedBarcode();
            }
            else 
            {
                string[] details = item.getById(this.id);

                this.id = details[0];
                this.barcode = details[1];
                this.name = details[2];
                this.description = details[3];
                this.price = details[4];
                this.status = details[5];

                List<string>[] selectedSites = item.getSitesAssignedById(this.id);
                this.assignedSites.Clear();
                for (int i = 0; i < selectedSites[0].Count; i++)
                {
                    this.assignedSites.Add(selectedSites[2][i]);
                }
            }
        }

        private void backgroundWorkerGetAllSites_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (this.isAdd)
            {
                this.textBoxBarcode.Texts = this.barcode;
            }
            else
            {
                if (this.id.Trim() == "")
                {
                    MessageBox.Show("Item not found", "Unable to Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.formLoading.finish();
                    this.Close();
                    return;
                }

                this.textBoxBarcode.Texts = this.barcode;
                this.textBoxName.Texts = this.name;
                this.textBoxDescription.Texts = this.description;
                this.comboBoxStatus.SelectedIndex = this.status == "1" ? 0 : 1;
            }

            this.checkedListBoxSites.Items.Clear();
            for (int i = 0; i < this.allActiveSites[0].Count; i++)
            {
                string item = this.allActiveSites[0][i] + " - " + this.allActiveSites[1][i];
                bool isCheck = false;

                if (!this.isAdd)
                {
                    if (this.assignedSites.IndexOf(this.allActiveSites[0][i]) > -1)
                    {
                        isCheck = true;
                    }
                }

                this.checkedListBoxSites.Items.Add(item, isCheck);
            }

            this.formLoading.finish();
            this.textBoxName.Select();
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            bool isChecked = true;

            if (this.checkedListBoxSites.Items.Count == this.checkedListBoxSites.CheckedItems.Count)
            {
                isChecked = false;
            }

            for (int i = 0; i < this.checkedListBoxSites.Items.Count; i++)
            {
                this.checkedListBoxSites.SetItemChecked(i, isChecked);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.barcode = this.textBoxBarcode.Texts.Trim();
            this.name = this.textBoxName.Texts.Trim();
            this.description = this.textBoxDescription.Texts.Trim();
            this.price = "0";
            this.status = this.comboBoxStatus.SelectedIndex == 0 ? "1" : "0";

            if (this.barcode == "")
            {
                MessageBox.Show("Item Barcode is required", "Unable to Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.name == "")
            {
                MessageBox.Show("Item Name is required", "Unable to Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!float.TryParse(this.price, out _))
            {
                MessageBox.Show("Invalid Price", "Unable to Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.comboBoxStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Status is required", "Unable to Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.checkedListBoxSites.CheckedItems.Count < 1 && MessageBox.Show("Are you sure do you want to save this item without site(s) assigned?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            this.assignedSites.Clear();
            for (int i = 0; i < this.checkedListBoxSites.Items.Count; i++)
            {
                if (this.checkedListBoxSites.GetItemChecked(i))
                {
                    this.assignedSites.Add(this.allActiveSites[0][i]);
                }
            }

            backgroundWorkerAdd.RunWorkerAsync();
            formLoading = new formLoading("Saving...");
            formLoading.ShowDialog();
        }

        private void backgroundWorkerAdd_DoWork(object sender, DoWorkEventArgs e)
        {
            this.isSaveSuccess = true;
            this.errorMessage = "";

            models.item item = new models.item();

            if (this.isAdd)
            {
                if (item.isBarcodeExist(this.barcode))
                {
                    this.isSaveSuccess = false;
                    this.errorMessage = "Barcode already exist";
                    return;
                }

                item.insert(this.barcode, this.name, this.description, this.status, this.price, this.assignedSites);
            }
            else
            {
                if (item.isBarcodeExist(this.barcode, this.id))
                {
                    this.isSaveSuccess = false;
                    this.errorMessage = "Barcode already exist";
                    return;
                }

                item.update(this.id, this.barcode, this.name, this.description, this.status, this.price, this.assignedSites);
            }          
        }

        private void backgroundWorkerAdd_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.formLoading.finish();
            if (this.isSaveSuccess)
            {
                MessageBox.Show("Item Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(this.errorMessage, "Unable to Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
