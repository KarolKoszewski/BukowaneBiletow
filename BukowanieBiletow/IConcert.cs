namespace BukowanieBiletow;

public interface IConcert
{
    string Name { get; }
    DateTime Date { get; }
    string Location { get; }
    int TotalNumberOfSeats { get; }
    int AvailableSeats { get; set; }
    int Price { get; }

    public void bookTicket();
    public void cancleTicket();


}