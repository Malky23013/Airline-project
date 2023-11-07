using Airline.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net.Sockets;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Airline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private static List<Ticket> tickets = new List<Ticket> { new Ticket {Id=0,Company="EL AL",Price=3000,Date=new DateTime(2023,09,10) },
            new Ticket {Id=0,Company="American Airlines",Price=2900,Date=new DateTime(2023,05,04)  }
        ,  new Ticket {Id=0,Company="United",Price=2700,Date=new DateTime(2023,06,10) }};

        // GET: api/<EventsController>
        [HttpGet]
        public IEnumerable<Ticket> Get()
        {
            return tickets;
        }
        [HttpGet("{id}")]
        public ActionResult<Ticket> Get(int id)
        {
            var eve = tickets.Find(e => e.Id == id);
            if (eve == null)
            {
                return NoContent();
            }
            return eve;
        }
        // POST api/<EventsController>
        [HttpPost]
        public void Post([FromBody] Ticket newE)
        {
            tickets.Add(new Ticket { Id = newE.Id, Company = newE.Company, Date = newE.Date, Price = newE.Price });
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public ActionResult<Ticket> Put(int id, [FromBody] Ticket updateEvent)
        {
            //find the object by id
            var eve = tickets.Find(e => e.Id == id);
            if (eve == null)
            {
                return NoContent();
            }
            eve.Id = updateEvent.Id;
            eve.Company = updateEvent.Company;
            eve.Price = updateEvent.Price;
            eve.Date = updateEvent.Date;
            return eve;
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public ActionResult<Ticket> Delete(int id)
        {
            var eve = tickets.Find(e => e.Id == id);
            if (eve == null)
            {
                return NotFound();
            }
            tickets.Remove(eve);
            return NoContent();
        }
    }
}
