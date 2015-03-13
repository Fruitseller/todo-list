using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Business
{
    public class Todo
    {
        public virtual int TodoId { get; set; }
        public virtual string Title { get; set; }
        public virtual Todo Parent { get; set; }
    }
}
