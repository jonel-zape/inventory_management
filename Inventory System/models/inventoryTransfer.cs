using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System.models
{
    class inventoryTransfer: model
    {
        public void createTransfer(string siteIdFrom, string siteIdTo, string notes, List<string>[] items)
        {
            if (items[0].Count < 1)
            {
                return;
            }

            database databaseInsert = new database();

            string query = string.Format(
                @"INSERT INTO transaction_inventory_transfer (`site_from`, `site_to`, `notes`, `created_by`, `status`) VALUES ('{0}', '{1}', '{2}', '{3}', 1)",
                database.escapeString(siteIdFrom),
                database.escapeString(siteIdTo),
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
                    " UNION ALL SELECT '{0}', '{1}', '{2}'",
                    transactionId,
                    database.escapeString(items[0][i]),
                    database.escapeString(items[1][i])
                );

                insertUpdateInventoryValues += string.Format(
                    ",('{0}', '{1}', 1)",
                    database.escapeString(items[0][i]),
                    database.escapeString(siteIdTo)
                );
            }

            string insertQuery = string.Format(
                @"INSERT INTO transaction_inventory_transfer_detail (transaction_inventory_transfer_id, item_id, quantity)
                    SELECT
	                    A.transaction_inventory_transfer_id,
                        A.item_id,
                        A.quantity
                    FROM (
                    SELECT
	                    NULL AS transaction_inventory_transfer_id,
                        NULL AS item_id,
                        NULL quantity
                        {0}
                    ) AS A
                    WHERE A.item_id IS NOT NULL
                    GROUP BY A.item_id",
                values
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

            string updateInventoryDeductQuery = string.Format(
                @"UPDATE item_site AS II
                INNER JOIN transaction_inventory_transfer_detail AS T ON T.item_id = II.item_id AND T.transaction_inventory_transfer_id = '{0}'
                SET II.inventory = II.inventory - T.quantity
                WHERE II.site_id = {1}",
                database.escapeString(transactionId),
                database.escapeString(siteIdFrom)
            );

            database databaseUpdateDeduct = new database();
            if (!databaseUpdateDeduct.execute(updateInventoryDeductQuery))
            {
                return;
            }

            string updateInventoryAddQuery = string.Format(
                @"UPDATE item_site AS II
                INNER JOIN transaction_inventory_transfer_detail AS T ON T.item_id = II.item_id AND T.transaction_inventory_transfer_id = '{0}'
                SET II.inventory = II.inventory + T.quantity
                WHERE II.site_id = {1}",
                database.escapeString(transactionId),
                database.escapeString(siteIdTo)
            );

            database databaseAddUpdate = new database();
            databaseAddUpdate.execute(updateInventoryAddQuery);
        }

        public List<string>[] getById(string id)
        {
            string[] fields = new string[7];

            fields[0] = "id";
            fields[1] = "site_from";
            fields[1] = "site_to";
            fields[2] = "notes";
            fields[3] = "created_by_username";
            fields[4] = "date_time_created_formatted";
            fields[5] = "site_from_name";
            fields[6] = "site_to_name";

            string query = string.Format(
                @"SELECT
	                TH.id,
                    TH.site_from,
                    TH.site_to,
                    TH.notes,
                    U.username AS created_by_username,
                    DATE_FORMAT(TH.date_time_created, '%b %d, %Y %h:%i:%s %p') AS date_time_created_formatted,
                    CONCAT(SF.id, ' - ', SF.name) AS site_from_name,
                    CONCAT(ST.id, ' - ', ST.name) AS site_to_name
                FROM transaction_inventory_transfer TH
                LEFT JOIN user AS U ON U.id = TH.created_by
                LEFT JOIN site AS SF ON SF.id = TH.site_from
                LEFT JOIN site AS ST ON ST.id = TH.site_to
                WHERE TH.id = '{0}' LIMIT 1",
                database.escapeString(id)
            );

            return this.getDataList(query, fields);
        }

        public List<string>[] getItemsById(string headId)
        {
            string[] fields = new string[5];

            fields[0] = "id";
            fields[1] = "item_id";
            fields[2] = "quantity";
            fields[3] = "item_barcode";
            fields[4] = "item_name";

            string query = string.Format(
                @"SELECT
	                D.id,
                    D.item_id,
                    D.quantity,
                    COALESCE(I.barcode, 'Missing from database') AS item_barcode,
                    COALESCE(I.name, 'Missing from database') AS item_name
                FROM transaction_inventory_transfer_detail AS D
                LEFT JOIN item AS I ON I.id = D.item_id
                WHERE D.transaction_inventory_transfer_id = '{0}'
                ORDER BY D.id ASC",
                database.escapeString(headId)
            );

            return this.getDataList(query, fields);
        }

        public List<string>[] list(string siteFromId, string siteToId, string dateFrom, string dateTo, string search, int page)
        {
            string[] fields = new string[7];

            fields[0] = "id";
            fields[1] = "site_from";
            fields[1] = "site_to";
            fields[2] = "notes";
            fields[3] = "created_by_username";
            fields[4] = "date_time_created_formatted";
            fields[5] = "site_from_name";
            fields[6] = "site_to_name";

            string dateFilter = string.Format(
                "AND (TH.date_time_created BETWEEN '{0} 00:00:00' AND '{1} 23:59:59')",
                database.escapeString(dateFrom),
                database.escapeString(dateTo)
            );

            string siteFromFilter = "";
            if (siteFromId.Trim() != "")
            {
                siteFromFilter = string.Format("AND TH.`site_from` = '{0}'", database.escapeString(siteFromId));
            }

            string siteToFilter = "";
            if (siteToId.Trim() != "")
            {
                siteToFilter = string.Format("AND TH.`site_to` = '{0}'", database.escapeString(siteToId));
            }

            string searchFilter = "";
            if (search.Trim() != "")
            {
                searchFilter = string.Format("AND (TH.id LIKE '%{0}%' OR TH.notes LIKE '%{0}%')", database.escapeString(search));
            }

            string query = string.Format(
                @"SELECT
	                TH.id,
                    TH.site_from,
                    TH.site_to,
                    TH.notes,
                    U.username AS created_by_username,
                    DATE_FORMAT(TH.date_time_created, '%b %d, %Y %h:%i:%s %p') AS date_time_created_formatted,
                    CONCAT(SF.id, ' - ', SF.name) AS site_from_name,
                    CONCAT(ST.id, ' - ', ST.name) AS site_to_name
                FROM transaction_inventory_transfer TH
                LEFT JOIN user AS U ON U.id = TH.created_by
                LEFT JOIN site AS SF ON SF.id = TH.site_from
                LEFT JOIN site AS ST ON ST.id = TH.site_to
                WHERE TH.`status` = 1
                {0}
                {1}
                {2}
                {3}
                ORDER BY TH.id DESC",
                dateFilter,
                siteFromFilter,
                siteToFilter,
                searchFilter
            );

            return this.getDataList(query, fields, page);
        }
    }
}
