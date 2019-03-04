using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT_Management.DTO;

namespace IT_Management.DAO
{
    public class DeviceTypeDAO
    {
        #region Inital
        private static DeviceTypeDAO instance;
        public static DeviceTypeDAO Instance
        {
            get { if (instance == null) instance = new DeviceTypeDAO(); return DeviceTypeDAO.instance; }
            private set { DeviceTypeDAO.instance = value; }
        }

        private DeviceTypeDAO() { }
        #endregion

        #region Get List Device Type
        public List<DeviceType> GetListDeviceTypes()
        {
            List<DeviceType> deviceTypeList = new List<DeviceType>();
            string query = "select Id, NameDeviceType, CreateBy, CreateDate from TypeDevices";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DeviceType cust = new DeviceType(item);
                deviceTypeList.Add(cust);
            }

            return deviceTypeList;
        }
        #endregion

        #region Create New DeviceType

        public int CreateNewDeviceType(string nameDeviceType)
        {
            var id = Guid.NewGuid().ToString();
            var createDate = DateTime.Now;
            var query = string.Format("Insert into TypeDevices(Id, NameDeviceType, CreateDate) values ('{0}', N'{1}', '{2}')", id, nameDeviceType, createDate);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        #endregion

        #region Update DeviceType

        public int UpdateDeviceType(string id, string nameDeviceType)
        {
            var updateDate = DateTime.Now;
            var query = string.Format(
                "Update TypeDevices set NameDeviceType = N'{0}', UpdateDate = '{1}' where Id = '{2}'",
                nameDeviceType, updateDate, id);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }


        #endregion
    }
}
