using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIExamen.Models;

namespace APIExamen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiendasController : ControllerBase
    {
        private readonly DbA97bcaDsiContext _context;

        public TiendasController(DbA97bcaDsiContext context)
        {
            _context = context;
        }

        // GET: api/Tiendas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tienda>>> GetTiendas()
        {
          if (_context.Tiendas == null)
          {
              return NotFound();
          }
            return await _context.Tiendas.ToListAsync();
        }

        // GET: api/Tiendas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tienda>> GetTienda(int id)
        {
          if (_context.Tiendas == null)
          {
              return NotFound();
          }
            var tienda = await _context.Tiendas.FindAsync(id);

            if (tienda == null)
            {
                return NotFound();
            }

            return tienda;
        }

        // PUT: api/Tiendas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTienda(int id, Tienda tienda)
        {
            if (id != tienda.IdTTienda)
            {
                return BadRequest();
            }

            _context.Entry(tienda).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TiendaExists(id))
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

        // POST: api/Tiendas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tienda>> PostTienda(Tienda tienda)
        {
          if (_context.Tiendas == null)
          {
              return Problem("Entity set 'DbA97bcaDsiContext.Tiendas'  is null.");
          }
            _context.Tiendas.Add(tienda);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTienda", new { id = tienda.IdTTienda }, tienda);
        }

        // DELETE: api/Tiendas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTienda(int id)
        {
            if (_context.Tiendas == null)
            {
                return NotFound();
            }
            var tienda = await _context.Tiendas.FindAsync(id);
            if (tienda == null)
            {
                return NotFound();
            }

            _context.Tiendas.Remove(tienda);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TiendaExists(int id)
        {
            return (_context.Tiendas?.Any(e => e.IdTTienda == id)).GetValueOrDefault();
        }
    }
}
