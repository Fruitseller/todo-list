using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Todo.Business.Database
{
    public class NhibernateInitalize
    {
        public NHibernate.ISession session;

        public NhibernateInitalize ()
        {

        }

        private void BuildSchema()
        {
            
        }

        public void Initialize()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(Todo.Business.Entities.Todo).Assembly);

            // Get ourselves an NHibernate Session
            var sessions = cfg.BuildSessionFactory();
            session = sessions.OpenSession();

            NHibernate.Tool.hbm2ddl.SchemaExport se;
            se = new NHibernate.Tool.hbm2ddl.SchemaExport(cfg);
            se.Execute(false, true, false, session.Connection, null);
        }

    }
}
