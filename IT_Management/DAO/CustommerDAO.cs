using IT_Management.DTO;
using System.Collections.Generic;
using System.Data;

namespace IT_Management.DAO
{
    public class CustommerDAO
    {
        private static CustommerDAO instance;

        public static CustommerDAO Instance
        {
            get { if (instance == null) instance = new CustommerDAO(); return CustommerDAO.instance; }
            private set { CustommerDAO.instance = value; }
        }

        private CustommerDAO()
        {
        }

        public List<Custommer> GetListCustommer()
        {
            List<Custommer> custommerList = new List<Custommer>();
            string query = "Select * from Customer";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Custommer cust = new Custommer(item);
                custommerList.Add(cust);
            }

            return custommerList;
        }
    }
}