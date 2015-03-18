using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Todo.Business;

namespace Todo.Forms
{
	public partial class ListContactsForm : Form
	{
        private Business.Repositories.ContactRepository _contactRepository;
        BindingSource bs = new BindingSource();

        public ListContactsForm(Business.Repositories.ContactRepository _contactRepository)
        {
            this._contactRepository = _contactRepository;
            InitializeComponent();
            SetupFormContent();
            SetupList();
        
        }

        private void SetupFormContent()
        {
            genderComboBox.Items.Add(Todo.Business.Enums.Anrede.Herr);
            genderComboBox.Items.Add(Todo.Business.Enums.Anrede.Frau);
        }

        public void SetupList()
        {
            List<Contact> items = new List<Contact>();
            items = _contactRepository.GetAll();

            bs.DataSource = items;
            this.Contacts_Listbox.DisplayMember = "Lastname";
            this.Contacts_Listbox.ValueMember = "ContactId";
            Contacts_Listbox.DataSource = bs;
        }

        public void SetModelToView(Contact item)
        {
            lastnameTextBox.Text = item.Lastname;
            firstnameTextBox.Text = item.FirstName;
            addressTextBox.Text = item.Address;
            cityTextBox.Text = item.City;
            areacodeTextBox.Text = item.AreaCode;

            if (item.isBusiness)
                businessRadioButton.Checked = true;
            else
                privateRadioButton.Checked = true;

            landlineTextBox.Text = item.LandlineNumber;
            mobileTextBox.Text = item.MobileNumber;
            companyTextBox.Text = item.Company;
            departmentTextBox.Text = item.Department;

            if (item.Gender == "Herr")
                genderComboBox.SelectedItem=genderComboBox.Items[0];
            else
                genderComboBox.SelectedItem=genderComboBox.Items[1];
        }

        public Contact SetViewToModel()
        {
            Contact item = _contactRepository.GetSingleById((int)Contacts_Listbox.SelectedValue);
            item.Lastname = lastnameTextBox.Text;
            item.FirstName =  firstnameTextBox.Text;
            item.Address = addressTextBox.Text ;
            item.City  = cityTextBox.Text;
            item.AreaCode=  areacodeTextBox.Text ;

            item.isBusiness = businessRadioButton.Checked;

            item.LandlineNumber=  landlineTextBox.Text;
            item.MobileNumber = mobileTextBox.Text;
            item.Company = companyTextBox.Text;
            item.Department = departmentTextBox.Text;

            item.Gender = genderComboBox.SelectedItem.ToString();

            return item;
        }

        private void Index_Changed(object sender, EventArgs e)
        {
            Contact item = _contactRepository.GetSingleById((int)Contacts_Listbox.SelectedValue);
            SetModelToView(item);
        }

        private void changeContactButton_Click(object sender, EventArgs e)
        {
            Contact item = SetViewToModel();
            _contactRepository.Update(item);
            bs.ResetBindings(false);
        }

		private void deleteContactButton_Click(object sender, EventArgs e)
		{
			Contact item = SetViewToModel();
			_contactRepository.DeleteById(item);
			bs.RemoveCurrent();
			Index_Changed(sender, e);
			bs.ResetBindings(false);
		}
	}
}
