using PersonPresentation_BL;
using PersonPresentation_DL.Model;
using PersonPresentation_DL.Repository;
using System;
using System.Windows.Forms;


namespace PersonPresentation.UI
{
    public partial class PersonManager : Form
    {
        private PersonRepository _persons = new PersonRepository();
        private PersonPresentationDataSet _dataSetSource = new PersonPresentationDataSet();
        private bool _isNew = false;

        private void SubscribeToEvent()
        {
            AddPersonButton.Click += new EventHandler(this.AddPerson_Click);
            EditButton.Click += new EventHandler(this.Edit_Click);
            DeleteButton.Click += new EventHandler(this.Delete_Click);
            CancelButton.Click += new EventHandler(this.CancelTab_Click);
            SaveButton.Click += new EventHandler(this.Save_Click);
        }

        public PersonManager()
        {
            InitializeComponent();
            SubscribeToEvent();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            _isNew = false;
            CnpTextBox.Enabled = false;
            TabManager.SelectedIndex = 1;
            
        }

        private void AddPerson_Click(object sender, EventArgs e)
        {
            _dataSetSource.Persons.NewRowFromUI();
            _isNew = true;
            personsDataTableBindingSource.Position = PersonsGrid.Rows.Count - 2;
            TabManager.SelectedIndex = 1;
            CnpTextBox.Enabled = true;

        }

        private void Delete_Click(object sender, EventArgs e)
        {

            string cnp = CnpTextBox.Text;
            _persons.Delete(cnp);
            _dataSetSource.Persons.Populate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            _dataSetSource.Persons.Populate();
            personsDataTableBindingSource.DataSource = _dataSetSource.Persons;
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void CancelTab_Click(object sender, EventArgs e)
        {
            TabManager.SelectedIndex = 0;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Person _person = new Person();
            _person.CNP = CnpTextBox.Text;
            _person.FirstName = FirstNameTextBox.Text;
            _person.LastName = LastNameTextBox.Text;
            _person.Birth = DateTime.Parse(BirthTextBox.Text);
            _person.Age = Int32.Parse(AgeTextBox.Text);
            _person.Sex = MRadioButton.Checked;
            if(_isNew)
                _persons.Insert(_person);
            else
                _persons.UpdateById(_person);
            _dataSetSource.Persons.Populate();
            TabManager.SelectedIndex = 0;
        }


        private void NewPersonSave(object sender, EventArgs e)
        {
            Person _person = new Person();

            _person.CNP = CnpTextBox.Text;
            _person.FirstName = FirstNameTextBox.Text;
            _person.LastName = LastNameTextBox.Text;
            _person.Birth = DateTime.Parse(BirthTextBox.Text);
            _person.Age = Int32.Parse(AgeTextBox.Text);
            _person.Sex = MRadioButton.Checked;
            _persons.Insert(_person);
            _persons.UpdateById(_person);
            _dataSetSource.Persons.Populate();
            TabManager.SelectedIndex = 0;
        }

    }

}
