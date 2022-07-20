using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore;
using oop.Artists;
using oop.enums;
using oop.Records;
using oop.Stocks;
using oop.Tracks;

namespace oop.AppDbContext {
  public class RecordDbContext: DbContext {
    public RecordDbContext(DbContextOptions<RecordDbContext> options): base(options) {  }

      public DbSet<Record> Records { get; set; }

      public DbSet<Stock> Stocks { get; set; }
      public DbSet<Track> Tracks { get; set; }

      public DbSet<Artist> Artists { get; set; }
  
    protected override void OnModelCreating(ModelBuilder builder) {

      // Initializing mock data
      builder.Entity<Record>().HasData(
        new Record {
          Id = 1,
          Name = "Heaven and Hell",
          SerialNumber = "9102 752",
          ArtistId = 1
        }
      );
      builder.Entity<Artist>().HasData(
        new Artist{
          Id = 1,
          Name = "Black Sabbath",
        }
      );
      builder.Entity<Track>().HasData(
         new Track{
            Id = 1,
            TrackNo = 1, 
            Name = "Neon Knights", 
            RecordId = 1
            },

          new Track{
            Id = 2,
            TrackNo = 2, 
            Name = "Children of the Sea", 
            RecordId = 1
            }
      );
      builder.Entity<Stock>().HasData(
        new Stock {
          Id = 1,
          RecordId = 1,
          Condition = Condition.NearMint
        },

        new Stock {
          Id = 2,
          RecordId = 1,
          Condition = Condition.Excellent
        }
      );
    }
  }
}
