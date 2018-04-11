using MySql.Data.MySqlClient;
using PersonPresentation_DL.Model;
using PersonPresentation_DL.Repository.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPresentation_DL.Repository
{
    public class PersonRepository : BaseRepository<Person>
    {
        #region Methods
        public List<Person> ReadAll()
        {
            return Read("SELECT * FROM Persons;");
        }

        public Person ReadByID(string cnp)
        {
            List<Person> person = new List<Person>();
            person = Read("SELECT * FROM Persons WHERE CNP =" + cnp + ";");
            return person[0];
        }

        public void Insert(Person person)
        {
            string query = "INSERT INTO Persons(CNP, FirstName, LastName, Birth, Age, Sex)" +
                           "VALUES('" + person.CNP + "', '" + person.FirstName + "', '" + 
                           person.LastName + "', STR_TO_DATE('" + person.Birth + "', '%m/%d/%Y %h:%i:%s %p'), " + person.Age + ", " + person.Sex + ");";
            ExecuteNonQuery(query);
        }

        public void UpdateById(Person person)
        {
            string query = "UPDATE Persons SET CNP = '" + person.CNP +
                           "', FirstName = '" + person.FirstName +
                           "', LastName = '" + person.LastName +
                           "', Birth = STR_TO_DATE('" + person.Birth + "', '%m/%d/%Y %h:%i:%s %p'), " +
                            "Age = " + person.Age + ", " +
                            "Sex = " + person.Sex +
                            " WHERE CNP = '" + person.CNP + "';"; 
            ExecuteNonQuery(query);
        }

        public void Delete(string cnp)
        {
            string query = "DELETE FROM Persons Where CNP = '" + cnp + "';";
            ExecuteNonQuery(query);
        }
    
        protected override Person GetModelFromReader(MySqlDataReader reader)
        {
            Person persons = new Person();
            persons.CNP = reader.GetString(reader.GetOrdinal("CNP"));
            persons.FirstName = reader.GetString(reader.GetOrdinal("FirstName"));
            persons.LastName = reader.GetString(reader.GetOrdinal("LastName"));
            persons.Birth = reader.GetDateTime(reader.GetOrdinal("Birth"));
            persons.Age = reader.GetInt32(reader.GetOrdinal("Age"));
            persons.Sex = reader.GetBoolean(reader.GetOrdinal("Sex"));

            return persons;
        }
            #endregion
    }
}
