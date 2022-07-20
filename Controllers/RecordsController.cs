

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using oop.AppDbContext;
using oop.Records;

namespace oop.Controllers {

[Route("api/[controller]")]
[ApiController]
public class RecordsController: ControllerBase {

  private readonly RecordDbContext context;
  public RecordsController(RecordDbContext context) {
    this.context = context;
  }

  [HttpGet]
  public async Task<List<Record>> GetRecords() {
    return await context.Records.Include(c => c.Artist).ToListAsync();
  }
}

}
