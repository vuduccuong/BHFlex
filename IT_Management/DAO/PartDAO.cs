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

        #region Get List Part By Factory

        public List<Part> GetListPartByFactory(string idFactory)
        {
            List<Part> partList = new List<Part>();
            string query =
                "select p.Id, p.NamePart,p.CreateBy,p.CreateDate, ft.NameFactory, lc.NameLocation from Parts p inner join Factorys ft on p.IdFactory = ft.Id";
            query += " inner join Locations lc on ft.IdLocation = lc.Id";
            query += " Where ft.Id = '" + idFactory.ToString() + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Part cust = new Part(item);
                partList.Add(cust);
            }

            return partList;
        }

        #endregion

        #region Create New Part

        public int CreateNewPart(string namePart, string idFactory)
        {
            var id = Guid.NewGuid().ToString();
            var createDate = DateTime.Now;
            var query = string.Format("Insert into Parts(Id, NamePart, idFactory, CreateDate) values ('{0}',N'{1}', '{2}', '{3}')", id, namePart, idFactory, createDate);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        #endregion

        #region Update Part

        public int UpdatePart(string idPart, string idFactory, string namePart)
        {
            var updateDate = DateTime.Now;
            var query = string.Format(
                "Update Parts set IdFactory = N'{0}', NamePart = N'{1}', UpdateDate = '{2}' where Id = '{3}'",
                idFactory, namePart, updateDate, idPart);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        #endregion
    }
}
