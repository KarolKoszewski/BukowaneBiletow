namespace BukowanieBiletow;

public class VipConcert : IConcert
{
    public string Name { get; }
    public DateTime Date { get; }
    public string Location { get; }
    public int TotalNumberOfSeats { get; }
    public int AvailableSeats { get; }
    public int Price { get; }
    public void bookTicket()
    {
        throw new NotImplementedException();
    }
}