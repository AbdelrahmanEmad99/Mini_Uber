using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Uber.Tickets
{
    internal class ServerBug : Chain
    {
        private Chain nextInChain;

        public void SetNextChain(Chain nextchain)
        {
            nextInChain = nextchain;
        }

        public void Handle(Ticket request)
        {
            if (request.getBugCategory() == "Server Bug")
            {
                Console.WriteLine("The solution is to Restart your app");
            }
            else
            {
                nextInChain.Handle(request);
            }
        }
    }
}
