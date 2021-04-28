using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentACarBackend;
using RentACarBackend.Models.Cars;

namespace RentACarBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransmissionsController : ControllerBase
    {
        private readonly RentACarDbContext _context;

        public TransmissionsController(RentACarDbContext context)
        {
            _context = context;
        }

        // GET: api/Transmissions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Transmission>>> GetTransmission()
        {
            return await _context.Transmission.ToListAsync();
        }

        // GET: api/Transmissions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Transmission>> GetTransmission(long id)
        {
            var transmission = await _context.Transmission.FindAsync(id);

            if (transmission == null)
            {
                return NotFound();
            }

            return transmission;
        }

        // PUT: api/Transmissions/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransmission(long id, Transmission transmission)
        {
            if (id != transmission.Id)
            {
                return BadRequest();
            }

            _context.Entry(transmission).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransmissionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Transmissions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Transmission>> PostTransmission(Transmission transmission)
        {
            _context.Transmission.Add(transmission);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTransmission", new { id = transmission.Id }, transmission);
        }

        // DELETE: api/Transmissions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Transmission>> DeleteTransmission(long id)
        {
            var transmission = await _context.Transmission.FindAsync(id);
            if (transmission == null)
            {
                return NotFound();
            }

            _context.Transmission.Remove(transmission);
            await _context.SaveChangesAsync();

            return transmission;
        }

        private bool TransmissionExists(long id)
        {
            return _context.Transmission.Any(e => e.Id == id);
        }
    }
}
