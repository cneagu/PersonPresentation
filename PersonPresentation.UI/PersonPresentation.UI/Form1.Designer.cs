namespace PersonPresentation.UI
{
    partial class PersonManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TabManager = new System.Windows.Forms.TabControl();
            this.OverViewTab = new System.Windows.Forms.TabPage();
            this.PersonsGrid = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddPersonButton = new System.Windows.Forms.Button();
            this.DetailsTab = new System.Windows.Forms.TabPage();
            this.birthTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.FRadioButton = new System.Windows.Forms.RadioButton();
            this.MRadioButton = new System.Windows.Forms.RadioButton();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelBirth = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelCNP = new System.Windows.Forms.Label();
            this.CnpTextBox = new System.Windows.Forms.TextBox();
            this.CnpErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FirstNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.LastNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BirthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.AgeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SexErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personsDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TabManager.SuspendLayout();
            this.OverViewTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonsGrid)).BeginInit();
            this.DetailsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CnpErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SexErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TabManager
            // 
            this.TabManager.Controls.Add(this.OverViewTab);
            this.TabManager.Controls.Add(this.DetailsTab);
            this.TabManager.Location = new System.Drawing.Point(3, 12);
            this.TabManager.Name = "TabManager";
            this.TabManager.SelectedIndex = 0;
            this.TabManager.Size = new System.Drawing.Size(796, 426);
            this.TabManager.TabIndex = 0;
            // 
            // OverViewTab
            // 
            this.OverViewTab.Controls.Add(this.PersonsGrid);
            this.OverViewTab.Controls.Add(this.DeleteButton);
            this.OverViewTab.Controls.Add(this.EditButton);
            this.OverViewTab.Controls.Add(this.AddPersonButton);
            this.OverViewTab.Location = new System.Drawing.Point(4, 22);
            this.OverViewTab.Name = "OverViewTab";
            this.OverViewTab.Padding = new System.Windows.Forms.Padding(3);
            this.OverViewTab.Size = new System.Drawing.Size(788, 400);
            this.OverViewTab.TabIndex = 0;
            this.OverViewTab.Text = "Overview";
            this.OverViewTab.UseVisualStyleBackColor = true;
            // 
            // PersonsGrid
            // 
            this.PersonsGrid.AutoGenerateColumns = false;
            this.PersonsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNPDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.birthDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.Sex});
            this.PersonsGrid.DataSource = this.personsDataTableBindingSource;
            this.PersonsGrid.Location = new System.Drawing.Point(6, 6);
            this.PersonsGrid.Name = "PersonsGrid";
            this.PersonsGrid.Size = new System.Drawing.Size(751, 345);
            this.PersonsGrid.TabIndex = 2;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(544, 371);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.Delete_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(625, 371);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // AddPersonButton
            // 
            this.AddPersonButton.Location = new System.Drawing.Point(706, 371);
            this.AddPersonButton.Name = "AddPersonButton";
            this.AddPersonButton.Size = new System.Drawing.Size(75, 23);
            this.AddPersonButton.TabIndex = 1;
            this.AddPersonButton.Text = "Add Person";
            this.AddPersonButton.UseVisualStyleBackColor = true;
            // 
            // DetailsTab
            // 
            this.DetailsTab.Controls.Add(this.birthTimePicker);
            this.DetailsTab.Controls.Add(this.CancelButton);
            this.DetailsTab.Controls.Add(this.SaveButton);
            this.DetailsTab.Controls.Add(this.FRadioButton);
            this.DetailsTab.Controls.Add(this.MRadioButton);
            this.DetailsTab.Controls.Add(this.AgeTextBox);
            this.DetailsTab.Controls.Add(this.LastNameTextBox);
            this.DetailsTab.Controls.Add(this.FirstNameTextBox);
            this.DetailsTab.Controls.Add(this.labelSex);
            this.DetailsTab.Controls.Add(this.labelAge);
            this.DetailsTab.Controls.Add(this.labelBirth);
            this.DetailsTab.Controls.Add(this.labelLastName);
            this.DetailsTab.Controls.Add(this.labelFirstName);
            this.DetailsTab.Controls.Add(this.labelCNP);
            this.DetailsTab.Controls.Add(this.CnpTextBox);
            this.DetailsTab.Location = new System.Drawing.Point(4, 22);
            this.DetailsTab.Name = "DetailsTab";
            this.DetailsTab.Padding = new System.Windows.Forms.Padding(3);
            this.DetailsTab.Size = new System.Drawing.Size(788, 400);
            this.DetailsTab.TabIndex = 1;
            this.DetailsTab.Text = "Details";
            this.DetailsTab.UseVisualStyleBackColor = true;
            // 
            // birthTimePicker
            // 
            this.birthTimePicker.CustomFormat = "yyyy MM dd";
            this.birthTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personsDataTableBindingSource, "Birth", true));
            this.birthTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthTimePicker.Location = new System.Drawing.Point(209, 169);
            this.birthTimePicker.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.birthTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthTimePicker.Name = "birthTimePicker";
            this.birthTimePicker.Size = new System.Drawing.Size(100, 20);
            this.birthTimePicker.TabIndex = 16;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(278, 331);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(157, 331);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // FRadioButton
            // 
            this.FRadioButton.AutoSize = true;
            this.FRadioButton.Location = new System.Drawing.Point(278, 259);
            this.FRadioButton.Name = "FRadioButton";
            this.FRadioButton.Size = new System.Drawing.Size(31, 17);
            this.FRadioButton.TabIndex = 12;
            this.FRadioButton.TabStop = true;
            this.FRadioButton.Text = "F";
            this.FRadioButton.UseVisualStyleBackColor = true;
            // 
            // MRadioButton
            // 
            this.MRadioButton.AutoSize = true;
            this.MRadioButton.Location = new System.Drawing.Point(209, 259);
            this.MRadioButton.Name = "MRadioButton";
            this.MRadioButton.Size = new System.Drawing.Size(34, 17);
            this.MRadioButton.TabIndex = 11;
            this.MRadioButton.TabStop = true;
            this.MRadioButton.Text = "M";
            this.MRadioButton.UseVisualStyleBackColor = true;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsDataTableBindingSource, "Age", true));
            this.AgeTextBox.Location = new System.Drawing.Point(209, 210);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.AgeTextBox.TabIndex = 10;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsDataTableBindingSource, "LastName", true));
            this.LastNameTextBox.Location = new System.Drawing.Point(209, 138);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameTextBox.TabIndex = 8;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsDataTableBindingSource, "FirstName", true));
            this.FirstNameTextBox.Location = new System.Drawing.Point(209, 95);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameTextBox.TabIndex = 7;
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(136, 259);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(25, 13);
            this.labelSex.TabIndex = 6;
            this.labelSex.Text = "Sex";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(136, 213);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(26, 13);
            this.labelAge.TabIndex = 5;
            this.labelAge.Text = "Age";
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Location = new System.Drawing.Point(136, 175);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(28, 13);
            this.labelBirth.TabIndex = 4;
            this.labelBirth.Text = "Birth";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(136, 141);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(55, 13);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "LastName";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(136, 98);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(54, 13);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "FirstName";
            // 
            // labelCNP
            // 
            this.labelCNP.AutoSize = true;
            this.labelCNP.Location = new System.Drawing.Point(136, 58);
            this.labelCNP.Name = "labelCNP";
            this.labelCNP.Size = new System.Drawing.Size(29, 13);
            this.labelCNP.TabIndex = 1;
            this.labelCNP.Text = "CNP";
            // 
            // CnpTextBox
            // 
            this.CnpTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsDataTableBindingSource, "CNP", true));
            this.CnpTextBox.Location = new System.Drawing.Point(209, 55);
            this.CnpTextBox.Name = "CnpTextBox";
            this.CnpTextBox.Size = new System.Drawing.Size(100, 20);
            this.CnpTextBox.TabIndex = 0;
            // 
            // CnpErrorProvider
            // 
            this.CnpErrorProvider.ContainerControl = this;
            // 
            // FirstNameErrorProvider
            // 
            this.FirstNameErrorProvider.ContainerControl = this;
            // 
            // LastNameErrorProvider
            // 
            this.LastNameErrorProvider.ContainerControl = this;
            // 
            // BirthErrorProvider
            // 
            this.BirthErrorProvider.ContainerControl = this;
            // 
            // AgeErrorProvider
            // 
            this.AgeErrorProvider.ContainerControl = this;
            // 
            // SexErrorProvider
            // 
            this.SexErrorProvider.ContainerControl = this;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "Sex";
            this.Sex.Name = "Sex";
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // birthDataGridViewTextBoxColumn
            // 
            this.birthDataGridViewTextBoxColumn.DataPropertyName = "Birth";
            this.birthDataGridViewTextBoxColumn.HeaderText = "Birth";
            this.birthDataGridViewTextBoxColumn.Name = "birthDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // personsDataTableBindingSource
            // 
            this.personsDataTableBindingSource.DataMember = "Persons";
            this.personsDataTableBindingSource.DataSource = typeof(PersonPresentation_BL.PersonPresentationDataSet);
            // 
            // PersonManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabManager);
            this.Name = "PersonManager";
            this.Text = "PersonManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabManager.ResumeLayout(false);
            this.OverViewTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PersonsGrid)).EndInit();
            this.DetailsTab.ResumeLayout(false);
            this.DetailsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CnpErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SexErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabManager;
        private System.Windows.Forms.TabPage OverViewTab;
        private System.Windows.Forms.TabPage DetailsTab;
        private System.Windows.Forms.Button AddPersonButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridView PersonsGrid;
        private System.Windows.Forms.BindingSource personsDataTableBindingSource;
        private System.Windows.Forms.RadioButton FRadioButton;
        private System.Windows.Forms.RadioButton MRadioButton;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelCNP;
        private System.Windows.Forms.TextBox CnpTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DateTimePicker birthTimePicker;
        private System.Windows.Forms.ErrorProvider CnpErrorProvider;
        private System.Windows.Forms.ErrorProvider FirstNameErrorProvider;
        private System.Windows.Forms.ErrorProvider LastNameErrorProvider;
        private System.Windows.Forms.ErrorProvider BirthErrorProvider;
        private System.Windows.Forms.ErrorProvider AgeErrorProvider;
        private System.Windows.Forms.ErrorProvider SexErrorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
    }
}

