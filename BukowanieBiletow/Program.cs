// See https://aka.ms/new-console-template for more information

using BukowanieBiletow;

internal class Program
{
    public static void Main(string[] args)
    {
        BookingSystem bookingSystem = new BookingSystem();
        
        OnLineConcert concert1 = new OnLineConcert("WWA Clout", new DateTime(2025,3,15),"Onilne",100,100,100);
        Concert concert2 = new Concert("Olsztyn W", new DateTime(2025, 4, 15), "Olsztyn", 100, 20, 100);
        VipConcert concert3 = new VipConcert("Berlin", new DateTime(2025, 4, 15), "Berlin", 50, 10, 500);
        PrivateConcert concert4 = new PrivateConcert("Krakow", new DateTime(2025, 4, 15), "Krakow", 100, 500,0);
        
        bookingSystem.AddOnlineConcert(concert1);
        bookingSystem.AddNormalConcert(concert2);
        bookingSystem.AddVipConcert(concert3);
        bookingSystem.AddPrivateConcert(concert4);
        
        Console.WriteLine("select the type of user you are:(1-User, 2-VipUser, 3-Admin)");
        int userChoice = int.Parse(Console.ReadLine());

        if (userChoice == 1)
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Buy ticket");
            Console.WriteLine("2. Cancel ticket");
            Console.WriteLine("3. Show available tickets");
            Console.WriteLine("4. Exit");
            
            int userChoice2 = int.Parse(Console.ReadLine());
            if (userChoice2 == 1){
                
                Console.WriteLine("What type of concert do you want to buy?");
                Console.WriteLine("1. Online");
                Console.WriteLine("2. Normal");
                Console.WriteLine("3. Exit");
                int userChoice3 = int.Parse(Console.ReadLine());

                if (userChoice3 == 1) {
                    Console.WriteLine("These are the available online tickets:");
                    bookingSystem.ShowOnlineConcerts();
                    Console.WriteLine("Are you intresed in buying a ticket?");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    concert1.bookTicket();
                    
                }
                else if (userChoice3 == 2) {
                    
                    Console.WriteLine("These are the available tickets:");
                    bookingSystem.ShowNormalConcerts();
                    Console.WriteLine("Are you intresed in buying a ticket?");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    concert2.bookTicket();
                    
                }
                else if (userChoice3 == 3) {
                    
                    Environment.Exit(0);
                    
                }
                else{
                    
                    Console.WriteLine("error");
                    Environment.Exit(0);
                    
                }
                
            }
            else if (userChoice2 == 2) {
                Console.WriteLine("What type of concert do you want to cancle?(Online or Normal)");
                string userChoiceCancle = Console.ReadLine();
                if (userChoiceCancle == "Online") {
                    concert1.cancleTicket();
                }
                else if (userChoiceCancle == "Normal") {
                    concert2.cancleTicket();
                }
            }
            else if (userChoice2 == 3) {
                bookingSystem.ShowOnlineConcerts();
                bookingSystem.ShowNormalConcerts();
            }
            else if (userChoice2 == 4) {
                Environment.Exit(0);
            }
        }
        else if (userChoice == 2) {
            
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Buy ticket");
            Console.WriteLine("2. Cancel ticket");
            Console.WriteLine("3. Show available tickets");
            Console.WriteLine("4. Exit");
            
            int userChoice3 = int.Parse(Console.ReadLine());

            if (userChoice3 == 1)
            {
                Console.WriteLine("What type of concert do you want to buy?");
                Console.WriteLine("1. Online");
                Console.WriteLine("2. Normal");
                Console.WriteLine("3. Vip");
                Console.WriteLine("4. Exit");
                int userChoice4 = int.Parse(Console.ReadLine());

                if (userChoice4 == 1) {
                    
                    Console.WriteLine("These are the available online tickets:");
                    bookingSystem.ShowOnlineConcerts();
                    Console.WriteLine("Are you intresed in buying a ticket?");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    concert1.bookTicket();
                    
                }
                else if (userChoice4 == 2) {
                    
                    Console.WriteLine("These are the available tickets:");
                    bookingSystem.ShowNormalConcerts();
                    Console.WriteLine("Are you intresed in buying a ticket?");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    concert2.bookTicket();
                    
                }
                else if (userChoice4 == 3) {
                    Console.WriteLine("These are the available VIP tickets:");
                    bookingSystem.ShowVipConcerts();
                }
                else if (userChoice4 == 4) {
                    Environment.Exit(0);
                }
                
            }
            else if (userChoice3 == 2) {
                
                Console.WriteLine("What type of concert do you want to cancle?(Online or Normal)");
                string userChoiceCancle = Console.ReadLine();
                if (userChoiceCancle == "Online") {
                    concert1.cancleTicket();
                }
                else if (userChoiceCancle == "Normal") {
                    concert2.cancleTicket();
                }
                else if (userChoiceCancle == "Vip")
                {
                    concert3.cancleTicket();
                }
            }
            else if (userChoice3 == 3) {
                bookingSystem.ShowOnlineConcerts();
                bookingSystem.ShowNormalConcerts();
                bookingSystem.ShowVipConcerts();
                bookingSystem.ShowPrivateConcerts();
                
            }
            else if (userChoice3 == 4)
            {
                Environment.Exit(0);
            }
        }
        else if (userChoice == 3) {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Show available tickets");
            Console.WriteLine("2. Add Concert");
            Console.WriteLine("3. Exit");
            
            int userChoice4 = int.Parse(Console.ReadLine());

            if (userChoice4 == 1)
            {
                bookingSystem.ShowOnlineConcerts();
                bookingSystem.ShowNormalConcerts();
                bookingSystem.ShowVipConcerts();
                bookingSystem.ShowPrivateConcerts();
            }
            else if (userChoice4 == 2)
            {
                Console.WriteLine("What type of concert do you want to add(1-Online,2-Normal,3-Vip,4-Private)");
                int userChoice5 = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Enter concert name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter concert date (yyyy-MM-dd):");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Enter location:");
                string location = Console.ReadLine();

                Console.WriteLine("Enter total number of seats:");
                int totalSeats = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter ticket price:");
                int price = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Enter amount of tickets:");
                int amount = int.Parse(Console.ReadLine());

                if (userChoice5 == 1)
                {
                    OnLineConcert newConcertOnline = new OnLineConcert(name, date, location, totalSeats, price, amount);
                }
                else if (userChoice5 == 2)
                {
                    Concert newNormalConcert = new Concert(name, date, location, totalSeats, amount, price);
                }
                else if (userChoice5 == 3)
                {
                    VipConcert newVipConcert = new VipConcert(name, date, location, totalSeats, amount, price);
                }
                else if (userChoice5 == 4)
                {
                    PrivateConcert newPrivateConcert = new PrivateConcert(name, date, location, totalSeats, price, amount);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    Environment.Exit(0);
                }
            }
            else if (userChoice4 == 3)
            {
                Environment.Exit(0);
            }
        }
    }
}