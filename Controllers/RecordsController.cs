

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using oop.AppDbContext;
using oop.Models;

namespace oop.Controllers {

[Route("api/[controller]")]
[ApiController]
public class RecordsController: ControllerBase {

  private readonly RecordDbContext context;
  public RecordsController(RecordDbContext context) {
    this.context = context;
  }

  [HttpGet]
  public async Task<List<RecordDTO>> GetRecords() {
    var records = await context.Records.Include(c => c.Artist).Include(c => c.Tracks).ToListAsync();
    var Dtos = new List<RecordDTO>();
    records.ForEach(record => Dtos.Add(new RecordDTO(record)));

    return Dtos.ToList();
  }
}

}
