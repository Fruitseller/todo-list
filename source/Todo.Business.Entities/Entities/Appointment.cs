using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Todo.Business.Entities
{
    public class Appointment
    {
        public virtual int AppointmentId { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }
        public virtual int Priority { get; set; }
        public virtual string Description { get; set; }
        public virtual Todo TodoEntry { get; set; }
        public virtual List<Contact> Contacts { get; set; }
    }
}
