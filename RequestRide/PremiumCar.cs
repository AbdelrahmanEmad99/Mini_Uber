using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_uber
{
    internal class PremiumCar : TripTypeStrategy
    {
        public void tripType(string start, string destination)
        {
            Console.WriteLine("Trip with a Premium Car from " + start + " to " + destination);
        }
        public double price(double kilometers)
        {
            return kilometers * 2.5; 
        }
    }
}
