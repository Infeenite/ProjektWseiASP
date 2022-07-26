
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using oop.enums;

namespace oop.Models {

  public class StockDTO {
    
    public RecordDTO Record { get; set; }
    public Condition Condition { get; set; }

    public decimal Price { get; set; }

    [JsonConstructor]
    public StockDTO(){}

    public StockDTO(Stock Stock)
    {
      Record = new RecordDTO(Stock.Record);
      Condition = Stock.Condition;
      Price = Stock.Price;
    }
  }
}
