using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System.ui
{
    public partial class PaginationControl : UserControl
    {
        public PaginationControl()
        {
            InitializeComponent();

            this.textBoxPage.Text = currentPage.ToString();
            this.labelTotalRows.Text = "Total Rows: " + totalPage.ToString();
            this.labelTotalPage.Text = totalPage.ToString();
        }

        int currentPage = 0;
        int totalRow = 0;
        int totalPage = 0;

        [Category("Pagination")]
        public int CurrentPage
        {
            get
            {
                return currentPage;
            }

            set
            {
                currentPage = value;
                this.textBoxPage.Text = currentPage.ToString();
                this.Invalidate();
            }
        }

        [Category("Pagination")]
        public int TotalRow
        {
            get
            {
                return totalRow;
            }

            set
            {
                totalRow = value;
                this.labelTotalRows.Text = "Total Rows: " + totalRow.ToString();
                this.Invalidate();
            }
        }

        [Category("Pagination")]
        public int TotalPage
        {
            get
            {
                return totalPage;
            }

            set
            {
                totalPage = value;
                this.labelTotalPage.Text = totalPage.ToString();
                this.Invalidate();
            }
        }

        private void customButtonPrev_Click(object sender, EventArgs e)
        {
            this.currentPage--;
            if (this.currentPage <= 0)
            {
                this.currentPage = 1;
                return;
            }
            this.textBoxPage.Text = this.currentPage.ToString();
            this.Invalidate();
            this.Page_Changed(sender, e);
        }

        private void customButtonNext_Click(object sender, EventArgs e)
        {
            this.currentPage++;
            if (this.currentPage > this.totalPage)
            {
                this.currentPage = this.totalPage;
                return;
            }
            this.textBoxPage.Text = this.currentPage.ToString();
            this.Invalidate();
            this.Page_Changed(sender, e);
        }

        private void textBoxPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool isNumeric = int.TryParse(this.textBoxPage.Text, out this.currentPage);
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
                    this.textBoxPage.Text = this.currentPage.ToString();
                    this.Invalidate();
                    this.Page_Changed(sender, e);
                }
            }
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Page selection updated")]
        public event EventHandler PageChanged;

        protected void Page_Changed(object sender, EventArgs e)
        {
            if (this.PageChanged != null)
            {
                this.PageChanged(this, e);
            }
        }
    }
}
