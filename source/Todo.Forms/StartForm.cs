using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todo.Business.Repositories;
using Todo.Database;

namespace Todo.Forms
{
    public partial class StartForm : Form
    {
		private const string TODO_LIST_FORM_NAME = "TodoListForm";
		private const string ADD_CONTACT_FORM_NAME = "AddContactForm";
		private const string LIST_CONTACTS_FORM_NAME = "ListContactsForm";
		private TodoListForm todoListForm;
		private AddContactForm addContactForm;
		private ListContactsForm listContactsForm;
        private TodoRepository _todorepo;
        private ContactRepository _contactRepository;
        private AppointmentRepository _appointmentRepository;

        public StartForm()
        {
            InitializeComponent();
            InitializeRepositories();
        }

        private void InitializeRepositories()
        {
            NhibernateInitalize.Setup();
            _todorepo = new TodoRepository(NhibernateInitalize.session);
            _contactRepository = new ContactRepository(NhibernateInitalize.session);
            _appointmentRepository = new AppointmentRepository(NhibernateInitalize.session);
        }

		private void todoListButton_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms[TODO_LIST_FORM_NAME] == null)
			{
                this.todoListForm = new TodoListForm(_todorepo, _contactRepository, _appointmentRepository);
				this.todoListForm.Show();
			}
			else
			{
				this.todoListForm.Focus();
			}
		}

		private void newContactButton_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms[ADD_CONTACT_FORM_NAME] == null)
			{
                this.addContactForm = new AddContactForm(_contactRepository);
				this.addContactForm.Show();
			}
			else
			{
				this.addContactForm.Focus();
			}
		}

		private void contactListButton_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms[LIST_CONTACTS_FORM_NAME] == null)
			{
                this.listContactsForm = new ListContactsForm(_contactRepository);
				this.listContactsForm.Show();
			}
			else
			{
				this.listContactsForm.Focus();
			}
		}
    }
}
