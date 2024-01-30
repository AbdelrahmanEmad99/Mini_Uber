using Mini_Uber.Connections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Uber.Users
{
    internal class Login
    {
        public static User login()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            User user = DataBaseConnection.GetContext().Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                Console.WriteLine("Login successful!");
                return user;
            }
            else
            {
                Console.WriteLine("Login failed. Invalid credentials.");
                return null;
            }
        }
    }
}
