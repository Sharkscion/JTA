
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    [Table("ProductVariant")]
    public class ProductVariant
    {
        [Key]
        public int Id { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        public string Description { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal BoxQuantity { get; set; }

        public decimal InitialStocks { get; set; }

        public decimal Stocks { get; set; }

        public decimal MinimumQuantity { get; set; }

        [InverseProperty("ProductVariant")]
        public virtual ICollection<PriceUpdate> PriceUpdates { get; set; }
    }
}
