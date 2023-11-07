using Airline.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Airline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private static List<Flight> flights = new List<Flight> { new Flight {Company="El Al",Destination="USA",Source="IL" },
             new Flight {  Company="American Airlines",Destination="America",Source="IL"}
        , new Flight {Company = "British Airways", Destination = "England", Source = "Poland" } };

        // GET: api/<EventsController>
        [HttpGet]
        public IEnumerable<Flight> Get()
        {
            return flights;
        }
        [HttpGet("{id}")]
        public ActionResult<Flight> Get(int id)
        {
            var eve = flights.Find(e => e.Id == id);
            if (eve == null)
            {

                return NotFound();
            }
            return eve;
        }
        // POST api/<EventsController>
        [HttpPost]
        public void Post([FromBody] Flight newE)
        {
            flights.Add(new Flight { Company = newE.Company, Destination = newE.Destination, Source = newE.Source });
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public ActionResult<Flight> Put(int id, [FromBody] Flight updateEvent)
        {
            var eve = flights.Find(e => e.Id == id);
            if (eve == null)
            {
                return NotFound();
            }
            eve.Company = updateEvent.Company;
            eve.Destination = updateEvent.Destination;
            eve.Source = updateEvent.Source;

            return eve;
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public ActionResult<Flight> Delete(int id)
        {
            var eve = flights.Find(e => e.Id == id);
            if (eve == null)
            {
                return NotFound();
            }
            else
            {
                flights.Remove(eve);
                return NoContent();
            }
        }
        }
    
}

