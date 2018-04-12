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
            textBox1.Enabled = false;
            tabControl1.SelectedIndex = 1;
            button6.Visible = false;
            button4.Visible = true;
        }

        private void Add(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            radioButton1.Checked = true;
            textBox1.Enabled = true;
            button6.Visible = true;
            button4.Visible = false;
        }

        private void Delete(object sender, EventArgs e)
        {
            PersonRepository persons = new PersonRepository();
            string cnp = textBox1.Text;
            persons.Delete(cnp);

            PersonPresentationDataSet ds = new PersonPresentationDataSet();
            ds.Persons.Populate();
            dataGridView2.DataSource = "";
            dataGridView2.DataSource = ds.Persons;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            //PersonPresentation persons = new PersonPresentation();


            //    bs.Add(obj);

            //dataGridView2.DataSource = bs;
            //dataGridView2.AutoGenerateColumns = true;
            PersonPresentationDataSet ds = new PersonPresentationDataSet();
            ds.Persons.Populate();
            personsDataTableBindingSource.DataSource = ds.Persons;
            //dataGridView2.DataSource = ds.Persons;
            //dataGridView2.AutoGenerateColumns = true;

        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dataGridView2.SelectedCells[2].Value.ToString());
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox1.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            //radioButton1
            if (dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString().Equals("True") )
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton2.Checked = false;
                radioButton1.Checked = true;
            }

            //string str = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString() +
            //        dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString() +
            //        dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString() +
            //        dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString() +
            //        dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString() +
            //        dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            //    MessageBox.Show(str);

        }

        private void cancelTab(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PersonRepository persons = new PersonRepository();
            Person person = new Person();

            person.CNP = textBox1.Text;
            person.FirstName = textBox2.Text;
            person.LastName = textBox3.Text;
            person.Birth = DateTime.Parse(textBox4.Text);
            person.Age = Int32.Parse(textBox5.Text);
            person.Sex = radioButton1.Checked;
            //persons.Insert(person);

            persons.UpdateById(person);


            PersonPresentationDataSet ds = new PersonPresentationDataSet();
            ds.Persons.Populate();
            dataGridView2.DataSource = "";
            dataGridView2.DataSource = ds.Persons;
            tabControl1.SelectedIndex = 0;

        }

        private void AddNew(object sender, EventArgs e)
        {
            PersonRepository persons = new PersonRepository();
            Person person = new Person();

            person.CNP = textBox1.Text;
            person.FirstName = textBox2.Text;
            person.LastName = textBox3.Text;
            person.Birth = DateTime.Parse(textBox4.Text);
            person.Age = Int32.Parse(textBox5.Text);
            person.Sex = radioButton1.Checked;
            persons.Insert(person);
            PersonPresentationDataSet ds = new PersonPresentationDataSet();
            ds.Persons.Populate();
            dataGridView2.DataSource = "";
            dataGridView2.DataSource = ds.Persons;
            tabControl1.SelectedIndex = 0;
        }
    }
}
