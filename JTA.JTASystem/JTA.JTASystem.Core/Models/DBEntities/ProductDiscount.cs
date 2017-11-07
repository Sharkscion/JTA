
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    [Table("ProductDiscount")]
    public class ProductDiscount
    {
        [Key, Column(Order = 1)]
        public CustomerLevel Level { get; set; }

        [ForeignKey("Product")]
        [Key, Column(Order = 2)]
        public int ProductId { get; set; }

        public string Discount { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product{get; set;}

    }
}
