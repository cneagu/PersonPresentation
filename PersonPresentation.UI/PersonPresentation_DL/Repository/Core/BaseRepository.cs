using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPresentation_DL.Repository.Core
{
    public static class BaseRepository
    {

        public static void ReadAll()
        {
            DBConnection dbCon = DBConnection.Instance();

            if (dbCon.IsConnect())
            {
                string query = "SELECT * FROM  SYSDATE()";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string someStringFromColumnZero = reader.GetString(0);
                }
                dbCon.Close();
            }
        }

        public static void ReadByID()
        {
            DBConnection dbCon = DBConnection.Instance();

            if (dbCon.IsConnect())
            {
                string query = "SELECT SYSDATE()";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string someStringFromColumnZero = reader.GetString(0);
                    string someStringFromColumnOne = reader.GetString(1);
                    Console.WriteLine(someStringFromColumnZero + "," + someStringFromColumnOne);
                }
                dbCon.Close();
            }
        }
    }
}
