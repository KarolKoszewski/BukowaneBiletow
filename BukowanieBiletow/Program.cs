// See https://aka.ms/new-console-template for more information

using BukowanieBiletow;

internal class Program
{
    public static void Main(string[] args)
    {
        BookingSystem bookingSystem = new BookingSystem();
        OnLineConcert concert1 = new OnLineConcert("WWA Clout", new DateTime(2025,3,15),"Onilne",100,100,100);
        bookingSystem.AddOnlineConcert(concert1);

        Concert concert2 = new Concert("Olsztyn W", new DateTime(2025, 4, 15), "Olsztyn", 100, 20, 100);
        Concert concert3 = new Concert("Olsztyn XYZ", new DateTime(2026, 10, 15), "Olsztyn", 100, 30, 100);

        bookingSystem.AddNormalConcert(concert2);
        bookingSystem.AddNormalConcert(concert3);
        
    }
}