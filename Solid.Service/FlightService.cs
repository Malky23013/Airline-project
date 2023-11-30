using Solid.API.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class FlightService:IFlightService
    {
        private readonly IFlightRepository _flightRepository;

        public FlightService(IFlightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }

        public List<Flight> GetFlights()
        {
            return _flightRepository.GetFlights();
        }

        public Flight GetById(int id)
        {
            return _flightRepository.GetById(id);
        }
        public Flight Add(Flight flight)
        {
            return _flightRepository.AddFlight(flight);
        }

        public void DeleteFlight(int id)
        {
            _flightRepository.DeleteFlight(id);
        }

        public Flight UpdateFlight(int id, Flight flight)
        {
            return _flightRepository.UpdateFlight(id, flight);
        }
    }
}
