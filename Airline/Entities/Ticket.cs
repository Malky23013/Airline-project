namespace Airline.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Company { get; set; }
        public DateTime Date { get; set; }

        public Ticket(int id, int price, string company, DateTime date)
        {
            Id = id;
            Price = price;
            Company = company;
            Date = date;
        }

        public Ticket()
        {
        }
    }
}
