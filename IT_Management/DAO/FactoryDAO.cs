using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT_Management.DTO;

namespace IT_Management.DAO
{
    public class FactoryDAO
    {
        #region Inital
        private static FactoryDAO instance;
        public static FactoryDAO Instance
        {
            get { if (instance == null) instance = new FactoryDAO(); return FactoryDAO.instance; }
            private set { FactoryDAO.instance = value; }
        }

        private FactoryDAO() { }
        #endregion

        #region Get List Factory
        public List<Factory> GetListFactory()
        {
            List<Factory> locationList = new List<Factory>();
            string query = "Select ft.Id, lc.NameLocation, ft.NameFactory,ft.CreateBy,ft.CreateDate from Factorys ft inner join Locations lc on ft.IdLocation = lc.Id;";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Factory cust = new Factory(item);
                locationList.Add(cust);
            }

            return locationList;
        }
        #endregion

        #region Create New Factory

        public int CreateNewFactory(string idLocation, string nameFactory)
        {
            var id = Guid.NewGuid().ToString();
            var createDate = DateTime.Now;
            var query = string.Format("insert into Factorys(Id, IdLocation, NameFactory, CreateDate) values('{0}','{1}', N'{2}','{3}')",id,idLocation,nameFactory,createDate);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        #endregion

        #region Update Factory

        public int UpdateFactory(string id, string idLocation, string nameFactory)
        {
            var updateDate = DateTime.Now;
            var query = string.Format(
                "Update Factorys set IdLocation = N'{0}', NameFactory = N'{1}', UpdateDate = '{2}' where Id = '{3}'",
                idLocation, nameFactory, updateDate, id);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        #endregion
    }
}
