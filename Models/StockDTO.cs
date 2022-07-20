
using System.ComponentModel.DataAnnotations.Schema;
using oop.enums;

namespace oop.Models {

  public class StockDTO {
    
    public RecordDTO Record { get; set; }
    public Condition Condition { get; set; }

    public int Price { get; set; }

    public StockDTO(Stock Stock)
    {
      Record = new RecordDTO(Stock.Record);
      Condition = Stock.Condition;
      Price = Stock.Price;
    }
  }
}
