using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Mapping.ByCode;
using NHibernate.Linq;
using System.Data.SQLite;
using Todo.Business.Repositories;
using Todo.Business;

namespace Todo.Database
{
    public static class NhibernateInitalize
    {
        public static NHibernate.ISession session;
        public static Configuration cfg;
        private static System.Data.SQLite.SQLiteCommand cmd = new SQLiteCommand();

        public static void Setup()
        {
            Initialize();
        }

        private static void Initialize()
        {
            cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(Business.Todo).Assembly);

            SchemaValidator validator = new SchemaValidator(cfg);
            try
            {
                validator.Validate();
            }
            catch (HibernateException)
            {
                SchemaUpdate update = new SchemaUpdate(cfg);
                update.Execute(false, true);
            }
            session = GetSession();
        }

        private static ISession GetSession()
        {
            var sessfac = cfg.BuildSessionFactory();
            ISession sess;
            sess = sessfac.OpenSession();
            return sess;
        }
    }
}
