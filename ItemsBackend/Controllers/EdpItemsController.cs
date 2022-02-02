#nullable disable
using ItemsBackend.Data;
using ItemsBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ItemsBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EdpItemsController : ControllerBase
    {
        private readonly ItemsBackendContext _context;

        public EdpItemsController(ItemsBackendContext context)
        {
            _context = context;
        }

        // GET: api/EdpItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EdpItem>>> GetEdpItem()
        {
            return await _context.EdpItem.ToListAsync();
        }

        // GET: api/EdpItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EdpItem>> GetEdpItem(int id)
        {
            var edpItem = await _context.EdpItem.FindAsync(id);

            if (edpItem == null)
            {
                return NotFound();
            }

            return edpItem;
        }

        // PUT: api/EdpItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEdpItem(int id, EdpItem edpItem)
        {
            if (id != edpItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(edpItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EdpItemExists(id))
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

        // POST: api/EdpItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EdpItem>> PostEdpItem(EdpItem edpItem)
        {
            _context.EdpItem.Add(edpItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEdpItem", new { id = edpItem.Id }, edpItem);
        }

        // DELETE: api/EdpItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEdpItem(int id)
        {
            var edpItem = await _context.EdpItem.FindAsync(id);
            if (edpItem == null)
            {
                return NotFound();
            }

            _context.EdpItem.Remove(edpItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EdpItemExists(int id)
        {
            return _context.EdpItem.Any(e => e.Id == id);
        }
    }
}
