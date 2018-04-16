using PersonPresentation_BL;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace PersonPresentation.UI
{
    public partial class PersonManager : Form
    {
        private PersonPresentationBusiness _persons = new PersonPresentationBusiness();
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

            var objct = (System.Data.DataRowView)personsDataTableBindingSource.Current;
            PersonPresentationDataSet.PersonsRow personRow = (PersonPresentationDataSet.PersonsRow)objct.Row;
            string sex = personRow.Sex;
            if (sex == "M")
                MRadioButton.Checked = true;
            else
                FRadioButton.Checked = true;
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
            var result = MessageBox.Show("Are you sure?", "Confirm",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                var objct = (System.Data.DataRowView)personsDataTableBindingSource.Current;
                PersonPresentationDataSet.PersonsRow personRow = (PersonPresentationDataSet.PersonsRow)objct.Row;
                _persons.Delete(personRow.CNP);

            }
            _dataSetSource.Persons.Populate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _dataSetSource.Persons.Populate();
            personsDataTableBindingSource.DataSource = _dataSetSource.Persons;
            PersonsGrid.ReadOnly = true;
        }

        private void CancelTab_Click(object sender, EventArgs e)
        {
            TabManager.SelectedIndex = 0;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (CnpTextBox.Text == "" || !Regex.IsMatch(CnpTextBox.Text, @"^[0-9]"))
            {
                CnpErrorProvider.SetError(CnpTextBox, "Cnp Invalid!");
            }
            else if(FirstNameTextBox.Text == "" || !Regex.IsMatch(FirstNameTextBox.Text, "^[a-zA-Z]+$"))
            {
                FirstNameErrorProvider.SetError(FirstNameTextBox, "FirstName Invalid!");
            }
            else if (LastNameTextBox.Text == "" || !Regex.IsMatch(LastNameTextBox.Text, "^[a-zA-Z]+$"))
            {
                LastNameErrorProvider.SetError(LastNameTextBox, "LastName Invalid!");
            } 
            else if (AgeTextBox.Text == "" || !Regex.IsMatch(AgeTextBox.Text, @"^[0-9]")) //To compare Value of nowDateTime - selected DateTime with age
            {
                AgeErrorProvider.SetError(AgeTextBox, "Age Invalid!");
            }
            else
            {
                CnpErrorProvider.SetError(CnpTextBox, "");
                FirstNameErrorProvider.SetError(FirstNameTextBox, "");
                LastNameErrorProvider.SetError(LastNameTextBox, "");
                AgeErrorProvider.SetError(AgeTextBox, "");

                PersonS _person = new PersonS();
                _person.CNP = CnpTextBox.Text;
                _person.FirstName = FirstNameTextBox.Text;
                _person.LastName = LastNameTextBox.Text;
                _person.Birth = DateTime.Parse(birthTimePicker.Text);
                _person.Age = Int32.Parse(AgeTextBox.Text);
                if (MRadioButton.Checked)
                    _person.Sex = "M";
                else
                    _person.Sex = "F";
                if (_isNew)
                    _persons.Insert(_person);
                else
                    _persons.UpdateById(_person);
                _dataSetSource.Persons.Populate();
                TabManager.SelectedIndex = 0;
            }
        }


        private void NewPersonSave(object sender, EventArgs e)
        {
            PersonS _person = new PersonS();

            _person.CNP = CnpTextBox.Text;
            _person.FirstName = FirstNameTextBox.Text;
            _person.LastName = LastNameTextBox.Text;
            _person.Birth = DateTime.Parse(birthTimePicker.Text);
            _person.Age = Int32.Parse(AgeTextBox.Text);
            if (MRadioButton.Checked)
                _person.Sex = "M";
            else
                _person.Sex = "F";
            _persons.Insert(_person);
            _persons.UpdateById(_person);
            _dataSetSource.Persons.Populate();
            TabManager.SelectedIndex = 0;
        }
    }
}