
using System.ComponentModel.DataAnnotations.Schema;
using oop.enums;

namespace oop.Models {
  [Table("Stocks")]
  public class Stock {
    public int Id { get; set; }

    public int RecordId { get; set; }
    
    public Record Record { get; set; }
    public Condition Condition { get; set; }

    public int Price { get; set; }
  }
}
