using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Management.DTO
{
    public class Location
    {
        public Location(string id, string locationName, string locationCode, string createBy, DateTime createDate)
        {
            this.Id = id;
            this.LocationName = locationName;
            this.LocationCode = locationCode;
            this.CreateBy = createBy;
            this.CreateDate = createDate;
            //this.UpdateBy = updateBy;
            //this.UpdateDate = updateDate;
            //this.IsDelete = isDelete;
        }

        public Location(DataRow row)
        {
            this.Id = row["Id"].ToString();
            this.LocationName = row["NameLocation"].ToString();
            this.LocationCode = row["CodeLocation"].ToString();
            this.CreateBy = row["CreateBy"].ToString();
            this.CreateDate = (DateTime)row["CreateDate"];

        }

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string locationName;

        public string LocationName
        {
            get { return locationName; }
            set { locationName = value; }
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
