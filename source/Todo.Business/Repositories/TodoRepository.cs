using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;

namespace Todo.Business.Repositories
{
    public class TodoRepository : RepositoryBase<Todo>
    {
        public TodoRepository(ISession session) : base(session)
        {
            
        }

        public List<Todo> GetByParent(int Id)
        {
            List<Todo> items;
            items = session.Query<Todo>().Where(x => x.Parent.TodoId == Id).ToList();
            return items;
        }

        public List<Todo> GetAllWithoutParents()
        {
            List<Todo> items;
            items = session.Query<Todo>().Where(x => x.Parent == null).ToList();
            return items;
        }
    }
}
