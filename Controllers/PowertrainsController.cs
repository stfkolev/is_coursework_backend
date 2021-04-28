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
    public class PowertrainsController : ControllerBase
    {
        private readonly RentACarDbContext _context;

        public PowertrainsController(RentACarDbContext context)
        {
            _context = context;
        }

        // GET: api/Powertrains
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Powertrain>>> GetPowertrain()
        {
            return await _context.Powertrain.ToListAsync();
        }

        // GET: api/Powertrains/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Powertrain>> GetPowertrain(long id)
        {
            var powertrain = await _context.Powertrain.FindAsync(id);

            if (powertrain == null)
            {
                return NotFound();
            }

            return powertrain;
        }

        // PUT: api/Powertrains/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPowertrain(long id, Powertrain powertrain)
        {
            if (id != powertrain.Id)
            {
                return BadRequest();
            }

            _context.Entry(powertrain).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PowertrainExists(id))
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

        // POST: api/Powertrains
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Powertrain>> PostPowertrain(Powertrain powertrain)
        {
            _context.Powertrain.Add(powertrain);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPowertrain", new { id = powertrain.Id }, powertrain);
        }

        // DELETE: api/Powertrains/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Powertrain>> DeletePowertrain(long id)
        {
            var powertrain = await _context.Powertrain.FindAsync(id);
            if (powertrain == null)
            {
                return NotFound();
            }

            _context.Powertrain.Remove(powertrain);
            await _context.SaveChangesAsync();

            return powertrain;
        }

        private bool PowertrainExists(long id)
        {
            return _context.Powertrain.Any(e => e.Id == id);
        }
    }
}
