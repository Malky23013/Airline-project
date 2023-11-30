using Solid.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IFlightRepository
    {
        List<Flight> GetFlights();

        Flight GetById(int id);

        Flight AddFlight(Flight flight);

        Flight UpdateFlight(int id, Flight flight);

        void DeleteFlight(int id);
    }
}
