
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using oop.enums;

namespace oop.Models
{

    public class StockDTO
    {

        public RecordDTO? Record { get; set; }
        public Condition Condition { get; set; }

        public decimal Price { get; set; }

        public StockDTO(Stock Stock)
        {
            if (Stock.Record != null)
            {
                Record = new RecordDTO(Stock.Record);
            }
            else
            {
                Record = null;
            }

            Condition = Stock.Condition;
            Price = Stock.Price;
        }
    }
}
