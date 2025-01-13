namespace BukowanieBiletow;

public class Concert : IConcert
{
    public string Name { get; }
    public DateTime Date { get; }
    public string Location { get; }
    public int TotalNumberOfSeats { get; }
    public int AvailableSeats { get; }
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
}