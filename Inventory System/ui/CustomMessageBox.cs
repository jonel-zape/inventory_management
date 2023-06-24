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
    public partial class CustomMessageBox : Form
    {
        public static int ICON_QUESTION = 0;
        public static int ICON_INFORMATION = 1;
        public static int ICON_WARNING = 2;
        public static int ICON_FAILED = 3;
        public static int ICON_SUCCESS = 4;

        public static int BUTTON_OK = 5;
        public static int BUTTON_YES_NO = 6;
        public static int BUTTON_YES_NO_CANCEL = 7;

        public CustomMessageBox(int icon, int button, string title, string message)
        {
            InitializeComponent();

            this.Text = title;
            this.textBoxMessage.Text = message;

            switch (icon)
            {
                case 0:
                    this.pictureBoxIcon.Image = Properties.Resources.icons8_question_mark_64;
                    break;
                case 1:
                    this.pictureBoxIcon.Image = Properties.Resources.icons8_information_64;
                    break;
                case 2:
                    this.pictureBoxIcon.Image = Properties.Resources.icons8_error_64;
                    break;
                case 3:
                    this.pictureBoxIcon.Image = Properties.Resources.icons8_cancel_64;
                    break;
                case 4:
                    this.pictureBoxIcon.Image = Properties.Resources.icons8_ok_64;
                    break;
                case 5:
                    this.pictureBoxIcon.Image = Properties.Resources.icons8_ok_64;
                    break;
                default:
                    this.pictureBoxIcon.Image = Properties.Resources.icons8_information_64;
                    break;
            }

            switch (button)
            {
                case 6:
                    this.customButtonResponse1.Visible = false;
                    this.customButtonResponse2.Visible = true;
                    this.customButtonResponse3.Visible = true;

                    this.customButtonResponse2.Text = "Yes";
                    this.customButtonResponse3.Text = "No";
                    this.customButtonResponse2.DialogResult = DialogResult.Yes;
                    this.customButtonResponse3.DialogResult = DialogResult.No;
                    break;

                case 7:
                    this.customButtonResponse1.Visible = true;
                    this.customButtonResponse2.Visible = true;
                    this.customButtonResponse3.Visible = true;

                    this.customButtonResponse1.Text = "Yes";
                    this.customButtonResponse2.Text = "No";
                    this.customButtonResponse3.Text = "Cancel";
                    this.customButtonResponse1.DialogResult = DialogResult.Yes;
                    this.customButtonResponse2.DialogResult = DialogResult.No;
                    this.customButtonResponse3.DialogResult = DialogResult.Cancel;
                    break;

                default:
                    this.customButtonResponse1.Visible = false;
                    this.customButtonResponse2.Visible = false;
                    this.customButtonResponse3.Visible = true;

                    this.customButtonResponse3.Text = "OK";
                    this.customButtonResponse3.DialogResult = DialogResult.OK;
                    break;
            }
        }
    }
}
