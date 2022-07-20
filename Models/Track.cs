using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace oop.Models {

  [Table("Tracks")]
  public class Track {
    public int Id { get; set; }

    public int TrackNo { get; set; }

    public int RecordId { get; set; }
    
    [Required]
    [StringLength(100)]
    public string Name { get; set; }
  }
}
