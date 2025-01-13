namespace BukowanieBiletow;

public class Ticket
{
    public Concert Concert { get; set; }
    public int Price { get; set; }
    public int SeatNumber { get; set; }

    public Ticket(Concert concert, int price, int seatNumber)
    {
        this.Concert = concert;
        this.Price = price;
        this.SeatNumber = seatNumber;
    }
}