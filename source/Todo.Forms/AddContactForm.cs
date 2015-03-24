using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Todo.Forms
{
	public partial class AddContactForm : Form
	{
        private Business.Repositories.ContactRepository _contactRepository;
		private Business.Contact contact;

        public AddContactForm(Business.Repositories.ContactRepository _contactRepository)
        {
            this._contactRepository = _contactRepository;
            InitializeComponent();
			initializeSelectables();

            if (System.Diagnostics.Debugger.IsAttached)
                this.generateRandomContactButton.Visible = true;
            else
                this.generateRandomContactButton.Visible = false;
        }

		protected void initializeSelectables()
		{
			this.genderComboBox.Items.Add(Todo.Business.Enums.Anrede.Herr);
			this.genderComboBox.Items.Add(Todo.Business.Enums.Anrede.Frau);
			this.genderComboBox.SelectedIndex = this.genderComboBox.Items.IndexOf(Todo.Business.Enums.Anrede.Herr);
			this.businessRadioButton.Checked = true;
		}

		protected void saveToContactDB()
		{
			this.contact = new Business.Contact();
			this.contact.Gender = this.genderComboBox.Text;
			this.contact.Lastname = this.lastnameTextBox.Text;
			this.contact.FirstName = this.firstnameTextBox.Text;
			this.contact.Address = this.addressTextBox.Text;
			this.contact.City = this.cityTextBox.Text;
			this.contact.AreaCode = this.areacodeTextBox.Text;
			this.contact.isBusiness = this.businessRadioButton.Checked;
			this.contact.LandlineNumber = this.landlineTextBox.Text;
			this.contact.MobileNumber = this.mobileTextBox.Text;
			this.contact.Company = this.companyTextBox.Text;
			this.contact.Department = this.departmentTextBox.Text;

			this._contactRepository.Save(this.contact);
		}

		protected void clearAllTextBoxes(Control mainControl)
		{
			foreach(var control in mainControl.Controls)
			{
				if (control is TextBox)
				{
					((TextBox)control).Text = String.Empty;
				}
			}
		}

		protected void clearAllInputs()
		{
			clearAllTextBoxes(this);
		}

		private void saveContactButton_Click(object sender, EventArgs e)
		{
			saveToContactDB();
			clearAllInputs();
			MessageBox.Show("Kontakt erfolgreich gespeichert!", "Hinweis");
		}

		private void businessRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (this.businessRadioButton.Checked == false)
			{
				this.companyLabel.Visible = false;
				this.companyTextBox.Text = String.Empty;
				this.companyTextBox.Visible = false;

				this.departmentLabel.Visible = false;
				this.departmentTextBox.Text = String.Empty;
				this.departmentTextBox.Visible = false;
			}
			else
			{
				this.companyLabel.Visible = true;
				this.companyTextBox.Visible = true;
				this.departmentLabel.Visible = true;
				this.departmentTextBox.Visible = true;
			}
		}

		private string generateRandomString()
		{
			string random = Path.GetRandomFileName();
			random = random.Replace(".", "");
			random = random.Substring(0, 7);
			return random;
		}

		private string generateRandomNumbers()
		{
			Random random = new Random();
			return random.Next(9999, 100000).ToString();
		}

		private void generateRandomContactButton_Click(object sender, EventArgs e)
		{
			this.lastnameTextBox.Text = this.generateRandomString();
			this.firstnameTextBox.Text = this.generateRandomString();
			this.addressTextBox.Text = this.generateRandomString();
			this.cityTextBox.Text = this.generateRandomString();
			this.areacodeTextBox.Text = this.generateRandomNumbers();
			this.landlineTextBox.Text = this.generateRandomNumbers();
			this.mobileTextBox.Text = this.generateRandomNumbers();
			this.companyTextBox.Text = this.generateRandomString();
			this.departmentTextBox.Text = this.generateRandomString();
		}
	}
}
