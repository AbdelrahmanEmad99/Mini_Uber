using Mini_Uber.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Uber.Connections
{
    internal class DataBaseConnection
    {
        private static ApplicationDbContext _context;

        public static ApplicationDbContext GetContext()
        {
            if (_context == null)
            {
                _context = new ApplicationDbContext();
            }
            return _context;
        }
    }
}
