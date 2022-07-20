
using System.ComponentModel.DataAnnotations.Schema;
using oop.enums;

namespace oop.Stocks {
  [Table("Stocks")]
  public class Stock {
    public int Id { get; set; }

    public int RecordId { get; set; }

    public Condition Condition { get; set; }
  }
}
