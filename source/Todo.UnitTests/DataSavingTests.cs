using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate.Cfg;
using NHibernate;
using Todo.Business;
using Todo.Business.Repositories;
using NHibernate.Tool.hbm2ddl;

namespace Todo.UnitTests
{
    [TestClass]
    public class DataSavingTests
    {
        private static Configuration _cfg;
        private static TodoRepository _todorepo;


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
    }
}
