using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
			//this.genderComboBox
			//this.businessRadioButton
			clearAllTextBoxes(this);
		}

		private void saveContactButton_Click(object sender, EventArgs e)
		{
			this.saveContactButton.Enabled = false;
			saveToContactDB();
			clearAllInputs();
			this.saveContactButton.Enabled = true;
		}
	}
}
