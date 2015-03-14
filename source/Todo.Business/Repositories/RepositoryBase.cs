using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Linq;

namespace Todo.Business.Repositories
{
    public class RepositoryBase<T> : IDisposable
    {
        protected ISession session;

        public RepositoryBase(ISession session)
        {
            this.session = session;
        }

        public List<T> GetAll(T type)
        {
            List<T> listOfEntities = null;

            listOfEntities = session.Query<T>().ToList();
            return null;
        }
        public T GetSingleById(int id)
        {
            T entity = default(T);
            entity = session.Get<T>(id);

            return entity;
        }

        public void DeleteById(T entity)
        {
            session.Delete(entity);
            session.Flush();
        }

        public void Update(T entity)
        {
            session.Update(entity);
            session.Flush();
        }

        public void Save(T entity)
        {
            session.Clear();
            session.Save(entity);
            session.Flush();
        }

        public void Dispose()
        {
            session.Close();
            session.Dispose();
        }
      
    }
}
