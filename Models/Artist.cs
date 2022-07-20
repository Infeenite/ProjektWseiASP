

using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using oop.Records;

namespace oop.Artists {
  [Table("Artists")]
  public class Artist {
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }
  }
}
