using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate.Cfg;
using NHibernate;
using Todo.Business;
using Todo.Business.Repositories;
using NHibernate.Tool.hbm2ddl;
using System.Collections.Generic;

namespace Todo.UnitTests
{
    [TestClass]
    public class DataSavingTests
    {
        private static Configuration _cfg;
        private static TodoRepository _todorepo;
        private static ContactRepository _contactrepo;
        private static AppointmentRepository _appointmentrepo;


        [ClassInitialize()]
        public static void Setup(TestContext context)
        {
            _cfg = new Configuration();
            _cfg.Configure();
            _cfg.AddAssembly(typeof(Business.Todo).Assembly);

            SchemaExport exp = new SchemaExport(_cfg);
            exp.Execute(true, true, false);

            ISessionFactory sessionFactory = _cfg.BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            _todorepo = new TodoRepository(session);
            _contactrepo = new ContactRepository(session);
            _appointmentrepo = new AppointmentRepository(session);
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            _todorepo.Dispose();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            //Reset database data after every run
            SchemaExport exp = new SchemaExport(_cfg);
            exp.Execute(true, true, false);
        }

        [TestMethod]
        public void CanSaveTodo()
        {
            Todo.Business.Todo todo = new Todo.Business.Todo();
            todo.Title = "Test";
            _todorepo.Save(todo);

        }

        [TestMethod]
        public void CanSaveTodoComplex()
        {
            var todo = new Todo.Business.Todo();
            todo.Title = "Test";
            _todorepo.Save(todo);
            todo = _todorepo.GetSingleById(1);

            var todo2 = new Todo.Business.Todo();
            todo2.Title = "Test2";
            todo2.Parent = todo;
            _todorepo.Save(todo2);

            var todoCheck  = _todorepo.GetSingleById(2);

            Assert.AreEqual(todoCheck.TodoId == 2 && todoCheck.Parent.TodoId == 1, true);
        }

        [TestMethod]
        public void CaneSaveContact()
        {
            Todo.Business.Contact contact = new Todo.Business.Contact();
            contact.Address = "Test";
            contact.AreaCode = "Test";
            contact.City = "Test";
            contact.Company = "Test";
            contact.Department = "Test";
            contact.FirstName = "Test";
            contact.Gender = "Test";
            contact.isBusiness = true;
            contact.LandlineNumber = "Test";
            contact.Lastname = "Test";
            contact.MobileNumber = "Test";
            _contactrepo.Save(contact);

            Contact c1 = _contactrepo.GetSingleById(1);

        }

        [TestMethod]
        public void CaneSaveAppointment()
        {
            Todo.Business.Appointment appointment = new Todo.Business.Appointment();
            appointment.Description = "Test";
            appointment.StartDate = DateTime.Now;
            appointment.Priority = 1;
            appointment.EndDate = DateTime.Now.AddDays(3);

            _appointmentrepo.Save(appointment);

            Appointment a1 = _appointmentrepo.GetSingleById(1);
        }

        [TestMethod]
        public void CaneSaveAppointmentWith2Contacts()
        {
            Todo.Business.Appointment appointment = new Todo.Business.Appointment();
            appointment.Description = "Test";
            appointment.StartDate = DateTime.Now;
            appointment.Priority = 1;
            appointment.EndDate = DateTime.Now.AddDays(3);

            Todo.Business.Contact contact1 = new Todo.Business.Contact();
            contact1.Address = "Test";
            contact1.AreaCode = "Test";
            contact1.City = "Test";
            contact1.Company = "Test";
            contact1.Department = "Test";
            contact1.FirstName = "Test";
            contact1.Gender = "Test";
            contact1.isBusiness = true;
            contact1.LandlineNumber = "Test";
            contact1.Lastname = "Test";
            contact1.MobileNumber = "Test";
            _contactrepo.Save(contact1);

            Todo.Business.Contact contact2 = new Todo.Business.Contact();
            contact2.Address = "Test2";
            contact2.AreaCode = "Test2";
            contact2.City = "Test2";
            contact2.Company = "Test2";
            contact2.Department = "Test2";
            contact2.FirstName = "Test2";
            contact2.Gender = "Test2";
            contact2.isBusiness = true;
            contact2.LandlineNumber = "Test2";
            contact2.Lastname = "Test2";
            contact2.MobileNumber = "Test2";
            _contactrepo.Save(contact2);

            Contact c1 = _contactrepo.GetSingleById(1);
            Contact c2 = _contactrepo.GetSingleById(2);
            appointment.Contacts = new List<Contact>();
            appointment.Contacts.Add(c1);
            appointment.Contacts.Add(c2);

            _appointmentrepo.Save(appointment);
        }

        
        [TestMethod]
        public void CanSaveContactWith2Appointments()
        {

            Todo.Business.Appointment appointment = new Todo.Business.Appointment();
            appointment.Description = "Test";
            appointment.StartDate = DateTime.Now;
            appointment.Priority = 1;
            appointment.EndDate = DateTime.Now.AddDays(3);

            _appointmentrepo.Save(appointment);

            appointment = new Todo.Business.Appointment();
            appointment.Description = "Test2";
            appointment.StartDate = DateTime.Now;
            appointment.Priority = 2;
            appointment.EndDate = DateTime.Now.AddDays(3);
            _appointmentrepo.Save(appointment);

            var a1 = _appointmentrepo.GetSingleById(1);
            var a2 = _appointmentrepo.GetSingleById(2);

            Todo.Business.Contact contact1 = new Todo.Business.Contact();
            contact1.Address = "Test";
            contact1.AreaCode = "Test";
            contact1.City = "Test";
            contact1.Company = "Test";
            contact1.Department = "Test";
            contact1.FirstName = "Test";
            contact1.Gender = "Test";
            contact1.isBusiness = true;
            contact1.LandlineNumber = "Test";
            contact1.Lastname = "Test";
            contact1.MobileNumber = "Test";
            contact1.Appointments = new List<Appointment>();
            contact1.Appointments.Add(a1);
            contact1.Appointments.Add(a2);
            _contactrepo.Save(contact1);
        }
    }
}
