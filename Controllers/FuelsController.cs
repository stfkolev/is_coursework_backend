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
    public class FuelsController : ControllerBase
    {
        private readonly RentACarDbContext _context;

        public FuelsController(RentACarDbContext context)
        {
            _context = context;
        }

        // GET: api/Fuels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fuel>>> GetFuel()
        {
            return await _context.Fuel.ToListAsync();
        }

        // GET: api/Fuels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Fuel>> GetFuel(long id)
        {
            var fuel = await _context.Fuel.FindAsync(id);

            if (fuel == null)
            {
                return NotFound();
            }

            return fuel;
        }

        // PUT: api/Fuels/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFuel(long id, Fuel fuel)
        {
            if (id != fuel.Id)
            {
                return BadRequest();
            }

            _context.Entry(fuel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FuelExists(id))
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

        // POST: api/Fuels
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Fuel>> PostFuel(Fuel fuel)
        {
            _context.Fuel.Add(fuel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFuel", new { id = fuel.Id }, fuel);
        }

        // DELETE: api/Fuels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Fuel>> DeleteFuel(long id)
        {
            var fuel = await _context.Fuel.FindAsync(id);
            if (fuel == null)
            {
                return NotFound();
            }

            _context.Fuel.Remove(fuel);
            await _context.SaveChangesAsync();

            return fuel;
        }

        private bool FuelExists(long id)
        {
            return _context.Fuel.Any(e => e.Id == id);
        }
    }
}
