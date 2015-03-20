using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Todo.Business;
using Todo.Business.Repositories;
using Todo = Todo.Business.Todo;

namespace Todo.Forms
{
    public partial class TodoListForm : Form
    {
        private Business.Repositories.TodoRepository _todorepo;
        private Business.Repositories.ContactRepository _contactRepository;
        private Business.Repositories.AppointmentRepository _appointmentRepository;

        private BindingSource bsContacts = new BindingSource();
        private BindingSource bsAssignedContacts = new BindingSource();

        private List<Contact> _assignedContacts = new List<Contact>();
        private List<Contact> _Contacts = new List<Contact>();

        private List<Business.Todo> _allTodos = new List<Business.Todo>();
        private List<Business.Appointment> _allAppointsments = new List<Business.Appointment>();


        public TodoListForm(Business.Repositories.TodoRepository _todorepo, Business.Repositories.ContactRepository _contactRepository, Business.Repositories.AppointmentRepository _appointmentRepository)
        {
            this._todorepo = _todorepo;
            this._contactRepository = _contactRepository;
            this._appointmentRepository = _appointmentRepository;
            InitializeComponent();
            InitializeFormElements();
        }

        private void InitializeFormElements()
        {
            this.todoListTreeView.HideSelection = false;


            //Contact List
            _Contacts = _contactRepository.GetAll();
            
            this.endDatePicker.Format = DateTimePickerFormat.Custom;
            this.endDatePicker.CustomFormat =  "dd.MM.yyyy HH:mm";
           
            this.startDatePicker.Format = DateTimePickerFormat.Custom;
            this.startDatePicker.CustomFormat = "dd.MM.yyyy HH:mm";

            ContactsListBox.DisplayMember = "FullName";
            ContactsListBox.ValueMember = "ContactId";
            bsContacts.DataSource = _Contacts;
            ContactsListBox.DataSource = bsContacts;

            AssignedContactsListbox.DisplayMember = "FullName";
            AssignedContactsListbox.ValueMember = "ContactId";
            bsAssignedContacts.DataSource = _assignedContacts;
            AssignedContactsListbox.DataSource = bsAssignedContacts;

            // TODO Tree
            this.todoListTreeView.LabelEdit = true;
            TreeNode rootNode = new TreeNode("Root");
            rootNode.Tag = null;
            this.todoListTreeView.Nodes.Add(rootNode);
            _allTodos = _todorepo.GetAll();
            List<Business.Todo> orphantodos = _allTodos.Where(x => x.Parent == null).ToList();
            _allAppointsments = _appointmentRepository.GetAll().ToList();

            foreach (var todo in orphantodos)
            {
                TreeNode newNode = new TreeNode();
                newNode.Text = todo.Title;
                newNode.Tag = todo;
                rootNode.Nodes.Add(newNode);
                appendChilden(newNode);
            }
        }


        private void newTodoListButton_Click(object sender, EventArgs e)
        {
            TreeNode node = this.todoListTreeView.SelectedNode;
            TreeNode newNode = new TreeNode("Neue Todoliste");
            Business.Todo todo = new Business.Todo();
            todo.Title = "Neue Todoliste";
            newNode.Tag = todo;
            this.todoListTreeView.SelectedNode.Nodes.Add(newNode);
            this.todoListTreeView.SelectedNode.Expand();
            newNode.BeginEdit();
        }

