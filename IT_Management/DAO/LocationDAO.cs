using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT_Management.DTO;

namespace IT_Management.DAO
{
    public class LocationDAO
    {
        #region Inital
        private static LocationDAO instance;
        public static LocationDAO Instance
        {
            get { if (instance == null) instance = new LocationDAO(); return LocationDAO.instance; }
            private set { LocationDAO.instance = value; }
        }

        private LocationDAO() { }
        #endregion

        #region Get List Location
        public List<Location> GetListCustommer()
        {
            List<Location> locationList = new List<Location>();
            string query = "select Id, NameLocation, CodeLocation, CreateBy, CreateDate from Locations";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Location cust = new Location(item);
                locationList.Add(cust);
            }

            return locationList;
        }
        #endregion

        #region Create New Location

        public int CreateNewLocation(string nameLocation, string codeLocation)
        {
            var id = Guid.NewGuid().ToString();
            var createDate = DateTime.Now;
            var query = string.Format("Insert into Locations(Id, NameLocation, CodeLocation, CreateDate) values ('{0}',N'{1}', '{2}', '{3}')", id,nameLocation, codeLocation, createDate);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        #endregion

        #region Update Location

        public int UpdateLocation(string id,string nameLocation, string codeLocation)
        {
            var updateDate = DateTime.Now;
            var query = string.Format(
                "Update Locations set NameLocation = N'{0}', CodeLocation = N'{1}', UpdateDate = '{2}' where Id = '{3}'",
                nameLocation, codeLocation, updateDate, id);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        

        #endregion
    }
}
