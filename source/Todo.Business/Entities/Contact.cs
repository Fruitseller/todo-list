﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Todo.Business
{
    public class Contact
    {
        public virtual UInt32 ContactId { get; set; }
        public virtual string Gender { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        public virtual string AreaCode { get; set; }
        public virtual bool isBusiness { get; set; }
        public virtual string LandlineNumber { get; set; }
        public virtual string MobileNumber { get; set; }
        public virtual string Company { get; set; }
        public virtual string Department { get; set; }
        public virtual IList<Appointment> Appointments { get; set; }

        public virtual string FullName
        {
            get { return FirstName + " " + Lastname; }
        }
    }
}