        private void newEntryButton_Click(object sender, EventArgs e)
        {
            Appointment app = getAppointmentFromForm();
            TreeNode node =this.todoListTreeView.SelectedNode;

            if(node.Tag is Business.Todo)
            {
                app.TodoEntry = (Business.Todo)node.Tag;
                _appointmentRepository.Save(app);
                TreeNode newNode = new TreeNode();
                newNode.Text = app.Title;
                newNode.Tag = app;
                node.Nodes.Add(newNode);
            }
            else if(node.Tag is Appointment)
            {
                MessageBox.Show("Termin kann nicht einen Termin untergeordnet werden");
            }
            else
	        {
                MessageBox.Show("Kein Baumelement ausgewählt");
	        }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void right_button_Click(object sender, EventArgs e)
        {
            if (this.ContactsListBox.SelectedValue == null)
                return;

            switchero(_assignedContacts, _Contacts, _contactRepository.GetSingleById((int)ContactsListBox.SelectedValue));
        }

        private void left_button_Click(object sender, EventArgs e)
        {
            if (AssignedContactsListbox.SelectedValue == null)
                return;

            switchero(_Contacts, _assignedContacts, _contactRepository.GetSingleById((int)AssignedContactsListbox.SelectedValue));
        }

        private void switchero(List<Contact> target, List<Contact> source, Contact item)
        {
            target.Add(item);
            source.Remove(item);
            bsAssignedContacts.ResetBindings(false);
            bsContacts.ResetBindings(false);
        }

        private void After_Edit(object sender, NodeLabelEditEventArgs e)
        {
            this.BeginInvoke(new Action(() => afterAfter_Edit(e.Node)));
        }

        private void afterAfter_Edit(TreeNode node)
        {

            if (node.Tag is Business.Todo)
            {
                Business.Todo todo = new Business.Todo();
                todo.Title = node.Text;
                int id = todo.TodoId;
                Business.Todo parent = null;

                if (node.Parent != null && node.Parent.Tag is Business.Todo)
                {
                    parent = (Business.Todo)node.Parent.Tag;
                }
                todo.Parent = parent;
                if (id == 0)
                {
                    _todorepo.Save(todo);
                }
                else
                {
                    _todorepo.Update(todo);
                }
                node.Tag = todo;
            }
            else if (node.Tag is Appointment)
            {
                Appointment app = (Appointment)node.Tag;

                app.Title = node.Text;

                _appointmentRepository.Update(app);
            }

        }

        public void appendChilden(TreeNode node)
        {
            if (node.Tag is Business.Todo)
            {
                Business.Todo todo = (Business.Todo)node.Tag;
                List<Business.Todo> children = _allTodos.Where(x => x.Parent != null && x.Parent.TodoId == todo.TodoId).ToList();
                List<Appointment> childrenApps = _allAppointsments.Where(x => x.TodoEntry != null && x.TodoEntry.TodoId == todo.TodoId).ToList();

                foreach (var child in children)
                {
                    TreeNode childNode = new TreeNode();
                    childNode.Text = child.Title;
                    childNode.Tag = child;
                    node.Nodes.Add(childNode);
                    appendChilden(childNode);
                }

                foreach (var child in childrenApps)
                {
                    TreeNode childNode = new TreeNode();
                    childNode.Text = child.Title;
                    childNode.Tag = child;
                    node.Nodes.Add(childNode);
                }

            }
            else if (node.Tag is Business.Appointment)
            {
                Appointment app = (Appointment)node.Tag;
                List<Appointment> children = _allAppointsments.Where(x => x.TodoEntry.TodoId == app.TodoEntry.TodoId).ToList();
                foreach (var child in children)
                {
                    TreeNode childNode = new TreeNode();
                    childNode.Text = child.Title;
                    childNode.Tag = child;
                    node.Nodes.Add(childNode);
                }
            }
            return;
        }


        private Appointment getAppointmentFromForm()
        {
            Appointment app = new Appointment();

            app.Contacts = this.AssignedContactsListbox.Items.Cast<Contact>().ToList();
            app.Title = this.titleTextBox.Text;
            app.StartDate = DateTime.Parse(startDatePicker.Text);
            app.EndDate = DateTime.Parse(endDatePicker.Text);
            app.Description = this.descriptionBox.Text;
            app.Priority = (int)this.priorityElement.Value;
			app.Done = this.doneCheckBox.Checked;
          
            return app;
		}

		private void castAppointmentToForm(Business.Appointment app)
		{
			this.titleTextBox.Text = app.Title;
			this.startDatePicker.Text = app.StartDate.ToString();
			this.endDatePicker.Text = app.EndDate.ToString();
			this.priorityElement.Value = app.Priority;
			// TODO Fix ListBox casting
			//this.AssignedContactsListbox.Items.AddRange(app.Contacts.Cast<Contact>().ToArray());
			this.descriptionBox.Text = app.Description;
			this.doneCheckBox.Checked = app.Done;
		}

		private void todoListTreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (e.Node.Tag is Business.Todo)
			{

			}
			else if (e.Node.Tag is Business.Appointment)
			{
				castAppointmentToForm((Appointment)e.Node.Tag);
			}
		}

		private void doneCheckBox_Click(object sender, EventArgs e)
		{
			// TODO Remove Debug Code
			MessageBox.Show(getAppointmentFromForm().ToString());
			//_appointmentRepository.Update(getAppointmentFromForm());
		}
    }
}
