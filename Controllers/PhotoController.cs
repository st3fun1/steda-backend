using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Steda_backend.Models;
using Steda_backend.Authentication;

namespace Steda_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        private readonly AppDbContext _db;

        public PhotoController(AppDbContext db)
        {
            _db = db;
        }

        // GET: api/Photo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PhotoDTO>>> GetPhotos()
        {
            return await _db.Photos.Select( x => ItemToDTO(x)).ToListAsync();
        }

        // GET: api/Photo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Photo>> GetPhoto(int id)
        {
            var photo = await _db.Photos.FindAsync(id);

            if (photo == null)
            {
                return NotFound();
            }

            return photo;
        }

        // PUT: api/Photo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPhoto(int id, Photo photo)
        {
            if (id != photo.PhotoID)
            {
                return BadRequest();
            }

            _db.Entry(photo).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhotoExists(id))
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

        // POST: api/Photo
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Photo>> PostPhoto(Photo photo)
        {
            _db.Photos.Add(photo);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPhoto), new { id = photo.PhotoID }, photo);
        }

        // DELETE: api/Photo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePhoto(int id)
        {
            var photo = await _db.Photos.FindAsync(id);
            if (photo == null)
            {
                return NotFound();
            }

            _db.Photos.Remove(photo);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool PhotoExists(int id)
        {
            return _db.Photos.Any(e => e.PhotoID == id);
        }

        private static PhotoDTO ItemToDTO(Photo photo) =>
            new PhotoDTO
            {
                Name = photo.Name,
                Url = photo.Url,
                Description = photo.Description
            };
    }
}
