using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Linq;

namespace Todo.Business.Repositories
{
    public class RepositoryBase<T>
    {
        protected ISession session;

        public RepositoryBase(ISession session)
        {
            this.session = session;
        }

        protected List<T> GetAll(T type)
        {
            List<T> listOfEntities = null;

            listOfEntities = session.Query<T>().ToList();
            return null;
        }
        protected T GetSingleById(int id)
        {
            T entity = default(T);
            entity = session.Get<T>(id);

            return entity;
        }

        protected void DeleteById(T entity)
        {
            session.Delete(entity);
            session.Flush();
        }

        protected void Update(T entity)
        {
            session.Update(entity);
            session.Flush();
        }

      
    }
}
