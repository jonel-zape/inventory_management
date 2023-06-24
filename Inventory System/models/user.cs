using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System.models
{
    class user: model
    {
        public List<string>[] getById(string id)
        {
            string query = string.Format(
                @"SELECT
	                `id`,
                    `username`,
                    `first_name`,
                    `last_name`,
                    `status`
                FROM `user` 
                WHERE `date_time_deleted` IS NULL AND id = '{0}'",
                database.escapeString(id)
            );

            string[] fields = new string[5];
            fields[0] = "id";
            fields[1] = "username";
            fields[2] = "first_name";
            fields[3] = "last_name";
            fields[4] = "status";

            return this.getDataList(query, fields);
        }

        public bool authMyPassword(string password)
        {
            string query = string.Format(
                @"SELECT * FROM user WHERE `id` = '{0}' AND `password` = '{1}' AND `status` = 1 AND `date_time_deleted` IS NULL",
                   database.escapeString(Properties.Settings.Default.user_id),
                   database.escapeString(tools.hashString(password))
            );

            string[] fields = new string[1];
            fields[0] = "id";

            List<string>[] user = this.getDataList(query, fields);

            return user[0].Count > 0;
        }

        public List<string>[] list(string status, string search, int page)
        {
            string statusFilter = "";
            if (status.Trim() != "")
            {
                statusFilter = string.Format("AND `status` = '{0}'", database.escapeString(status));
            }

            string searchFilter = "";
            if (search.Trim() != "")
            {
                searchFilter = string.Format("AND (`username` LIKE '%{0}%' OR `first_name` LIKE '%{0}%' OR `last_name` LIKE '%{0}')", database.escapeString(search));
            }

            string query = string.Format(
                @"SELECT
	                `id`,
                    `username`,
                    `first_name`,
                    `last_name`,
                    `status`
                FROM `user` 
                WHERE `date_time_deleted` IS NULL AND is_admin = 0
                {0}
                {1}",
                statusFilter,
                searchFilter
            );

            string[] fields = new string[5];
            fields[0] = "id";
            fields[1] = "username";
            fields[2] = "first_name";
            fields[3] = "last_name";
            fields[4] = "status";

            return this.getDataList(query, fields, page);
        }

        public void create(string username, string password, string status, string firstName, string lastName)
        {
            string query = string.Format(
                @"INSERT INTO user (`username`, `password`, `first_name`, `last_name`, `status`, `created_by`) 
                VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                database.escapeString(username),
                tools.hashString(password),
                database.escapeString(firstName),
                database.escapeString(lastName),
                database.escapeString(status),
                database.escapeString(Properties.Settings.Default.user_id)
            );

            tools.consoleLog(query);

            database databaseCreate = new database();
            databaseCreate.execute(query);
        }

        public void update(string userId, string username, string password, string status, string firstName, string lastName)
        {
            string query = string.Format(
                @"UPDATE `user` SET 
                    `username` = '{0}',
                    `first_name` = '{1}',
                    `last_name` = '{2}',
                    `status` = '{3}'
                WHERE id = '{4}'",
                database.escapeString(username),
                database.escapeString(firstName),
                database.escapeString(lastName),
                database.escapeString(status),
                database.escapeString(userId)
            );

            tools.consoleLog(query);

            database databaseUpdate = new database();
            databaseUpdate.execute(query);

            if (password.Trim() == "")
            {
                return;
            }

            string queryPassword = string.Format(
                @"UPDATE user SET `password` = '{0}' WHERE `id` = '{1}'",
                tools.hashString(password),
                database.escapeString(userId)
            );

            database databaseUpdatePassword = new database();
            databaseUpdatePassword.execute(queryPassword);
        }

        public bool isUsernameExists(string username, string userId = "0")
        {
            string excludeUserIdFilter = "";
            if (userId != "0")
            {
                excludeUserIdFilter = string.Format(" AND `id` != '{0}'", database.escapeString(userId));
            }

            string query = string.Format("SELECT id FROM user WHERE `username` = '{0}' {1}", database.escapeString(username), excludeUserIdFilter);

            string[] fields = new string[1];
            fields[0] = "id";

            List<string>[] data = this.getDataList(query, fields);

            return data[0].Count > 0;
        }

        public void deleteUser(string userId)
        {
            string query = string.Format("UPDATE user SET date_time_deleted = NOW() WHERE id = '{0}'", database.escapeString(userId));
            database databaseDelete = new database();
            databaseDelete.execute(query);
        }
    }
}
