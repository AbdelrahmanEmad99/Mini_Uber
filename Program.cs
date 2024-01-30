using mini_uber;
using Mini_Uber.Connections;
using Mini_Uber.RequestRide;
using Mini_Uber.Tickets;
using Mini_Uber.Users;



while (true)
{
    Console.WriteLine("1. Register");
    Console.WriteLine("2. Login");
    Console.WriteLine("3. Exit");

    Console.Write("Choose an option: ");
    byte choice = byte.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Registration.Register();
            break;
        case 2:
            User user = Login.login();
            if (user != null)
            {
                while (true)
                {
                    Console.WriteLine("1. Request Ride");
                    Console.WriteLine("2. Request Ticket");
                    Console.WriteLine("3. Exit");

                    Console.Write("Choose an option: ");
                    byte choose = byte.Parse(Console.ReadLine());
                    if (choose == 1)
                    {
                        Console.WriteLine("1. Request normal car");
                        Console.WriteLine("2. Request premium car");
                        Console.WriteLine("3. Request bus");
                        Console.WriteLine("4. Request motor bike");
                        Console.WriteLine("5. Back");

                        Console.Write("Choose an option: ");
                        byte requestType = byte.Parse(Console.ReadLine());

                        Navigations nav = new Navigations();
                        if (requestType == 1)
                        {
                            nav.setStrategy(new NormalCar());
                        }
                        else if (requestType == 2)
                        {
                            nav.setStrategy(new PremiumCar());
                        }
                        else if (requestType == 3)
                        {
                            nav.setStrategy(new Bus());
                        }
                        else if (requestType == 4)
                        {
                            nav.setStrategy(new Motorbike());
                        }
                        else if (requestType == 5)
                        {
                            continue;
                        }

                        List<Destination> allDestinations = DataBaseConnection.GetContext().Destinations.ToList();
                        for (int i = 0; i < allDestinations.Count(); i++)
                        {
                            Console.Write((i+1) + ". " );
                            nav.tripDestination(allDestinations[i].Start, allDestinations[i].End);
                        }
                        Console.Write("Choose an option: ");
                        byte selectDestination = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine("the price of the trip is: " + nav.calculatedPrice(allDestinations[selectDestination - 1].KiloMeters));
                        
                        PayStrategy payingProcess = new PayStrategy(user);
                        Console.WriteLine("1. Pay by credit card");
                        Console.WriteLine("2. Pay by Pay Pal");

                        Console.Write("Choose an option: ");
                        byte PaymentType = Convert.ToByte(Console.ReadLine());

                        if(PaymentType == 1)
                        {
                            payingProcess.Payby(new CreditCardPay());
                        }
                        else if(PaymentType == 2)
                        {
                            payingProcess.Payby(new PayPalPay());
                        }

                        payingProcess.setPaying(nav.calculatedPrice(allDestinations[selectDestination - 1].KiloMeters));
                    }
                    else if (choose == 2)
                    {
                        ServerBug serverBug = new ServerBug();
                        AccountBug accountBug = new AccountBug();
                        serverBug.SetNextChain(accountBug);
                        Console.WriteLine("Choose ticket category");
                        Console.WriteLine("- Server Bug");
                        Console.WriteLine("- Account Bug");

                        string ticketCategory = Console.ReadLine();
                        serverBug.Handle(new Ticket(ticketCategory));
                    }
                    else if (choose == 3)
                    {
                        break;
                    }
                }
            }
            break;

        case 3:
            Console.WriteLine("Goodbye!");
            return;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }
}





