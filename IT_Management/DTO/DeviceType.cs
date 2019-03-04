using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Management.DTO
{
    public class DeviceType
    {

        public DeviceType(string id, string deviceTypeName, string createBy, DateTime createDate)
        {
            this.Id = id;
            this.DeviceTypeName = deviceTypeName;
            this.CreateBy = createBy;
            this.CreateDate = createDate;
            //this.UpdateBy = updateBy;
            //this.UpdateDate = updateDate;
            //this.IsDelete = isDelete;
        }

        public DeviceType(DataRow row)
        {
            this.Id = row["Id"].ToString();
            this.DeviceTypeName = row["NameDeviceType"].ToString();
            this.CreateBy = row["CreateBy"].ToString();
            this.CreateDate = (DateTime)row["CreateDate"];

        }

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string deviceTypeName;

        public string DeviceTypeName
        {
            get { return deviceTypeName; }
            set { deviceTypeName = value; }
        }

        private string locationCode;

        public string LocationCode
        {
            get { return locationCode; }
            set { locationCode = value; }
        }

        private string createBy;

        public string CreateBy
        {
            get { return createBy; }
            set { createBy = value; }
        }

        private DateTime createDate;

        public DateTime CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }
    }
}
