using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System.models
{
    class item: model
    {
        database database;

        public item()
        {
            this.rowCount = 0;
            this.rowsPerPage = 50;
            this.currentPage = 1;
            this.maxPage = 0;
        }

        public string getSuggestedBarcode()
        {
            this.database = new database();

            var data = database.getData("SELECT 100000000000 + COALESCE(MAX(id), 0) + 1 AS suggested_barcode FROM item");
            if (data == null)
            {
                return "";
            }

            string suggestedBarcode = "";
            while (data.Read())
            {
                suggestedBarcode = data["suggested_barcode"].ToString();
            }

            database.closeConnection();

            return suggestedBarcode;
        }

        /// <summary>
        /// Get Item by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// string[]: [0] - id, [1] - barcode, [2] - name, [3] - description, [4] - price, [5] - status, [6] - created_by, [7] - date_time_created, [8] - modified_by, [9] - date_time_modified, [10] - date_time_deleted, [11] - created_by_username, [12] - modified_by_username
        /// </returns>
        public string[] getById(string id)
        {
            string[] result = new string[13];

            result[0] = ""; // id
            result[1] = ""; // barcode
            result[2] = ""; // name
            result[3] = ""; // description
            result[4] = ""; // price
            result[5] = ""; // status
            result[6] = ""; // created_by
            result[7] = ""; // date_time_created
            result[8] = ""; // modified_by
            result[9] = ""; // date_time_modified
            result[10] = ""; // date_time_deleted
            result[11] = ""; // created_by_username
            result[12] = ""; // modified_by_username

            string query = string.Format(
                @"SELECT 
	                I.id,
                    I.barcode,
                    I.name,
                    I.description,
                    ROUND(I.price, 2) AS price,
                    I.status,
                    I.created_by,
                    U.username AS created_by_username,
                    DATE_FORMAT(I.date_time_created, '%b %d, %Y %h:%i:%s %p') AS date_time_created,
                    I.modified_by,
                    U1.username AS modified_by_username,
                    DATE_FORMAT(I.date_time_modified, '%b %d, %Y %h:%i:%s %p') AS date_time_modified,
                    I.date_time_deleted                    
                FROM item AS I
                LEFT JOIN user AS U ON U.id = I.created_by
                LEFT JOIN user AS U1 ON U1.id = I.modified_by
                WHERE I.date_time_deleted IS NULL
                AND I.id = '{0}'",
                database.escapeString(id)
            );

            database databaseGetItem = new database();
            var item = databaseGetItem.getData(query);
            if (item == null)
            {
                return result;
            }

            while (item.Read())
            {
                result[0] = item["id"].ToString();
                result[1] = item["barcode"].ToString();
                result[2] = item["name"].ToString();
                result[3] = item["description"].ToString();
                result[4] = item["price"].ToString();
                result[5] = item["status"].ToString();
                result[6] = item["created_by"].ToString();
                result[7] = item["date_time_created"].ToString();
                result[8] = item["modified_by"].ToString();
                result[9] = item["date_time_modified"].ToString();
                result[10] = item["date_time_deleted"].ToString();
                result[11] = item["created_by_username"].ToString();
                result[12] = item["modified_by_username"].ToString();
            }

            databaseGetItem.closeConnection();

            return result;
        }

        /// <summary>
        /// Get Assigned Sites
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// List<string>[]: [0] - id, [1] - item_id, [2] - site_id, [3] - inventory, [4] - status
        /// </returns>
        public List<string>[] getSitesAssignedById(string id)
        {
            List<string>[] result = new List<string>[5];

            result[0] = new List<string>();
            result[1] = new List<string>();
            result[2] = new List<string>();
            result[3] = new List<string>();
            result[4] = new List<string>();

            string query = string.Format(
                "SELECT id, item_id, site_id, inventory, status FROM item_site WHERE status = 1 AND item_id = '{0}'",
                database.escapeString(id)
            );

            database databaseSites = new database();
            var sites = databaseSites.getData(query);
            if (sites == null)
            {
                return result;
            }

            while (sites.Read())
            {
                result[0].Add(sites["id"].ToString());
                result[1].Add(sites["item_id"].ToString());
                result[2].Add(sites["site_id"].ToString());
                result[3].Add(sites["inventory"].ToString());
                result[4].Add(sites["status"].ToString());
            }

            databaseSites.closeConnection();

            return result;
        }

        public bool isBarcodeExist(string barcode, string id = "")
        {
            this.database = new database();

            string excludeId = "";
            if (id != "")
            {
                excludeId = " AND `id` <> '" + database.escapeString(id) + "'";
            }

            string query = string.Format(
                "SELECT COUNT(`id`) AS count FROM item WHERE `date_time_deleted` IS NULL AND `barcode` = '{0}' {1} LIMIT 1",
                database.escapeString(barcode),
                excludeId
            );

            var data = database.getData(query);
            if (data == null)
            {
                return false;
            }

            int count = 0;
            while (data.Read())
            {
                count = int.Parse(data["count"].ToString());
            }

            database.closeConnection();

            return count > 0;
        }

        public void insert(string barcode, string name, string description, string status, string price, List<string> assignedSites)
        {
            database database = new database();
            string query = string.Format(
                "INSERT INTO item (`barcode`, `name`, `description`, `price`, `status`, `created_by`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', {5})",
                database.escapeString(barcode),
                database.escapeString(name),
                database.escapeString(description),
                database.escapeString(price),
                database.escapeString(status),
                database.escapeString(Properties.Settings.Default.user_id)
            );
            database.execute(query);

            if (assignedSites.Count < 1)
            {
                return;
            }

            string id = database.getLastInsertedId();

            database databaseSites = new database();

            string insertValues = "";
            for (int i = 0; i < assignedSites.Count; i++)
            {
                insertValues += string.Format(",('{0}', '{1}', 1)", database.escapeString(id), database.escapeString(assignedSites[i]));
            }

            insertValues = insertValues.Remove(0, 1);
            databaseSites.execute("INSERT INTO item_site (`item_id`, `site_id`, `status`) VALUES " + insertValues + " ON DUPLICATE KEY UPDATE `status` = 1");
        }

        public void update(string id, string barcode, string name, string description, string status, string price, List<string> assignedSites)
        {
            database databaseUpdate = new database();

            string query = string.Format(
                @"UPDATE item SET 
                    `barcode` = '{0}',
                    `name` = '{1}',
                    `description` = '{2}',
                    `price` = '{3}',
                    `status` = '{4}',
                    `modified_by` = {5},
                    `date_time_modified` = NOW()
                WHERE `id` = '{6}'",
                database.escapeString(barcode),
                database.escapeString(name),
                database.escapeString(description),
                database.escapeString(price),
                database.escapeString(status),
                database.escapeString(Properties.Settings.Default.user_id),
                database.escapeString(id)
            );

            databaseUpdate.execute(query);

            database databaseUnassign = new database();
            string unassignQuery = string.Format("UPDATE item_site SET `status` = 0 WHERE `item_id` = '{0}'", database.escapeString(id));
            databaseUnassign.execute(unassignQuery);

            if (assignedSites.Count < 1)
            {
                return;
            }

            string insertValues = "";
            for (int i = 0; i < assignedSites.Count; i++)
            {
                insertValues += string.Format(",('{0}', '{1}', 1)", database.escapeString(id), database.escapeString(assignedSites[i]));
            }

            insertValues = insertValues.Remove(0, 1);
            database databaseUpdateSitesAssigned = new database();
            databaseUpdateSitesAssigned.execute("INSERT INTO item_site (`item_id`, `site_id`, `status`) VALUES " + insertValues + " ON DUPLICATE KEY UPDATE `status` = 1");
        }

        public List<string>[] list(string siteId, string status, string search, int page)
        { 
            List<string>[] items = new List<string>[14];
            items[0] = new List<string>(); // id
            items[1] = new List<string>(); // barcode
            items[2] = new List<string>(); // name
            items[3] = new List<string>(); // description
            items[4] = new List<string>(); // price
            items[5] = new List<string>(); // status
            items[6] = new List<string>(); // created_by
            items[7] = new List<string>(); // date_time_created
            items[8] = new List<string>(); // modified_by
            items[9] = new List<string>(); // date_time_modified
            items[10] = new List<string>(); // date_time_deleted
            items[11] = new List<string>(); // inventory
            items[12] = new List<string>(); // price_display
            items[13] = new List<string>(); // is_assigned

            string searchFilter = "";
            if (search.Trim() != "")
            {
                searchFilter = string.Format("AND (I.barcode LIKE '%{0}%' OR I.name LIKE '%{0}%')", database.escapeString(search));
            }

            string siteFilter = "";
            if (siteId.Trim() != "")
            {
                siteFilter = string.Format("AND II.site_id = '{0}'", database.escapeString(siteId));
            }

            string statusFilter = "";
            if (status.Trim() != "")
            {
                statusFilter = string.Format("AND I.status = '{0}'", database.escapeString(status));
            }

            string queryCount = string.Format(
               @"SELECT COUNT(A.id) AS count FROM (
                    SELECT
	                    I.id         
                    FROM item AS I
                    LEFT JOIN item_site AS II ON II.item_id = I.id
                    WHERE I.date_time_deleted IS NULL
                    {0}
                    {1}
                    {2}
                    GROUP BY I.id
               ) AS A",
               statusFilter,
               siteFilter,
               searchFilter
            );
            database databaseCount = new database();
            var dataCount = databaseCount.getData(queryCount);
            if (dataCount == null)
            {
                return items;
            }

            while (dataCount.Read())
            {
                this.rowCount = int.Parse(dataCount["count"].ToString());
            }
            databaseCount.closeConnection();

            this.currentPage = page;
            int offSet = (this.currentPage * this.rowsPerPage) - this.rowsPerPage;
            double pageCompute = double.Parse(this.rowCount.ToString()) / double.Parse(this.rowsPerPage.ToString());
            this.maxPage = (int)Math.Ceiling(pageCompute);

            string query = string.Format(
                @"SELECT
	                I.`id`,
                    I.`barcode`,
                    I.`name`,
                    I.`description`,
                    I.`price`,
                    I.`status`,
                    I.`created_by`,
                    I.`date_time_created`,
                    I.`modified_by`,
                    I.`date_time_modified`,
                    I.`date_time_deleted`,
                    ROUND(COALESCE(SUM(IF(II.`status` = 1, II.inventory, 0)), 0), 2) AS inventory,
                    IF (II.inventory IS NOT NULL, 1, 0) AS is_assigned,
                    ROUND(I.price, 2) AS price_display
                FROM item AS I
                LEFT JOIN item_site AS II ON II.item_id = I.id
                WHERE I.date_time_deleted IS NULL
                {0}
                {1}
                {2}
                GROUP BY I.id
                ORDER BY I.id ASC
                LIMIT {3}, {4}",
                statusFilter,
                siteFilter,
                searchFilter,
                offSet.ToString(),
                this.rowsPerPage.ToString()
            );

            database databaseRows = new database();
            var data = databaseRows.getData(query);
            if (data == null)
            {
                return items;
            }

            while (data.Read())
            {
                items[0].Add(data["id"].ToString());
                items[1].Add(data["barcode"].ToString());
                items[2].Add(data["name"].ToString());
                items[3].Add(data["description"].ToString());
                items[4].Add(data["price"].ToString());
                items[5].Add(data["status"].ToString());
                items[6].Add(data["created_by"].ToString());
                items[7].Add(data["date_time_created"].ToString());
                items[8].Add(data["modified_by"].ToString());
                items[9].Add(data["date_time_modified"].ToString());
                items[10].Add(data["date_time_deleted"].ToString());
                items[11].Add(data["inventory"].ToString());
                items[12].Add(data["price_display"].ToString());
                items[13].Add(data["is_assigned"].ToString());
            }

            databaseRows.closeConnection();

            return items;
        }

        public void delete(string id)
        {
            database databaseUnassign = new database();
            string unassignQuery = string.Format(
                "UPDATE `item` SET `modified_by` = '{0}', `date_time_deleted` = NOW() WHERE `id` = '{1}'",
                database.escapeString(Properties.Settings.Default.user_id),
                database.escapeString(id)
            );
            databaseUnassign.execute(unassignQuery);
        }

        public int[] paginationData()
        {
            int[] data = new int[4];

            data[0] = this.rowCount;
            data[1] = this.currentPage;
            data[2] = this.rowsPerPage;
            data[3] = this.maxPage;

            return data;
        }

        public string getOutOfStockItemsCount()
        {
            string query = @"SELECT COUNT(*) AS `count` FROM (
	                            SELECT I.id FROM item AS I
	                            INNER JOIN item_site AS II ON II.item_id = I.id AND II.inventory <= 0
	                            WHERE I.date_time_deleted IS NULL AND I.status = 1
	                            GROUP BY I.id
                            ) AS A";

            string[] fields = new string[1];
            fields[0] = "count";

            List<string>[] data = this.getDataList(query, fields);
            int result = int.Parse(data[0][0]);

            return result.ToString();
        }

        public string getAllTotalInventory()
        {
            string query = @"SELECT COALESCE(SUM(II.inventory), 0) AS `count` FROM item AS I
                            LEFT JOIN item_site AS II ON II.item_id = I.id
                            WHERE I.date_time_deleted IS NULL AND I.status = 1";

            string[] fields = new string[1];
            fields[0] = "count";

            List<string>[] data = this.getDataList(query, fields);
            float result = float.Parse(data[0][0]) + 0;

            return result.ToString();
        }
    }
}
