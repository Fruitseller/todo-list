using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using Todo.Business.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Linq;

namespace Todo.Business.Database
{
    public class NhibernateInitalize
    {
        public NHibernate.ISession session;

        public NhibernateInitalize ()
        {
            Configuration config = GetConfig();
        }

        private void Initialize()
        {
            
        }

        public Configuration GetConfig()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly("Todo.Business.Entities");
       
            var sessions = cfg.BuildSessionFactory();
            session = sessions.OpenSession();
            SchemaUpdate up = new SchemaUpdate(cfg);
            up.Execute(true, true);

            //
            Todo.Business.Entities.Todo test1= new Entities.Todo();
            test1.Title = "Test";
            session.Save(test1);

            Appointment test2 = new Appointment();
            test2.Description = "Test";

            session.Save(test2);

            Contact test3 = new Contact();
            test3.FirstName = "Test";

            session.Save(test3);

            List<Entities.Todo> todos = session.Query<Entities.Todo>().ToList();
        
            return cfg;

        }

    }
}
