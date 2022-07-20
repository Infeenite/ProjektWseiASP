using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using oop.Artists;
using oop.enums;
using oop.Tracks;

namespace oop.Records
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
  }
}
