namespace BukowanieBiletow;

public class Concert : IConcert
{
    public string Name { get; }
    public DateTime Date { get; }
    public string Location { get; }
    public int TotalNumberOfSeats { get; }
    public int AvailableSeats { get; set; }
    public int Price { get; }

    public Concert(string name, DateTime date, string location, int totalNumberOfSeats, int availableSeats, int price)
    {
        Name = name;
        Date = date;
        Location = location;
        TotalNumberOfSeats = totalNumberOfSeats;
        AvailableSeats = availableSeats;
        Price = price;
    }

    public void bookTicket()
    {
        if (AvailableSeats > 0)
        {
            Console.WriteLine("How many tickets do you want to book?");
            int numberOfTickets = int.Parse(Console.ReadLine());
            AvailableSeats=AvailableSeats-numberOfTickets;
            Console.WriteLine($"You've booked: {numberOfTickets}! Available seats: {AvailableSeats}");
            
        }
        else
        {
            Console.WriteLine("No available seats!");
        }
        
    }
}