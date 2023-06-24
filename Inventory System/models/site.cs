using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System.models
{
    class site: model
    {
        database database;
        List<string>[] list;

        public site()
        {          
        }

        /// <summary>
        /// Get All Active Sites
        /// </summary>
        /// <returns>
        /// List<string>[]: [0] - id; [1] - name; [2] - address; [3] - details; [4] - status; [5] - created_by; [6] - date_time_created; [7] - modified_by; [8] - date_time_modifed; [9] - date_time_deleted
        /// </returns>
        public List<string>[] getAllActiveSites()
        {
            database = new database();

            this.list = new List<string>[10];
            this.list[0] = new List<string>(); // id
            this.list[1] = new List<string>(); // name
            this.list[2] = new List<string>(); // address
            this.list[3] = new List<string>(); // details
            this.list[4] = new List<string>(); // status
            this.list[5] = new List<string>(); // created_by
            this.list[6] = new List<string>(); // date_time_created
            this.list[7] = new List<string>(); // modified_by
            this.list[8] = new List<string>(); // date_time_modifed
            this.list[9] = new List<string>(); // date_time_deleted

            this.list[0].Clear();
            this.list[1].Clear();
            this.list[2].Clear();
            this.list[3].Clear();
            this.list[4].Clear();
            this.list[5].Clear();
            this.list[6].Clear();
            this.list[7].Clear();
            this.list[8].Clear();
            this.list[9].Clear();

            var data = database.getData("SELECT * FROM site WHERE `status` = 1 AND `date_time_deleted` IS NULL");
            if (data == null)
            {
                return this.list;
            }

            while (data.Read())
            {
                this.list[0].Add(data["id"].ToString());
                this.list[1].Add(data["name"].ToString());
                this.list[2].Add(data["address"].ToString());
                this.list[3].Add(data["details"].ToString());
                this.list[4].Add(data["status"].ToString());
                this.list[5].Add(data["created_by"].ToString());
                this.list[6].Add(data["date_time_created"].ToString());
                this.list[7].Add(data["modified_by"].ToString());
                this.list[8].Add(data["date_time_modifed"].ToString());
                this.list[9].Add(data["date_time_deleted"].ToString());
            }

            database.closeConnection();

            return this.list;
        }

        public string getActiveSitesCount()
        {
            string query = "SELECT COUNT(*) AS `count` FROM `site` WHERE `date_time_deleted` IS NULL AND `status` = 1";

            string[] fields = new string[1];
            fields[0] = "count";

            List<string>[] data = this.getDataList(query, fields);
            int result = int.Parse(data[0][0]);

            return result.ToString();
        }
    }
}
