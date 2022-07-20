using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using oop.enums;

namespace oop.Models
{
    [Table("Records")]
  public class Record {
    public int Id { get; set; }

    [Required]
    [StringLength(12)]
    public string SerialNumber { get; set; }

    [Required]
    [StringLength(120)]
    public string Name { get; set; }

    public int ArtistId { get; set; }

    public Artist Artist {get; set;}

    public Genre Genre { get; set; }

    public string ImageUrl { get; set; }

    [StringLength(4)]
    public string ReleaseYear { get; set; }

    public List<Track> Tracks { get; set; }

    public Record()
    {
      Tracks = new List<Track>();
    }
  }
}
