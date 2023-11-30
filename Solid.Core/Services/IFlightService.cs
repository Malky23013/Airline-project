using Solid.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IFlightService
    {
        List<Flight> GetFlights();

        Flight GetById(int id);
        Flight Add(Flight flight);
        public void DeleteFlight(int id);
        public Flight UpdateFlight(int id, Flight flight);
    }
}
