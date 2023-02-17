

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using oop.AppDbContext;
using oop.Models;

namespace oop.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {

        private readonly RecordDbContext context;
        public ArtistsController(RecordDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<List<Artist>> GetArtists()
        {
            var artists = await context.Artists.ToListAsync();
            return artists;
        }
    }

}
