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
	public partial class TodoListForm : Form
	{
        private Business.Repositories.TodoRepository _todorepo;
        private Business.Repositories.ContactRepository _contactRepository;
        private Business.Repositories.AppointmentRepository _appointmentRepository;


        public TodoListForm(Business.Repositories.TodoRepository _todorepo, Business.Repositories.ContactRepository _contactRepository, Business.Repositories.AppointmentRepository _appointmentRepository)
        {
            this._todorepo = _todorepo;
            this._contactRepository = _contactRepository;
            this._appointmentRepository = _appointmentRepository;
            InitializeComponent();
        }
	}
}
