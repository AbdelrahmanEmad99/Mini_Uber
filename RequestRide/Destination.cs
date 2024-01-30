using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Uber.RequestRide
{
    internal class Destination
    {
        public int Id { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public double KiloMeters { get; set; }
    }
}
