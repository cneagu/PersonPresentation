using PersonPresentation_BL;
using PersonPresentation_DL.Model;
using PersonPresentation_DL.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonPresentation.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Edit(object sender, EventArgs e)
        {

        }

        private void Add(object sender, EventArgs e)
        {

        }

        private void Delete(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            //PersonPresentation persons = new PersonPresentation();


            //    bs.Add(obj);

            //dataGridView2.DataSource = bs;
            //dataGridView2.AutoGenerateColumns = true;
            PersonPresentationDataSet ds = new PersonPresentationDataSet();
            ds.Persons.Populate();

            dataGridView2.AutoGenerateColumns = true;
        }
    }
}
