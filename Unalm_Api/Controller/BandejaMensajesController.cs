using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Unalm_Api.Models;
using Unalm_Api.Data;

namespace Unalm_Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BandejaMensajesController : ControllerBase
    {
        private readonly unalmContext _context;

        public BandejaMensajesController(unalmContext context)
        {
            _context = context;
        }

        // GET: api/BandejaMensajes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mensaje>>> GetBandejaMensajes()
        {
            return await _context.BandejaMensajes.ToListAsync();
        }

        // GET: api/BandejaMensajes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mensaje>> GetBandejaMensaje(ulong id)
        {
            var mensaje = await _context.BandejaMensajes.FindAsync(id);

            if (mensaje == null)
            {
                return NotFound();
            }

            return mensaje;
        }

        // PUT: api/BandejaMensajes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBandejaMensaje(ulong id, Mensaje mensaje)
        {
            if (id != mensaje.Id)
            {
                return BadRequest();
            }

            _context.Entry(mensaje).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BandejaMensajeExists(id))
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

        // POST: api/BandejaMensajes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Mensaje>> PostBandejaMensaje(Mensaje mensaje)
        {
            _context.BandejaMensajes.Add(mensaje);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBandejaMensaje", new { id = mensaje.Id }, mensaje);
        }

        // DELETE: api/BandejaMensajes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBandejaMensaje(ulong id)
        {
            var mensaje = await _context.BandejaMensajes.FindAsync(id);
            if (mensaje == null)
            {
                return NotFound();
            }

            _context.BandejaMensajes.Remove(mensaje);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BandejaMensajeExists(ulong id)
        {
            return _context.BandejaMensajes.Any(e => e.Id == id);
        }
    }
}
