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
	public partial class TodoListForm : Form
	{
        private Business.Repositories.TodoRepository _todorepo;
        private Business.Repositories.ContactRepository _contactRepository;
        private Business.Repositories.AppointmentRepository _appointmentRepository;

        private BindingSource bsContacts = new BindingSource();
        private BindingSource bsAssignedContacts = new BindingSource();

        private List<Contact> _assignedContacts = new List<Contact>();
        private List<Contact> _Contacts = new List<Contact>();


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
            //Contact List
            _Contacts = _contactRepository.GetAll();

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
            rootNode.Tag = -1;
            this.todoListTreeView.Nodes.Add(rootNode);
            List<Todo.Business.Todo> todos = _todorepo.GetAll();
            List<Todo.Business.Todo> orphantodos = todos.Where(x=>x.Parent==null).ToList();
       

            foreach(var todo in orphantodos)
            {
                TreeNode newNode = new TreeNode();
                newNode.Text = todo.Title;
                newNode.Tag = todo.TodoId;
                rootNode.Nodes.Add(newNode);
            }
            
        }


        private void newTodoListButton_Click(object sender, EventArgs e)
        {
            TreeNode node = this.todoListTreeView.SelectedNode;
            TreeNode newNode = new TreeNode("Neue Todoliste");
            this.todoListTreeView.SelectedNode.Nodes.Add(newNode);
            this.todoListTreeView.SelectedNode.Expand();
            newNode.BeginEdit();
        }

        private void newEntryButton_Click(object sender, EventArgs e)
        {

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
            string txt = node.Text;
            int tag=-1;
            if (node.Tag != null)
                tag = (int)node.Tag;

            int parentid = node.Parent.Text == "Root" ? -1 : (int)node.Parent.Tag;          

            if(tag ==-1)
            {
                _todorepo.Save(new Business.Todo() { Title = txt, Parent = _todorepo.GetSingleById(parentid) });
            }
            else
            {

            }
        }

	}
}
