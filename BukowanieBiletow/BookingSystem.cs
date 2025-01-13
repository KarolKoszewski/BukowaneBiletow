namespace BukowanieBiletow;

public class BookingSystem
{
       private List<OnLineConcert> onlineConcerts = new List<OnLineConcert>();
       private List<Concert> concerts = new List<Concert>();
       private List<VipConcert> vipConcerts = new List<VipConcert>();
       private List<PrivateConcert> privateConcerts = new List<PrivateConcert>();

       //Koncert online
       public void AddOnlineConcert(OnLineConcert concert)
       {
              onlineConcerts.Add(concert);
              Console.WriteLine($"Added online concert: {concert.Name}!");
       }

       public void ShowOnlineConcerts()
       {
              foreach (var concert in onlineConcerts)
              {
                     Console.WriteLine($"Name: {concert.Name}, Date: {concert.Date}, Location: {concert.Location}, Price: {concert.Price}, Available Seats: {concert.AvailableSeats}");
              }
       }
       
       //Koncert Norlmany
       public void AddNormalConcert(Concert concert)
       {
              concerts.Add(concert);
              Console.WriteLine($"Added normal concert: {concert.Name}!");
       }

       public void ShowNormalConcerts()
       {
              foreach (var concert in concerts)
              {
                     Console.WriteLine($"Name: {concert.Name}, Date: {concert.Date}, Location: {concert.Location}, Price: {concert.Price}, Available Seats: {concert.AvailableSeats}");
              }
       }
       
       //Koncert Vip
       public void AddVipConcert(VipConcert concert)
       {
              vipConcerts.Add(concert);
              Console.WriteLine($"Added vip concert: {concert.Name}!");
       }

       public void ShowVipConcerts()
       {
              foreach (var concert in vipConcerts)
              {
                     Console.WriteLine($"Name: {concert.Name}, Date: {concert.Date}, Location: {concert.Location}, Price: {concert.Price}, Available Seats: {concert.AvailableSeats}");
              }
       }
       
       //Koncert prywatny
       public void AddPrivateConcert(PrivateConcert concert)
       {
              privateConcerts.Add(concert);
              Console.WriteLine($"Added private concert: {concert.Name}!");
       }

       public void ShowPrivateConcerts()
       {
              foreach (var concert in privateConcerts)
              {
                     Console.WriteLine($"Name: {concert.Name}, Date: {concert.Date}, Location: {concert.Location}, Price: {concert.Price}, Available Seats: {concert.AvailableSeats}");
              }
       }
       
}