using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Management.DAO
{
    public class BuydateDAO
    {
        private static BuydateDAO instance;

        public static BuydateDAO Instance
        {
            get { if (instance == null) instance = new BuydateDAO(); return BuydateDAO.instance; }
            private set { BuydateDAO.instance = value; }
        }
        private BuydateDAO()
        {
        }

        public string getBuyDate(string ip, DateTime a, string location, string codeName)
        {
            String lastIp = null;
            string[] listPara = ip.ToString().Split('.');
            lastIp += listPara[2];
            lastIp += listPara[3];

            var setBuydate = (String.Format("{0:yy/MM}", a)).Replace("-", "");

            var CodeLocation = "select CodeLocation from Locations where NameLocation ='" + location + "'";
            var getCodeLocation = DataProvider.Instance.ExecuteQuery(CodeLocation);
            string name = getCodeLocation.Rows[0][0].ToString();
            return (String.Format(name + codeName + lastIp + setBuydate));
            
        }
    }
}
