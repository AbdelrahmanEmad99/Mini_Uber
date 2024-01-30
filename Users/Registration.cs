using Mini_Uber.Connections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Uber.Users
{
    internal class Registration
    {
        public static void Register()
        {
            // if the user is exist 
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            Console.Write("Enter your balance in credit card: ");
            double creditCardBalance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your balance in Pay Pal: ");
            double payPalBalance = Convert.ToDouble(Console.ReadLine());

            User user = DataBaseConnection.GetContext().Users.FirstOrDefault(u => u.Username == username);
            if (user != null)
            {
                Console.WriteLine("User is exist ");
            }
            else
            {
                DataBaseConnection.GetContext().Users.Add(new User() { Username = username , Password = password , MoneyInCreditCard = creditCardBalance, MoneyInPayPal= payPalBalance });
                DataBaseConnection.GetContext().SaveChanges();
                Console.WriteLine("Registration successful!");
            }
        }
    }
}
