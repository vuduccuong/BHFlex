using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace IT_Management.DAO
{
    public class DataProvider
    {
        private static DataProvider _instance;

        public static DataProvider Instance
        {
            get { if (_instance == null) _instance = new DataProvider(); return DataProvider._instance; }
            private set => DataProvider._instance = value;
        }

        private DataProvider()
        {
        }

        private string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=BHFlex;Integrated Security=True";
        // "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                                      // + "localhost" + ")(PORT = " + "1521" + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                                      // + "db12c" + ")));Password=" + "D0ila" + "ip" + "ass" + ";User ID=" + "C##u" + "on" + "gvd";

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);
                connection.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            var data = 0;

            using (var connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                var command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data;

            using (var connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                var command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }
    }
}