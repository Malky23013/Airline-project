using Solid.API;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Services;
using Solid.API.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private readonly IFlightService _flightService;

        public FlightsController(IFlightService userService)
        {
            _flightService = userService;
        }

        // GET: api/<EventsController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_flightService.GetFlights());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var flight = _flightService.GetById(id);
            if (flight is null)
            {
                return NotFound();
            }
            return Ok(flight);
        }
        //POST api/<EventsController>
        [HttpPost]
        public void Post([FromBody] Flight newE)
        {
            _flightService.Add(new Flight { Company = newE.Company, Destination = newE.Destination, Source = newE.Source });
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public ActionResult<Flight> Put(int id, [FromBody] Flight updateEvent)
        {
          return Ok(_flightService.UpdateFlight(id, updateEvent));  
        }

        //// DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
             _flightService.DeleteFlight(id);
        }
    }
    
}

