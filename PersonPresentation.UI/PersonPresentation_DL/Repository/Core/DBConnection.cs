using MySql.Data.MySqlClient;
using System;

namespace PersonPresentation_DL.Repository.Core
{
    public class DBConnection
    {
        private DBConnection()
        {
        }

        private MySqlConnection connection = null;
        public MySqlConnection Connection
        {
            get { return connection; }
        }

        private static DBConnection _instance = null;
        public static DBConnection Instance()
        {
            if (_instance == null)
                _instance = new DBConnection();
            return _instance;
        }

        public bool IsConnect()
        {
            if (Connection == null)
            {
                string connstring = string.Format("Server=localhost; database=personpresentation_db; UID=root; password=root");
                connection = new MySqlConnection(connstring);
                connection.Open();
            }
            return true;
        }

        public void Close()
        {
            connection.Close();
        }
    }
}
