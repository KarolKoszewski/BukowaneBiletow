namespace BukowanieBiletow;

public interface IConcert
{
    string Name { get; }
    DateTime Date { get; }
    string Location { get; }
    int TotalNumberOfSeats { get; }
    int AvailableSeats { get; set; }
    int Price { get; }

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