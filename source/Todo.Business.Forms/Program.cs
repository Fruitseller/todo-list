using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todo.Database;

namespace Todo.Forms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            NhibernateInitalize.Setup();
            StartForm form = new StartForm();
            form.Show();
        }
    }
}
