using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT_Management.DTO;

namespace IT_Management.DAO
{
    public class PartDAO
    {
        #region Inital
        private static PartDAO instance;
        public static PartDAO Instance
        {
            get { if (instance == null) instance = new PartDAO(); return PartDAO.instance; }
            private set { PartDAO.instance = value; }
        }

        private PartDAO() { }
        #endregion

        #region Get List Part

        public List<Part> GetListPart()
        {
            List<Part> partList = new List<Part>();
            string query = "Select p.Id,p.NamePart, ft.NameFactory, lc.NameLocation, p.CreateBy, p.CreateDate ";
            query += "from Parts p inner join Factorys ft on p.IdFactory=ft.Id\r\ninner join Locations lc on ft.IdLocation = lc.Id";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Part cust = new Part(item);
                partList.Add(cust);
            }

            return partList;
        }

        #endregion
    }
}
