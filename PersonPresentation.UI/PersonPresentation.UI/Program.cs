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
            BaseRepository base1 = new BaseRepository();
            base1.nimioc();
            Application.Run(new Form1());
        }
    }
}
