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
		public virtual bool Done { get; set; }
        public virtual Todo TodoEntry { get; set; }
        public virtual IList<Contact> Contacts { get; set; }
		public override string ToString()
		{
			return "Title: " + this.Title + "\n"
				+ "AppointmentId: " + this.AppointmentId.ToString() + "\n"
				+ "StartDate: " + this.StartDate.ToShortDateString() + "\n"
				+ "EndDate: " + this.EndDate.ToShortDateString() + "\n"
				+ "Priority: " + this.Priority.ToString() + "\n"
				+ "Description: \"" + this.Description + "\"\n"
				+ "Done: " + this.Done.ToString() + "\n"
				+ "TodoId: " + this.TodoEntry.TodoId.ToString();
		}
    }
}
