using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Uber.Tickets
{
    internal class Ticket
    {
        string bugCategory;

        public Ticket(string bugCategory)
        {
            this.bugCategory = bugCategory;
        }

        public string getBugCategory()
        {
            return bugCategory;
        }
    }
}
