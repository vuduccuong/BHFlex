using System.Data;

namespace IT_Management.DTO
{
    public class Custommer
    {
        public Custommer(string cust_id, string address, string city, string cust_type_cd, string fed_id,
            string postal_code, string state)
        {
            this.Cust_id = cust_id;
            this.Address = address;
            this.City = city;
            this.Cust_type_cd = cust_type_cd;
            this.Fed_id = fed_id;
            this.Postal_code = postal_code;
            this.State = state;
        }

        public Custommer(DataRow row)
        {
            this.Cust_id = row["cust_id"].ToString();
            this.Address = row["address"].ToString();
            this.City = row["city"].ToString();
            this.Cust_type_cd = row["cust_type_cd"].ToString();
            this.Fed_id = row["fed_id"].ToString();
            this.Postal_code = row["postal_code"].ToString();
            this.State = row["state"].ToString();
        }

        private string cust_id;

        public string Cust_id
        {
            get { return cust_id; }
            set { cust_id = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private string cust_type_cd;

        public string Cust_type_cd
        {
            get { return cust_type_cd; }
            set { cust_type_cd = value; }
        }

        private string fed_id;

        public string Fed_id
        {
            get { return fed_id; }
            set { fed_id = value; }
        }

        private string postal_code;

        public string Postal_code
        {
            get { return postal_code; }
            set { postal_code = value; }
        }

        private string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }
    }
}