using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPresentation_DL.Repository.Core
{
    public abstract class BaseRepository<T>
    {
        #region Members
        protected static string _conectionString = GetConnectionString();
        #endregion

        #region Methods
        private static string GetConnectionString()
        {
            string connstring = string.Format("Server=localhost; database=personpresentation_db; UID=root; password=root");

            return connstring;
        }

        public List<T> Read(string query)
        {
            List<T> result = new List<T>();
            using (MySqlConnection connection = new MySqlConnection(_conectionString))
            {
                try
                {
                    var cmd = new MySqlCommand(query, connection);
                    connection.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(GetModelFromReader(reader));
                        }
                    }
                }
                catch (MySqlException sqlEx)
                {
                    Console.WriteLine("There was a SQL error: {0}", sqlEx.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("There was an error: {0}", ex.Message);
                }
                finally
                {
                    connection.Dispose();
                }
            }
            return result;
        }

        public void ExecuteNonQuery(string query)
        {
            using (MySqlConnection connection = new MySqlConnection(_conectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException sqlEx)
                {
                    Console.WriteLine("There was a SQL error: {0}", sqlEx.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("There was an error: {0}", ex.Message);
                }
                finally
                {
                    connection.Dispose();
                }
            }
        }

        protected abstract T GetModelFromReader(MySqlDataReader reader);
        #endregion
    }
}