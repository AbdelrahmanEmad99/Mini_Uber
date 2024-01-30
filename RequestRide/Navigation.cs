using Mini_Uber.Connections;
using Mini_Uber.RequestRide;
using Mini_Uber.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_uber
{
    internal class Navigations
    {
        private TripTypeStrategy tripTypeStrategy;

        public void setStrategy(TripTypeStrategy tripTypeStrategy)
        {
            this.tripTypeStrategy = tripTypeStrategy;
        }

        public void tripDestination(string start, string destination)
        {
            tripTypeStrategy.tripType(start, destination);
        }
        public double calculatedPrice(double kilometers)
        {
            return tripTypeStrategy.price(kilometers);
        }
    }
}
