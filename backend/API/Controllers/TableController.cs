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
    public class TableController : ControllerBase
    {
        private readonly CasinoContext _context;

        public TableController(CasinoContext context)
        {
            _context = context;
        }

        // GET: api/Table
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameSession>>> GetGameSession()
        {
            return await _context.GameSessions.ToListAsync();
        }

        // GET: api/GameSessions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GameSession>> GetGameSession(int id)
        {
            var gameSession = await _context.GameSessions.FindAsync(id);

            if (gameSession == null)
            {
                return NotFound();
            }

            return gameSession;
        }

        // PUT: api/GameSessions/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGameSession(int id, GameSession gameSession)
        {
            if (id != gameSession.GameSessionId)
            {
                return BadRequest();
            }

            _context.Entry(gameSession).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GameSessionExists(id))
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

        // POST: api/GameSessions
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<GameSession>> PostGameSession(GameSession gameSession)
        {
            _context.GameSessions.Add(gameSession);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGameSession", new { id = gameSession.GameSessionId }, gameSession);
        }

        // DELETE: api/GameSessions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GameSession>> DeleteGameSession(int id)
        {
            var gameSession = await _context.GameSessions.FindAsync(id);
            if (gameSession == null)
            {
                return NotFound();
            }

            _context.GameSessions.Remove(gameSession);
            await _context.SaveChangesAsync();

            return gameSession;
        }

        private bool GameSessionExists(int id)
        {
            return _context.GameSessions.Any(e => e.GameSessionId == id);
        }
    }
}
