using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class formLoading : Form
    {
        public string content;
        string type;

        public formLoading(string content, string type = "default")
        {
            InitializeComponent();

            this.content = content;
            this.type = type;
            loadingCell.Left = 1 - loadingCell.Width;
            this.displayText.Text = this.content;
            if (this.type == "default")
            {
                this.timer1.Enabled = true;
            }
        }

        public void moveProgress(int value)
        {
            if (this.type == "default")
            {
                return;
            }
        }

        public void setContent(string displayContent)
        {
            this.displayText.Text = displayContent;
        }

        public void finish()
        {
            this.timer2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.loadingCell.Left = this.loadingCell.Left + 10;
            if (this.loadingCell.Left >= this.Width) 
            {
                this.loadingCell.Left = 1 - this.loadingCell.Width;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
