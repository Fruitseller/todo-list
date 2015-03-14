using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Todo.Business.Repositories
{
    public class ContactRepository : RepositoryBase<Contact>
    {
        public ContactRepository(ISession session) : base(session)
        {

        }
         
    }
}
