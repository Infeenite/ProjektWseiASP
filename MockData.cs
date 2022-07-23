using oop.enums;
using oop.Models;

namespace oop.Mocks {

  public class MockData {

    public IEnumerable<Track> Tracks { get; set; }

    public IEnumerable<Artist> Artists { get; set; }

    public IEnumerable<Record> Records { get; set; }

    public IEnumerable<Stock> Stocks { get; set; }

    public MockData()
    {
      Tracks = new Track[] {
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
          },

          new Track{
            Id = 5,
            TrackNo = 4, 
            Name = "Die with your boots on", 
            RecordId = 2
          },

          new Track{
            Id = 3,
            TrackNo = 5, 
            Name = "The Trooper", 
            RecordId = 2
          },

          new Track{
            Id = 4,
            TrackNo = 3, 
            Name = "Rock Hard Ride Free", 
            RecordId = 3
          },

          new Track{
            Id = 6,
            TrackNo = 4, 
            Name = "The Sentinel", 
            RecordId = 3
          }
      };

      Records = new Record[] {
         new Record {
          Id = 1,
          Name = "Heaven and Hell",
          SerialNumber = "9102 752",
          Genre = Genre.Metal,
          ReleaseYear = "1980",
          ImageUrl = "https://i.discogs.com/VXXKjs87ESPmntp4jgYGQv-Q16EKJQnBGdX0NF-1vys/rs:fit/g:sm/q:90/h:594/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTY3NzMz/Ny0xMzMyNzQ4NTk1/LmpwZWc.jpeg",
          ArtistId = 1
        },
        new Record {
          Id = 2,
          Name = "Piece of Mind",
          Genre = Genre.Metal,
          SerialNumber = "9102 752",
          ReleaseYear = "1983",
          ImageUrl = "https://i.discogs.com/VyqY8388sgwjGVc25Z6FQbLLgXlmPgyGL7AkYrfgidA/rs:fit/g:sm/q:90/h:600/w:598/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE4Mzk4/NDItMTU5MDE1MzU5/My02MTc3LmpwZWc.jpeg",
          ArtistId = 3
        },
        new Record {
          Id = 3,
          Name = "Defenders of the Faith",
          Genre = Genre.Metal,
          SerialNumber = "9102 752",
          ReleaseYear = "1984",
          ImageUrl = "https://i.discogs.com/bxSIVqkuJrEplrBi4gkZNJA5hEllnwN-q_r7PYS5T8o/rs:fit/g:sm/q:90/h:599/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3MjMx/Mi0xNTkwMzE5NjY4/LTU2NDkuanBlZw.jpeg",
          ArtistId = 2
        }
      };

      Artists = new Artist[] {
        new Artist{
          Id = 1,
          Name = "Black Sabbath",
        },

        new Artist{
          Id = 2,
          Name = "Judas Priest",
        },

        new Artist{
          Id = 3,
          Name = "Iron Maiden",
        }
      };

      Stocks = new Stock[] {
         new Stock {
          Id = 1,
          RecordId = 1,
          Condition = Condition.NearMint,
          Price = 99
        },

        new Stock {
          Id = 2,
          RecordId = 1,
          Condition = Condition.Excellent,
          Price = 32
        },

        new Stock {
          Id = 3,
          RecordId = 2,
          Condition = Condition.Mint,
          Price = 32
        },

        new Stock {
          Id = 4,
          RecordId = 3,
          Condition = Condition.NearMint,
          Price = 32
        },
        new Stock {
          Id = 5,
          RecordId = 3,
          Condition = Condition.Fair,
          Price = 32
        }
      };
    }
  }
}
