using MySql.Data.MySqlClient;

namespace StudentApp.Database
{
    public class DBconnection
    {
        private static string connectionString = "server=localhost;uid=root;pwd=Mosqnjd-1;database=studentregister";

        public DBconnection()
        {
            Connection = new MySqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
            }
        }

        public MySqlConnection Connection { get; set; }


    }
}
 