using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnMVC.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Category { get; set; }
        public required string ProductName { get; set; }
        public string ProductDescription { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required]
        public int StockQuantity { get; set; }

        [StringLength(1000)]
        [DataType(DataType.Url)]
        public required string ImageUrl { get; set; }
    }
}
