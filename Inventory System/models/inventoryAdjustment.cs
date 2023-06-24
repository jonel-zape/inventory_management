using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System.models
{
    class inventoryAdjustment : model
    {
        public inventoryAdjustment()
        {

        }

        public void createAdjustments(string siteId, string notes, List<string>[] items)
        {
            if (items[0].Count < 1)
            {
                return;
            }

            database databaseInsert = new database();

            string query = string.Format(
                @"INSERT INTO transaction_inventory_adjustment (`site_id`, `notes`, `created_by`, `status`) VALUES ('{0}', '{1}', '{2}', 1)",
                database.escapeString(siteId),
                database.escapeString(notes),
                database.escapeString(Properties.Settings.Default.user_id)
            );

            if (!databaseInsert.execute(query))
            {
                return;
            }

            string transactionId = databaseInsert.getLastInsertedId();

            string values = "";
            string insertUpdateInventoryValues = "";
            for (int i = 0; i < items[0].Count; i++)
            {
                values += string.Format(
                    " UNION ALL SELECT '{0}', '{1}', 0, '{2}'",
                    transactionId,
                    database.escapeString(items[0][i]),
                    database.escapeString(items[1][i])
                );

                insertUpdateInventoryValues += string.Format(
                    ",('{0}', '{1}', 1)",
                    database.escapeString(items[0][i]),
                    database.escapeString(siteId)
                );
            }

            string insertQuery = string.Format(
                @"INSERT INTO transaction_inventory_adjustment_detail (transaction_inventory_adjustment_id, item_id, before_quantity, quantity)
                    SELECT
	                    A.transaction_inventory_adjustment_id,
                        A.item_id,
                        COALESCE(II.inventory, 0) AS before_quantity,
                        A.quantity
                    FROM (
                    SELECT
	                    NULL AS transaction_inventory_adjustment_id,
                        NULL AS item_id,
                        NULL AS before_quantity,
                        NULL quantity
                        {0}
                    ) AS A
                    LEFT JOIN item_site AS II ON II.item_id = A.item_id AND II.site_id = '{1}'
                    WHERE A.item_id IS NOT NULL
                    GROUP BY A.item_id",
                values,
                database.escapeString(siteId)
            );

            database databaseNewTransaction = new database();
            if (!databaseNewTransaction.execute(insertQuery))
            {
                return;
            }

            insertUpdateInventoryValues = insertUpdateInventoryValues.Remove(0, 1);
            database databaseUpdateSitesAssigned = new database();
            if (!databaseUpdateSitesAssigned.execute("INSERT INTO item_site (`item_id`, `site_id`, `status`) VALUES " + insertUpdateInventoryValues + " ON DUPLICATE KEY UPDATE `status` = 1"))
            {
                return;
            }

            string updateInventoryQuery = string.Format(
                @"UPDATE item_site AS II
                INNER JOIN transaction_inventory_adjustment_detail AS T ON T.item_id = II.item_id AND T.transaction_inventory_adjustment_id = '{0}'
                SET II.inventory = T.quantity
                WHERE II.site_id = {1}",
                database.escapeString(transactionId),
                database.escapeString(siteId)
            );

            database databaseUpdate = new database();
            databaseUpdate.execute(updateInventoryQuery);
        }

        public List<string>[] getById(string id)
        {
            string[] fields = new string[6];

            fields[0] = "id";
            fields[1] = "site_id";
            fields[2] = "notes";
            fields[3] = "created_by_username";
            fields[4] = "date_time_created_formatted";
            fields[5] = "site_name";

            string query = string.Format(
                @"SELECT
	                TH.id,
	                TH.site_id,
	                TH.notes,
	                COALESCE(U.username, 'Missing user from database') AS created_by_username,
	                DATE_FORMAT(TH.date_time_created, '%b %d, %Y %h:%i:%s %p') AS date_time_created_formatted,
                    COALESCE(CONCAT(S.id, ' - ', S.name), 'Missing site from database') AS site_name
                FROM transaction_inventory_adjustment TH
                LEFT JOIN user AS U ON U.id = TH.created_by
                LEFT JOIN site AS S ON S.id = TH.site_id
                WHERE TH.id = '{0}' LIMIT 1",
                database.escapeString(id)
            );

            return this.getDataList(query, fields);
        }

        public List<string>[] getItemsById(string headId)
        {
            string[] fields = new string[6];

            fields[0] = "id";
            fields[1] = "item_id";
            fields[2] = "before_quantity";
            fields[3] = "quantity";
            fields[4] = "item_barcode";
            fields[5] = "item_name";

            string query = string.Format(
                @"SELECT
	                D.id,
                    D.item_id,
                    D.before_quantity,
                    D.quantity,
                    COALESCE(I.barcode, 'Missing from database') AS item_barcode,
                    COALESCE(I.name, 'Missing from database') AS item_name
                FROM transaction_inventory_adjustment_detail AS D
                LEFT JOIN item AS I ON I.id = D.item_id
                WHERE D.transaction_inventory_adjustment_id = '{0}'
                ORDER BY D.id ASC",
                database.escapeString(headId)
            );

            return this.getDataList(query, fields);
        }

        public List<string>[] list(string siteId, string dateFrom, string dateTo, string search, int page)
        {
            string[] fields = new string[6];

            fields[0] = "id";
            fields[1] = "site_id";
            fields[2] = "notes";
            fields[3] = "created_by_username";
            fields[4] = "date_time_created_formatted";
            fields[5] = "site_name";

            string dateFilter = string.Format(
                "AND (TH.date_time_created BETWEEN '{0} 00:00:00' AND '{1} 23:59:59')",
                database.escapeString(dateFrom),
                database.escapeString(dateTo)
            );

            string siteFilter = "";
            if (siteId.Trim() != "")
            {
                siteFilter = string.Format("AND TH.`site_id` = '{0}'", database.escapeString(siteId));
            }

            string searchFilter = "";
            if (search.Trim() != "")
            {
                searchFilter = string.Format("AND (TH.id LIKE '%{0}%' OR TH.notes LIKE '%{0}%')", database.escapeString(search));
            }

            string query = string.Format(
                @"SELECT
	                TH.id,
                    TH.site_id,
                    TH.notes,
                    U.username AS created_by_username,
                    DATE_FORMAT(TH.date_time_created, '%b %d, %Y %h:%i:%s %p') AS date_time_created_formatted,
                    CONCAT(S.id, ' - ', S.name) AS site_name
                FROM transaction_inventory_adjustment TH
                LEFT JOIN user AS U ON U.id = TH.created_by
                LEFT JOIN site AS S ON S.id = TH.site_id
                WHERE TH.`status` = 1
                {0}
                {1}
                {2}
                ORDER BY TH.id DESC",
                dateFilter,
                siteFilter,
                searchFilter
            );

            return this.getDataList(query, fields, page);
        }
    }
}
