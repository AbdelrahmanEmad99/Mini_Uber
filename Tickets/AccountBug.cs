using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Uber.Tickets
{
    internal class AccountBug : Chain
    {
        private Chain nextInChain;

        public void SetNextChain(Chain nextchain)
        {
            nextInChain = nextchain;
        }

        public void Handle(Ticket request)
        {
            if (request.getBugCategory() == "Account Bug")
            {
                Console.WriteLine("Customer service will call you");
            }
            else
            {
                Console.WriteLine("there is no other bug categories");
            }
        }
    }
}
