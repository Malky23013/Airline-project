using Solid.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class DataContext
    {
        public List<Flight> FlightsList { get; set; }
        public List<Passenger> passengers { get; set; }
        public List<Ticket> tickets { get; set; }

        public DataContext()
        {
            FlightsList =  new List<Flight> { new Flight {Company="El Al",Destination="USA",Source="IL" },
             new Flight {  Company="American Airlines",Destination="America",Source="IL"}
        , new Flight {Company = "British Airways", Destination = "England", Source = "Poland" } };
              passengers = new List<Passenger> { new Passenger {Id=0,FirstName="Malky",LastName="Zilberberg",Age=20 },
             new Passenger {Id=1,FirstName="Sara",LastName="Topo",Age=20 }
        , new Passenger {Id=2,FirstName="Racheli",LastName="Rapaport",Age=19 }};
             tickets = new List<Ticket> { new Ticket {Id=0,Company="EL AL",Price=3000,Date=new DateTime(2023,09,10) },
            new Ticket {Id=1,Company="American Airlines",Price=2900,Date=new DateTime(2023,05,04)  }
        ,  new Ticket {Id=2,Company="United",Price=2700,Date=new DateTime(2023,06,10) }};

    }
}
}
