using PersonPresentation_DL.Model;
using PersonPresentation_DL.Repository;
using PersonPresentation_DL.Repository.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonPresentation.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //PersonRepository persons = new PersonRepository();
            //Person person = new Person();

            //person.CNP = "6080203448784";
            //person.FirstName = "Marica";
            //person.LastName = "Ion";
            //person.Birth = new DateTime(1990, 3, 12);
            //person.Age = 12;
            //person.Sex = false;

            //persons.Insert(person);

            //persons.UpdateById(person);

            //persons.Delete("6080203448784");

            //persons.ReadAll();
            Application.Run(new Form1());
        }
    }
}
