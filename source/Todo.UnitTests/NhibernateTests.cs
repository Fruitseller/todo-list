using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate.Cfg;
using NHibernate;
using Todo.Business;

namespace Todo.UnitTests
{
    [TestClass]
    public class NhibernateTests
    {
        private ISession _session;
        private Configuration _cfg;

        [TestMethod]
        public void CanCreateConfig()
        {
            var cfg = new Configuration();
            cfg.Configure();

            Assert.IsNotNull(cfg);
        }

        [TestInitialize()]
        public void Setup()
        {
            _cfg = new Configuration();
            _cfg.Configure();
            _cfg.AddAssembly(typeof(Business.Todo).Assembly);

            var session = _cfg.BuildSessionFactory();
            _session = session.OpenSession();
        }

        [TestCleanup()]
        public void Cleanup()
        {
            _session.Dispose();
        }

        [TestMethod]
        public void CanCreateMapping()
        {
            _cfg.AddAssembly(typeof(Business.Todo).Assembly);
      
            Assert.AreNotEqual(_cfg.ClassMappings.Count,0);
        }


    }
}
