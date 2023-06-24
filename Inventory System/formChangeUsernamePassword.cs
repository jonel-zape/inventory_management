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
    public partial class formChangeUsernamePassword : Form
    {
        public formChangeUsernamePassword()
        {
            InitializeComponent();
        }

        private void buttonCloseUsername_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClosePassword_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
