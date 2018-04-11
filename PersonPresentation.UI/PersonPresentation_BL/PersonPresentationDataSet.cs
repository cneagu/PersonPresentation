using PersonPresentation_DL.Model;
using PersonPresentation_DL.Repository;
using System.Collections.Generic;
using System.Data;

namespace PersonPresentation_BL
{


    partial class PersonPresentationDataSet
    {
        partial class PersonsDataTable
        {
            public void Populate()
            {
                PersonRepository persons = new PersonRepository();
                List<Person> per = new List<Person>();
                per = persons.ReadAll();
                foreach (Person pers in per)
                {
                    PersonsRow pr = this.NewPersonsRow();
                    pr.CNP = pers.CNP;
                    pr.FirstName = pers.FirstName;
                    pr.LastName = pers.LastName;
                    pr.Birth = pers.Birth;
                    pr.Age = pers.Age;
                    pr.Sex = pers.Sex;

                    this.AddPersonsRow(pr);
                }
            }
        }
    }
}
