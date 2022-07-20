using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore;
using oop.Models;
using oop.enums;
using oop.Mocks;

namespace oop.AppDbContext {
  public class RecordDbContext: DbContext {
    public RecordDbContext(DbContextOptions<RecordDbContext> options): base(options) {  }

      public DbSet<Record> Records { get; set; }

      public DbSet<Stock> Stocks { get; set; }
      public DbSet<Track> Tracks { get; set; }

      public DbSet<Artist> Artists { get; set; }
  
    protected override void OnModelCreating(ModelBuilder builder) {
      var Mock = new MockData();
      // Initializing mock data
      builder.Entity<Record>().HasData(
       Mock.Records
      );
      builder.Entity<Artist>().HasData(
        Mock.Artists
      );
      builder.Entity<Track>().HasData(
       Mock.Tracks
      );
      builder.Entity<Stock>().HasData(
       Mock.Stocks
      );
    }
  }
}
