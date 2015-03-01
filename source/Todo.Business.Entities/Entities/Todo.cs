using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Business.Entities
{
    public class Todo
    {
        public virtual int TodoId { get; set; }
        public virtual DateTime Time { get; set; }
        public virtual string Description { get; set; }
    }
}
