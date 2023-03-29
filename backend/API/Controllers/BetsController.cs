﻿using System;
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
    public class BetsController : ControllerBase
    {
        private readonly CasinoContext _context;

        public BetsController(CasinoContext context)
        {
            _context = context;
        }

        // GET: api/Bets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bet>>> GetBets()
        {
            return await _context.Bets.ToListAsync();
        }

        // GET: api/Bets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bet>> GetBet(int id)
        {
            var bet = await _context.Bets.FindAsync(id);

            if (bet == null)
            {
                return NotFound();
            }

            return bet;
        }

        // PUT: api/Bets/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBet(int id, Bet bet)
        {
            if (id != bet.BetId)
            {
                return BadRequest();
            }

            _context.Entry(bet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BetExists(id))
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

        // POST: api/Bets
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Bet>> PostBet(Bet bet)
        {
            _context.Bets.Add(bet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBet", new { id = bet.BetId }, bet);
        }

        // DELETE: api/Bets/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Bet>> DeleteBet(int id)
        {
            var bet = await _context.Bets.FindAsync(id);
            if (bet == null)
            {
                return NotFound();
            }

            _context.Bets.Remove(bet);
            await _context.SaveChangesAsync();

            return bet;
        }

        private bool BetExists(int id)
        {
            return _context.Bets.Any(e => e.BetId == id);
        }
    }
}
