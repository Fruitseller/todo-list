using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Todo.Business
{
    public class Appointment
    {
        public virtual string Title { get; set; }
        public virtual int AppointmentId { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }
        public virtual int Priority { get; set; }
        public virtual string Description { get; set; }
        public virtual Todo TodoEntry { get; set; }
        public virtual IList<Contact> Contacts { get; set; }
        public virtual bool IsDone { get; set; }
    }
}
