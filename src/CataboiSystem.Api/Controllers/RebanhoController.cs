#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CataboiSystem.Domain.Entities;
using CataboiSystem.Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;

namespace CataboiSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RebanhoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RebanhoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Rebanho
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rebanho>>> GetRebanhos()
        {
            return await _context.Rebanhos.ToListAsync();
        }

        // GET: api/Rebanho/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rebanho>> GetRebanho(int id)
        {
            var rebanho = await _context.Rebanhos.FindAsync(id);

            if (rebanho == null)
            {
                return NotFound();
            }

            return rebanho;
        }

        // PUT: api/Rebanho/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRebanho(int id, Rebanho rebanho)
        {
            if (id != rebanho.Id)
            {
                return BadRequest();
            }

            _context.Entry(rebanho).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RebanhoExists(id))
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

        // POST: api/Rebanho
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Rebanho>> PostRebanho(Rebanho rebanho)
        {
            _context.Rebanhos.Add(rebanho);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRebanho", new { id = rebanho.Id }, rebanho);
        }

        // DELETE: api/Rebanho/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRebanho(int id)
        {
            var rebanho = await _context.Rebanhos.FindAsync(id);
            if (rebanho == null)
            {
                return NotFound();
            }

            _context.Rebanhos.Remove(rebanho);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RebanhoExists(int id)
        {
            return _context.Rebanhos.Any(e => e.Id == id);
        }
    }
}
