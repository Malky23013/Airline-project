using Airline.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Airline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengersController : ControllerBase
    {
        private static List<Passenger> passengers = new List<Passenger> { new Passenger {Id=0,FirstName="Malky",LastName="Zilberberg",Age=20 },
             new Passenger {Id=0,FirstName="Sara",LastName="Topo",Age=20 }
        , new Passenger {Id=0,FirstName="Racheli",LastName="Rapaport",Age=19 }};

        // GET: api/<EventsController>
        [HttpGet]
        public IEnumerable<Passenger> Get()
        {
            return passengers;
        }
        [HttpGet("{id}")]
        public ActionResult<Passenger> Get(int id)
        {
            var eve = passengers.Find(e => e.Id == id);
            if (eve == null)
            {

                return NotFound();
            }
            return eve;
        }
        // POST api/<EventsController>
        [HttpPost]
        public void Post([FromBody] Passenger newE)
        {
            passengers.Add(new Passenger { Id = newE.Id, FirstName = newE.FirstName, LastName = newE.LastName, Age = newE.Age });
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public ActionResult<Passenger> Put(int id, [FromBody] Passenger updateEvent)
        {
            //find the object by id
            var eve = passengers.Find(e => e.Id == id);
            if (eve == null)
            {
                return NotFound();
            }
            else
            {

                eve.LastName = updateEvent.LastName;
                eve.Age = updateEvent.Age;
                eve.FirstName = updateEvent.FirstName;
                eve.Id = updateEvent.Id;
            }
            return eve;
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public ActionResult<Passenger> Delete(int id)
        {
            var eve = passengers.Find(e => e.Id == id);
            if (eve == null)
            {
                return NotFound();
            }
            passengers.Remove(eve);
            return NoContent();
        }
    }
}
