﻿using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Linq;

namespace Todo.Business.Repositories
{
    public class AppointmentRepository : RepositoryBase<Appointment>
    {
        public AppointmentRepository(ISession session) : base(session)
        {

        }

        public List<Appointment> GetByTimeframe(DateTime from, DateTime to)
        {
            List<Appointment> items;
            items = session.Query<Appointment>().Where(x => x.EndDate >= to && x.StartDate <= from).ToList();
            return items;
        }

        public List<Appointment> GetByTodoId(UInt32 id)
        {
            List<Appointment> items;
            items = session.Query<Appointment>().Where(x => x.TodoEntry.TodoId==id).ToList();
            return items;
        }

        public void DeleteAllByTodoId(UInt32 Id)
        {
            List<Appointment> items = GetByTodoId(Id);
            foreach(var item in items)
            {
                Delete(item);
            }
        }
    }
}
