using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Inventory_System
{
    class deploy
    {
        MySqlConnection mySqlConnection;
        bool isConnected;
        string errorMessage;

        public deploy()
        {
            string server = Properties.Settings.Default.host;
            string port = "3306";
            string user = Properties.Settings.Default.username;
            string password = Properties.Settings.Default.password;
            this.isConnected = false;

            try
            {
                string connectionString = string.Format("server={0}; port={1};user id={2}; password={3};", server, port, user, password);
                mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();
                this.isConnected = true;
            }
            catch (MySqlException error)
            {
                this.errorMessage = error.Message;
                this.isConnected = false;
            }
        }

        private void initiateNewConnectionWithDb()
        {
            string server = Properties.Settings.Default.host;
            string port = "3306";
            string user = Properties.Settings.Default.username;
            string password = Properties.Settings.Default.password;
            string database = Properties.Settings.Default.db;
            this.isConnected = false;

            try
            {
                string connectionString = string.Format("server={0}; port={1};user id={2}; password={3}; database={4};", server, port, user, password, database);
                mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();
                this.isConnected = true;
            }
            catch (MySqlException error)
            {
                this.isConnected = false;
                this.errorMessage = error.Message;
            }
        }

        public string getErrorMessage()
        {
            return this.errorMessage;
        }

        public bool deployDatabase()
        {
            string database = Properties.Settings.Default.db;

            if (!this.isConnected)
            {
                return false;
            }

            if (!this.execute("create database " + database))
            {
                return false;
            }

            string query = @"SET GLOBAL sql_mode=(SELECT REPLACE(@@sql_mode,'ONLY_FULL_GROUP_BY',''));";
            this.initiateNewConnectionWithDb();
            if (!this.execute(query))
            {
                return false;
            }

            query = @"
                CREATE TABLE `item` (
                  `id` int NOT NULL AUTO_INCREMENT,
                  `barcode` varchar(512) DEFAULT NULL,
                  `name` varchar(512) DEFAULT NULL,
                  `description` varchar(512) DEFAULT NULL,
                  `price` decimal(10,3) DEFAULT NULL,
                  `status` int DEFAULT '0',
                  `created_by` int DEFAULT NULL,
                  `date_time_created` datetime DEFAULT CURRENT_TIMESTAMP,
                  `modified_by` int DEFAULT NULL,
                  `date_time_modified` datetime DEFAULT NULL,
                  `date_time_deleted` datetime DEFAULT NULL,
                  PRIMARY KEY (`id`),
                  KEY `ix_date_time_deleted` (`date_time_deleted`) /*!80000 INVISIBLE */,
                  KEY `ix_status` (`status`),
                  KEY `ix_barcode` (`barcode`)
                )";
            this.initiateNewConnectionWithDb();
            if (!this.execute(query))
            {
                return false;
            }

            query = @"
                CREATE TABLE `item_site` (
                  `id` int NOT NULL AUTO_INCREMENT,
                  `item_id` int DEFAULT NULL,
                  `site_id` int DEFAULT NULL,
                  `inventory` decimal(10,3) DEFAULT '0.000',
                  `status` int DEFAULT '0',
                  PRIMARY KEY (`id`),
                  UNIQUE KEY `uq_item_site` (`item_id`,`site_id`),
                  KEY `ix_item_id` (`item_id`) /*!80000 INVISIBLE */,
                  KEY `ix_site_id` (`site_id`)
                )";
            this.initiateNewConnectionWithDb();
            if (!this.execute(query))
            {
                return false;
            }

            query = @"
                CREATE TABLE `site` (
                    `id` int NOT NULL AUTO_INCREMENT,
                    `name` varchar(1024) DEFAULT NULL,
                    `address` varchar(1024) DEFAULT NULL,
                    `details` varchar(1024) DEFAULT NULL,
                    `status` int DEFAULT '0',
                    `created_by` int DEFAULT NULL,
                    `date_time_created` datetime DEFAULT CURRENT_TIMESTAMP,
                    `modified_by` int DEFAULT NULL,
                    `date_time_modifed` datetime DEFAULT NULL,
                    `date_time_deleted` datetime DEFAULT NULL,
                    PRIMARY KEY (`id`),
                    KEY `ix_date_time_deleted` (`date_time_deleted`) /*!80000 INVISIBLE */,
                    KEY `ix_status` (`status`)
                )";
            this.initiateNewConnectionWithDb();
            if (!this.execute(query))
            {
                return false;
            }

            query = @"
                CREATE TABLE `transaction_inventory_adjustment` (
                  `id` int NOT NULL AUTO_INCREMENT,
                  `site_id` int DEFAULT NULL,
                  `notes` varchar(1024) DEFAULT NULL,
                  `created_by` int DEFAULT NULL,
                  `status` int DEFAULT '0',
                  `date_time_created` datetime DEFAULT CURRENT_TIMESTAMP,
                  PRIMARY KEY (`id`),
                  KEY `ix_site_id` (`site_id`),
                  KEY `ix_date_time_created` (`date_time_created`)
                )";
            this.initiateNewConnectionWithDb();
            if (!this.execute(query))
            {
                return false;
            }

            query = @"
                CREATE TABLE `transaction_inventory_adjustment_detail` (
                  `id` int NOT NULL AUTO_INCREMENT,
                  `transaction_inventory_adjustment_id` int DEFAULT NULL,
                  `item_id` int DEFAULT NULL,
                  `before_quantity` decimal(10,3) DEFAULT NULL,
                  `quantity` decimal(10,3) DEFAULT NULL,
                  PRIMARY KEY (`id`),
                  KEY `ix_transaction_inventory_adjustment_id` (`transaction_inventory_adjustment_id`)
                )";
            this.initiateNewConnectionWithDb();
            if (!this.execute(query))
            {
                return false;
            }

            query = @"
                CREATE TABLE `transaction_inventory_transfer` (
                  `id` int NOT NULL AUTO_INCREMENT,
                  `site_from` int DEFAULT NULL,
                  `site_to` int DEFAULT NULL,
                  `notes` varchar(1024) DEFAULT NULL,
                  `created_by` int DEFAULT NULL,
                  `status` int DEFAULT '0',
                  `date_time_created` datetime DEFAULT CURRENT_TIMESTAMP,
                  PRIMARY KEY (`id`),
                  KEY `ix_site_from` (`site_from`) /*!80000 INVISIBLE */,
                  KEY `ix_site_to` (`site_to`) /*!80000 INVISIBLE */,
                  KEY `ix_date_time_created` (`date_time_created`)
                )";
            this.initiateNewConnectionWithDb();
            if (!this.execute(query))
            {
                return false;
            }

            query = @"
                CREATE TABLE `transaction_inventory_transfer_detail` (
                    `id` int NOT NULL AUTO_INCREMENT,
                    `transaction_inventory_transfer_id` int DEFAULT NULL,
                    `item_id` int DEFAULT NULL,
                    `quantity` decimal(10,3) DEFAULT NULL,
                    PRIMARY KEY (`id`),
                    KEY `ix_inventory_transaction_inventory_transfer_id` (`transaction_inventory_transfer_id`)
                )";
            this.initiateNewConnectionWithDb();
            if (!this.execute(query))
            {
                return false;
            }

            query = @"
                CREATE TABLE `user` (
                  `id` int NOT NULL AUTO_INCREMENT,
                  `username` varchar(512) DEFAULT NULL,
                  `password` varchar(512) DEFAULT NULL,
                  `first_name` varchar(512) DEFAULT NULL,
                  `last_name` varchar(512) DEFAULT NULL,
                  `status` int DEFAULT '0',
                  `is_admin` int DEFAULT '0',
                  `created_by` int DEFAULT NULL,
                  `date_time_created` datetime DEFAULT CURRENT_TIMESTAMP,
                  `date_time_deleted` datetime DEFAULT NULL,
                  PRIMARY KEY (`id`),
                  UNIQUE KEY `username_UNIQUE` (`username`),
                  KEY `ix_username` (`username`)
                )";
            this.initiateNewConnectionWithDb();
            if (!this.execute(query))
            {
                return false;
            }

            query = @"INSERT INTO `user` VALUES (1,'admin','8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92','Admin','Admin',1,1,1, NOW(),NULL)";
            this.initiateNewConnectionWithDb();
            if (!this.execute(query))
            {
                return false;
            }

            return true;
        }

        private bool execute(string query)
        {
            if (!this.isConnected)
            {
                return false;
            }

            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                var rowsAffected = mySqlCommand.ExecuteNonQuery();
                tools.consoleLog(rowsAffected.ToString());
                tools.consoleLog(query);
                this.closeConnection();
            }
            catch (MySqlException error)
            {
                this.errorMessage = error.Message;
                return false;
            }

            return true;
        }

        public void closeConnection()
        {
            mySqlConnection.Close();
        }

    }
}
