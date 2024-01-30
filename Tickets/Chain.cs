using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Uber.Tickets
{
    internal interface Chain
    {
        public void SetNextChain(Chain nextchain);

        public void Handle(Ticket request);

    }
}
