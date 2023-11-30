using Solid.API;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Services;
using Solid.API.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Airline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengersController : ControllerBase
    {

        private readonly IPassengerService _passengerService;

        public PassengersController(IPassengerService userService)
        {
            _passengerService = userService;
        }

        // GET: api/<EventsController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_passengerService.GetPassengers());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var flight = _passengerService.GetById(id);
            if (flight is null)
            {
                return NotFound();
            }
            return Ok(flight);
        }
        // POST api/<EventsController>
        [HttpPost]
        public void Post([FromBody] Passenger newE)
        {
            _passengerService.Add(new Passenger { Id = newE.Id, FirstName = newE.FirstName, LastName = newE.LastName, Age = newE.Age });
        }

        //// PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public ActionResult<Passenger> Put(int id, [FromBody] Passenger updateEvent)
        {
           return Ok(_passengerService.UpdatePassenger(id, updateEvent));   
      
        }

        //// DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
         _passengerService.DeletePassenger(id);
        }
    }
}
