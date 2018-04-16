using PersonPresentation_DL.Model;
using PersonPresentation_DL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPresentation_BL
{
    public class PersonPresentationBusiness
    {
        #region Members
        private static PersonRepository _persons = new PersonRepository();
        #endregion
        #region Methdos
        public void Insert(PersonS person)
        {
            Person _person = new Person();
            _person.CNP = person.CNP;
            _person.FirstName = person.FirstName;
            _person.LastName = person.LastName;
            _person.Birth = person.Birth;
            _person.Age = person.Age;
            _person.Sex = person.Sex;
            _persons.Insert(_person);

        }
        public void UpdateById(PersonS person)
        {
            Person _person = new Person();
            _person.CNP = person.CNP;
            _person.FirstName = person.FirstName;
            _person.LastName = person.LastName;
            _person.Birth = person.Birth;
            _person.Age = person.Age;
            _person.Sex = person.Sex;
            _persons.UpdateById(_person);
        }
        public void Delete(string cnp)
        {
            _persons.Delete(cnp);
        }
        #endregion
    }
}
