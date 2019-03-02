using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Management.DTO
{
    public class Part
    {
        public Part(string id, string partName, string factoryName, string locationName, string createBy, DateTime createDate)
        {
            this.Id = id;
            this.PartName = partName;
            this.LocationName = locationName;
            this.FactoryName = factoryName;
            this.CreateBy = createBy;
            this.CreateDate = createDate;
        }

        public Part(DataRow row)
        {
            this.Id = row["Id"].ToString();
            this.PartName = row["NamePart"].ToString();
            this.LocationName = row["NameLocation"].ToString();
            this.FactoryName = row["NameFactory"].ToString();
            this.CreateBy = row["CreateBy"].ToString();
            this.CreateDate = (DateTime)row["CreateDate"];
        }

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string partName;

        public string PartName
        {
            get { return partName; }
            set { partName = value; }
        }

        private string locationName;

        public string LocationName
        {
            get { return locationName; }
            set { locationName = value; }
        }

        private string factoryName;

        public string FactoryName
        {
            get { return factoryName; }
            set { factoryName = value; }
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
