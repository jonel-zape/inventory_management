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
	public partial class formLogin : Form
	{
		formLoading formLoading;
		string username;
		string password;
		bool isLoginSuccess;
		public formLogin()
		{
			InitializeComponent();
			this.isLoginSuccess = false;
		}

        private void backgroundWorkerLogin_DoWork(object sender, DoWorkEventArgs e)
        {
			database database = new database();
			this.username = database.escapeString(this.username);
			this.password = database.escapeString(tools.hashString(this.password));

			string query = string.Format("SELECT * FROM user WHERE username = '{0}' AND password = '{1}' AND status = 1 AND date_time_deleted IS NULL LIMIT 1", this.username, this.password);
			var data = database.getData(query);

			string userId = "";
			string username = "";
			string isAdmin = "0";
			if (data == null) 
			{
				Properties.Settings.Default.user_id = "";
				Properties.Settings.Default.Save();
				this.isLoginSuccess = false;
				return;
			}

			while (data.Read()) 
			{
				userId = data["id"].ToString();
				username = data["username"].ToString();
				isAdmin = data["is_admin"].ToString(); 
			}

			database.closeConnection();

			Properties.Settings.Default.user_id = userId;
			Properties.Settings.Default.log_username = username;
			Properties.Settings.Default.admin = isAdmin;
			Properties.Settings.Default.Save();

			this.isLoginSuccess = userId != "";
		}

        private void backgroundWorkerLogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
			formLoading.Close();
			if (this.isLoginSuccess)
			{
				this.textBoxUsername.Texts = "";
				this.textBoxPassword.Texts = "";
				this.textBoxUsername.Focus();

				Form formDashboard = new formDashboard(this);
				formDashboard.Show();
				this.Hide();
			}
			else 
			{
				Properties.Settings.Default.user_id = "";
				Properties.Settings.Default.Save();
				ui.CustomMessageBox customMessageBox = new ui.CustomMessageBox(ui.CustomMessageBox.ICON_FAILED, ui.CustomMessageBox.BUTTON_OK, "Authentication Failed", "Invalid Username or Password");
				customMessageBox.ShowDialog();
			}
		}

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
			if (e.KeyCode == Keys.Enter)
			{
				this.buttonLogin_Click(sender, e);
			}
        }

        private void label4_DoubleClick(object sender, EventArgs e)
        {
			formSettings formSettings = new formSettings();
			formSettings.ShowDialog();
		}

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void formLogin_Load(object sender, EventArgs e)
        {
			this.timerCounter.Enabled = true;

			this.labelLicenseTo.Text = "Licensed to: " + Properties.Settings.Default.license_to;

			float remainingTime = 0;
			float.TryParse(Properties.Settings.Default.remaining_time, out remainingTime);
			if (Properties.Settings.Default.product_key.Trim() == "" || remainingTime <= 0)
			{
				this.timerCounter.Enabled = false;

				formChangeProductKey formChangeProductKey = new formChangeProductKey();
				formChangeProductKey.setMessage("Please input your activation key before you can log in to this system.", "Activation is Required");
				if (formChangeProductKey.ShowDialog() != DialogResult.OK)
				{
					this.Close();
				}
			}
        }

        private void timerCounter_Tick(object sender, EventArgs e)
        {
			int counter = 0;

			int.TryParse(Properties.Settings.Default.remaining_time, out counter);

			counter--;

			Properties.Settings.Default.remaining_time = counter.ToString();
			Properties.Settings.Default.Save();

			if (counter <= 0)
			{
				Properties.Settings.Default.remaining_time = "0";
				Properties.Settings.Default.product_key = "";
				Properties.Settings.Default.license_to = "";
				Properties.Settings.Default.Save();

				timerCounter.Enabled = false;

				formChangeProductKey formChangeProductKey = new formChangeProductKey();
				formChangeProductKey.setMessage("Please input your activation key before you can log in to this system.", "License Key is Expired");
				if (formChangeProductKey.ShowDialog() != DialogResult.OK)
				{
					this.Close();
				}
				else
				{
					timerCounter.Enabled = true;
				}
			}
		}

        private void buttonLogin_Click(object sender, EventArgs e)
        {
			this.username = textBoxUsername.Texts;
			this.password = textBoxPassword.Texts;
			this.isLoginSuccess = false;

			if (username == "" || password == "")
			{
				ui.CustomMessageBox customMessageBox = new ui.CustomMessageBox(ui.CustomMessageBox.ICON_FAILED, ui.CustomMessageBox.BUTTON_OK, "Authentication Failed", "Invalid Username or Password");
				customMessageBox.ShowDialog();
				return;
			}

			backgroundWorkerLogin.RunWorkerAsync();
			this.formLoading = new formLoading("Logging In...");
			formLoading.ShowDialog();
		}

        private void customButton6_Click(object sender, EventArgs e)
        {
			formAbout formAbout = new formAbout();
			formAbout.ShowDialog();
		}
    }
}
