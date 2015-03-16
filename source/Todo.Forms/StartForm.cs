using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo.Forms
{
    public partial class StartForm : Form
    {
		private TodoListForm todoListForm;
		private AddContactForm addContactForm;
		private ListContactsForm listContactsForm;

        public StartForm()
        {
            InitializeComponent();
        }

		private void todoListButton_Click(object sender, EventArgs e)
		{
			if (this.todoListForm == null)
			{
				this.todoListForm = new TodoListForm();
				this.todoListForm.Show();
			}
			else
			{
				this.todoListForm.Focus();
			}
		}

		private void newContactButton_Click(object sender, EventArgs e)
		{
			if (this.addContactForm == null)
			{
				this.addContactForm = new AddContactForm();
				this.addContactForm.Show();
			}
			else
			{
				this.addContactForm.Focus();
			}
		}

		private void contactListButton_Click(object sender, EventArgs e)
		{
			if (this.listContactsForm == null)
			{
				this.listContactsForm = new ListContactsForm();
				this.listContactsForm.Show();
			}
			else
			{
				this.listContactsForm.Focus();
			}
		}
    }
}
