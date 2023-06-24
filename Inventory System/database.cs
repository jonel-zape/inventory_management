using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace Inventory_System
{
    class database
    {
        MySqlConnection mySqlConnection;
        bool isConnected;
        string insertedId;

        public database()
        {
            string server = Properties.Settings.Default.host;
            string port = "3306";
            string user = Properties.Settings.Default.username;
            string password = Properties.Settings.Default.password;
            string database = Properties.Settings.Default.db;
            this.isConnected = false;

            this.insertedId = "";

            try
            {
                string connectionString = string.Format("server={0}; port={1};user id={2}; password={3}; database={4};", server, port, user, password, database);

                tools.consoleLog(connectionString);

                mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();
                this.isConnected = true;
            }
            catch (MySqlException error)
            {
                this.isConnected = false;
                MessageBox.Show(error.Message.ToString(), "Unable to Connect.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string escapeString(string input)
        {
            return MySqlHelper.EscapeString(input);
        }

        public MySqlDataReader getData(string query) 
        {
            if (!this.isConnected)
            {
                return null;
            }

            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                System.Diagnostics.Debug.WriteLine(query);
                return mySqlDataReader;
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message.ToString(), "Unable to Execute", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }          
        }

        public bool execute(string query)
        {
            if (!this.isConnected)
            {
                return false;
            }

            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                var rowsAffected = mySqlCommand.ExecuteNonQuery();
                this.insertedId = mySqlCommand.LastInsertedId.ToString();

                System.Diagnostics.Debug.WriteLine(rowsAffected);
                System.Diagnostics.Debug.WriteLine(query);
                this.closeConnection();
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message.ToString(), "Unable to Execute", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void closeConnection()
        {
            mySqlConnection.Close();
        }

        public string getLastInsertedId()
        {
            return this.insertedId;
        }
    }
}
