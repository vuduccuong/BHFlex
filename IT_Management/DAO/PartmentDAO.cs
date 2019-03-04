using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT_Management.DTO;

namespace IT_Management.DAO
{
    public class PartmentDAO
    {
        #region Inital
        private static PartmentDAO instance;
        public static PartmentDAO Instance
        {
            get { if (instance == null) instance = new PartmentDAO(); return PartmentDAO.instance; }
            private set { PartmentDAO.instance = value; }
        }

        private PartmentDAO() { }
        #endregion

        #region Get List Partment

        public List<Partment> GetListPartment()
        {
            List<Partment> partmentList = new List<Partment>();
            string query =
                "select pm.Id,pm.NamePartment, p.NamePart,p.CreateBy,p.CreateDate, ft.NameFactory, lc.NameLocation ";
            query+=" from Partments pm  inner join Parts p on pm.IdPart = p.Id";
            query += " inner join Factorys ft on p.IdFactory = ft.Id";
            query += " inner join Locations lc on ft.IdLocation = lc.Id";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Partment cust = new Partment(item);
                partmentList.Add(cust);
            }

            return partmentList;
        }

        #endregion

        #region Create New Partment

        public int CreateNewPartment(string idPart, string namePartment)
        {
            var id = Guid.NewGuid().ToString();
            var createDate = DateTime.Now;
            var query = string.Format("insert into Partments(Id, IdPart, NamePartment, CreateDate) values('{0}','{1}', N'{2}','{3}')", id, idPart, namePartment, createDate);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        #endregion

        #region Update Partment

        public int UpdatePartment(string id, string idLocation, string idFactory, string idPart, string namePartment)
        {
            var updateDate = DateTime.Now;
            var query = string.Format(
                "Update Partments set IdLocation = N'{0}',IdFactory = N'{1}', IdPart = N'{2}', NamePartment = N'{3}', UpdateDate = '{4}' where Id = '{5}'",
                idLocation, idFactory, idPart, namePartment, updateDate, id);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        #endregion
    }
}
