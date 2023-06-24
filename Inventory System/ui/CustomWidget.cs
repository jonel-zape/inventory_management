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
    public partial class CustomWidget : UserControl
    {
        public CustomWidget()
        {
            InitializeComponent();
        }

        [Category("Custom Widget")]
        public Color WidgetColor
        {
            get 
            { 
                return this.panelContainer.BackColor; 
            }

            set
            {
                this.panelContainer.BackColor = value;
                this.countLabel.BackColor = value;
                this.Invalidate();
            }
        }

        [Category("Custom Widget")]
        public string WidgetLabel
        {
            get
            {
                return this.titleLabel.Text;
            }

            set
            {
                this.titleLabel.Text = value;
            }
        }

        [Category("Custom Widget")]
        public string WidgetValue
        {
            get
            {
                return this.countLabel.Text;
            }

            set
            {
                this.countLabel.Text = value;
            }
        }

        [Category("Custom Widget")]
        public Image WidgetIcon
        {
            get
            {
                return this.pictureBox1.Image;
            }

            set
            {
                this.pictureBox1.Image = value;
            }
        }
    }
}
