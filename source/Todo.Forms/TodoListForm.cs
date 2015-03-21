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
            if(todoListTreeView.SelectedNode.Tag is Appointment)
            {
                MessageBox.Show("Todo Liste kann nicht einem Termin untergeordnet werden");
                return;
            }
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
            TreeNode node = this.todoListTreeView.SelectedNode;

            if(node.Tag is Business.Todo)
            {
                app.TodoEntry = (Business.Todo)node.Tag;
                _appointmentRepository.Save(app);
                TreeNode newNode = new TreeNode();
                newNode = setImageForAppointment(newNode, app);
                newNode.Text = app.Title;
                newNode.Tag = app;
                node.Nodes.Add(newNode);
            }
            else if(node.Tag is Appointment)
            {
				Appointment updatedAppointment = getAppointmentFromForm();
				updatedAppointment.AppointmentId = ((Appointment)node.Tag).AppointmentId;
				updatedAppointment.TodoEntry = ((Appointment)node.Tag).TodoEntry;
				_appointmentRepository.Update(updatedAppointment);
				this.todoListTreeView.SelectedNode.Text = updatedAppointment.Title;
				this.todoListTreeView.SelectedNode.Tag = updatedAppointment;
				this.todoListTreeView.SelectedNode = setImageForAppointment(this.todoListTreeView.SelectedNode, updatedAppointment);
				MessageBox.Show("Der Eintrag wurde erfolgreich aktualisiert!");
            }
            else
	        {
                MessageBox.Show("Kein Baumelement ausgewählt");
	        }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
			TreeNode node = this.todoListTreeView.SelectedNode;
			if (node.Tag is Business.Appointment)
			{
				Appointment app = (Appointment)node.Tag;
				_appointmentRepository.Delete(app);
                node.Remove();
			}
            if(node.Tag is Business.Todo)
            {
                if(node.Nodes.Count!=0)
                {
                    DialogResult yesNo = MessageBox.Show("Das Element hat unterteilte Elemente, die ebenfalls gelöscht werden. Fortfahren?",
                     "Warnung",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question,
                     MessageBoxDefaultButton.Button2);

                    if (yesNo == DialogResult.No)
                        return;
                }
                Business.Todo todo = (Business.Todo)node.Tag;
                DeleteRecursive(node);
               

                _todorepo.Delete(todo);
                node.Remove();
            }
        }

        private void DeleteRecursive(TreeNode node)
        {
            foreach(TreeNode childNode in node.Nodes)
            {
                if(childNode.Tag is Appointment)
                {
                    Appointment app = (Appointment)childNode.Tag;
                    _appointmentRepository.Delete(app);
                }
                else if (childNode.Tag is Business.Todo)
                {
                    DeleteRecursive(childNode);
                    Business.Todo todo = (Business.Todo)childNode.Tag;
                    _todorepo.Delete(todo);
                }

            }
        }

        private void right_button_Click(object sender, EventArgs e)
        {
            if (this.ContactsListBox.SelectedValue == null)
                return;

            switchero(_assignedContacts, _Contacts, _contactRepository.GetSingleById((UInt32)ContactsListBox.SelectedValue));
        }

        private void left_button_Click(object sender, EventArgs e)
        {
            if (AssignedContactsListbox.SelectedValue == null)
                return;

            switchero(_Contacts, _assignedContacts, _contactRepository.GetSingleById((UInt32)AssignedContactsListbox.SelectedValue));
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
                UInt32 id = todo.TodoId;
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
                    TreeNode childNode = new TreeNode(child.Title, 0, 0);
                    childNode.Text = child.Title;
                    childNode.Tag = child;
                    node.Nodes.Add(childNode);
                    appendChilden(childNode);
                }

                foreach (var child in childrenApps)
                {
                    TreeNode childNode = new TreeNode();
                    childNode.Text = child.Title;
                    childNode = setImageForAppointment(childNode, child);
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
                    node = setImageForAppointment(childNode, child);
                }
                return;
            }
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

        private void setViewToAppointment(Appointment app)
        {
            _assignedContacts = _appointmentRepository.GetSingleById(app.AppointmentId).Contacts.ToList();
            bsAssignedContacts.DataSource = _assignedContacts;
            bsAssignedContacts.ResetBindings(false);


            List<Contact> allContacts = _contactRepository.GetAll();
            _Contacts = allContacts.Where(p => !_assignedContacts.Any(p2 => p2.ContactId == p.ContactId)).ToList();
            bsContacts.DataSource = _Contacts;
            bsContacts.ResetBindings(false);

            this.titleTextBox.Text = app.Title;
            startDatePicker.Text = app.StartDate.ToString();
            endDatePicker.Text = app.EndDate.ToString();
            descriptionBox.Text = app.Description;
            priorityElement.Value = app.Priority;
            doneCheckBox.Checked = app.Done;
        }

        private TreeNode setImageForAppointment(TreeNode node,Appointment app)
        {
            if (app.Done)
            {
                node.ImageIndex = 2;
                node.SelectedImageIndex = 2;
            }
            else
            {
                node.ImageIndex = 1;
                node.SelectedImageIndex = 1;
            }

            return node;
        }

        private void After_Select(object sender, TreeViewEventArgs e)
        {
            if (this.todoListTreeView.SelectedNode.Tag is Appointment)
			{
				setViewToAppointment((Appointment)this.todoListTreeView.SelectedNode.Tag);
				this.newEntryButton.Text = "Eintrag aktualisieren";
			}
			else
			{
				this.newEntryButton.Text = "Neuen Termin speichern";
			}
        }
    }
}
