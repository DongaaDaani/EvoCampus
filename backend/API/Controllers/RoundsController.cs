using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoundsController : ControllerBase
    {
        private readonly CasinoContext _context;

        public RoundsController(CasinoContext context)
        {
            _context = context;
        }

        // GET: api/Rounds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Round>>> GetRound()
        {
            return await _context.Rounds.ToListAsync();
        }

        // GET: api/Rounds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Round>> GetRound(int id)
        {
            var round = await _context.Rounds.FindAsync(id);

            if (round == null)
            {
                return NotFound();
            }

            return round;
        }

        // PUT: api/Rounds/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRound(int id, Round round)
        {
            if (id != round.RoundId)
            {
                return BadRequest();
            }

            _context.Entry(round).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoundExists(id))
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

        // POST: api/Rounds
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Round>> PostRound(Round round)
        {
            _context.Rounds.Add(round);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRound", new { id = round.RoundId }, round);
        }

        // DELETE: api/Rounds/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Round>> DeleteRound(int id)
        {
            var round = await _context.Rounds.FindAsync(id);
            if (round == null)
            {
                return NotFound();
            }

            _context.Rounds.Remove(round);
            await _context.SaveChangesAsync();

            return round;
        }

        private bool RoundExists(int id)
        {
            return _context.Rounds.Any(e => e.RoundId == id);
        }
    }
}
