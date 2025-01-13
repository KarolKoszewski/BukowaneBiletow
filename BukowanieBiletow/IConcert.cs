namespace BukowanieBiletow;

public interface IConcert
{
    string Name { get; }
    DateTime Date { get; }
    string Location { get; }
    int TotalNumberOfSeats { get; }
    int AvailableSeats { get; }
    int Price { get; }

    public void bookTicket();
}