using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System.models
{
    class model
    {
        protected int rowCount;
        protected int rowsPerPage;
        protected int currentPage;
        protected int maxPage;

        public model()
        {
            this.rowCount = 0;
            this.rowsPerPage = 50;
            this.currentPage = 1;
            this.maxPage = 0;
        }

        protected List<string>[] getDataList(string query, string[] fields, int page = 0)
        {
            List<string>[] items = new List<string>[fields.Length];

            for (int i = 0; i < fields.Length; i++)
            {
                items[i] = new List<string>();
            }

            if (page > 0)
            {
                string queryCount = string.Format(
                    @"SELECT COUNT(*) AS count FROM (
                        {0}
                    ) AS A",
                    query
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
            }

            this.currentPage = page;
            int offSet = (this.currentPage * this.rowsPerPage) - this.rowsPerPage;
            double pageCompute = double.Parse(this.rowCount.ToString()) / double.Parse(this.rowsPerPage.ToString());
            this.maxPage = (int)Math.Ceiling(pageCompute);

            string queryWithLimit = string.Format(
                @"{0} LIMIT {1}, {2}",
                query,
                offSet.ToString(),
                this.rowsPerPage.ToString()
            );

            if (page == 0)
            {
                queryWithLimit = query;
            }

            database databaseRows = new database();
            var data = databaseRows.getData(queryWithLimit);
            if (data == null)
            {
                return items;
            }

            while (data.Read())
            {
                for (int i = 0; i < fields.Length; i++)
                {
                    items[i].Add(data[fields[i]].ToString());
                }
            }

            databaseRows.closeConnection();

            return items;
        }

        public int getRowCount()
        {
            return this.rowCount;
        }

        public int getCurrentPage()
        {
            return this.currentPage;
        }

        public int getRowsPerPage()
        {
            return this.rowsPerPage;
        }

        public int getMaxPage()
        {
            return this.maxPage;
        }
    }
}
