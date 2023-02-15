

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using oop.AppDbContext;
using oop.Models;

namespace oop.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {

        private readonly RecordDbContext context;
        public StocksController(RecordDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<List<StockDTO>> GetStocks()
        {
            var stocks = await context.Stocks.Include(c => c.Record).Include(c => c.Record.Artist).Include(c => c.Record.Tracks).ToListAsync();
            var Dtos = new List<StockDTO>();
            stocks.ForEach(stock => Dtos.Add(new StockDTO(stock)));

            return Dtos;
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> PostStocks(Stock data)
        {
            if (data == null || !ModelState.IsValid)
            {
                return Problem(statusCode: 400, title: "Invalid form");
            }
            this.context.Add(data);
            await this.context.SaveChangesAsync();
            return Ok(data);
        }
    }

}
