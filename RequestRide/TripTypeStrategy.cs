using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_uber
{
    internal interface TripTypeStrategy
    {
        public void tripType(string start, string destination);
        public double price(double kilometers);

    }
}
