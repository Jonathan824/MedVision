﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MedVision.Context;
using MedVision.Entities;

namespace MedVision.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CitasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Citas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cita>>> GetCita()
        {
          if (_context.Cita == null)
          {
              return NotFound();
          }
            return await _context.Cita.ToListAsync();
        }

        // GET: api/Citas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cita>> GetCita(int id)
        {
          if (_context.Cita == null)
          {
              return NotFound();
          }
            var cita = await _context.Cita.FindAsync(id);

            if (cita == null)
            {
                return NotFound();
            }

            return cita;
        }

        // PUT: api/Citas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCita(int id, Cita cita)
        {
            if (id != cita.id)
            {
                return BadRequest();
            }

            _context.Entry(cita).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CitaExists(id))
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

        // POST: api/Citas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cita>> PostCita(Cita cita)
        {
          if (_context.Cita == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Cita'  is null.");
          }
            _context.Cita.Add(cita);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCita", new { id = cita.id }, cita);
        }

        // DELETE: api/Citas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCita(int id)
        {
            if (_context.Cita == null)
            {
                return NotFound();
            }
            var cita = await _context.Cita.FindAsync(id);
            if (cita == null)
            {
                return NotFound();
            }

            _context.Cita.Remove(cita);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CitaExists(int id)
        {
            return (_context.Cita?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
