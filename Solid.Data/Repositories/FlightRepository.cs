using Solid.API.Entities;
using Solid.Core.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class FlightRepository : IFlightRepository
    {
        private readonly DataContext _context;
        public FlightRepository(DataContext context)
        {
            _context = context;
        }
        public Flight AddFlight(Flight flight)
        {
            _context.FlightsList.Add(flight);
            return flight;
        }

        public void DeleteFlight(int id)
        {
            _context.FlightsList.Remove(_context.FlightsList.Find(u => u.Id == id));
        }

        public Flight GetById(int id)
        {
            return _context.FlightsList.Find(u => u.Id == id);
        }

        public List<Flight> GetFlights()
        {
            return _context.FlightsList;
        }

        public Flight UpdateFlight(int id, Flight flight)
        {
            var updateFlight = _context.FlightsList.Find(u => u.Id == id);
            if (updateFlight != null)
            {
                //updateFlight.Id= flight.Id;
                updateFlight.Company = flight.Company;
                updateFlight.Destination = flight.Destination;
                updateFlight.Source = flight.Source;
                return updateFlight;
            }
            return null;
        }
    }
}
