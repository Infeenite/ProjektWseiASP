
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using oop.enums;

namespace oop.Models
{
    [Table("Stocks")]
    public class Stock
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int RecordId { get; set; }

        public Record? Record { get; set; }

        [Required]
        public Condition Condition { get; set; }


        [Required]
        [Range(0, 10000)]
        public decimal Price { get; set; }
    }
}
