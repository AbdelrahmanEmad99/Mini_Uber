using Microsoft.EntityFrameworkCore;
using Mini_Uber;
using Mini_Uber.RequestRide;
using Mini_Uber.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Uber.Data
{
    internal class ApplicationDbContext : DbContext
    {
        // Connection string
        // SQL Server instance
        // Database Name
        //UserName / UserId & password
        public DbSet<User> Users { get; set; }

        public DbSet<Destination> Destinations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost\\MSSQLServer01;Database=MiniUber;Trusted_Connection=True;TrustServerCertificate=True");
                                          //datebase name     //integeratedSecurity=True              
        }                                                                                   //make windows trust the connection
    }
}
