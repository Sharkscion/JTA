
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    [Table("Product")]
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Description { get; set; }

        [Column(TypeName = "decimal(13,4)")]
        public decimal UnitPrice { get; set; }

        public Unit Unit { get; set; }

        [Column(TypeName = "decimal(13,4)")]
        public decimal BoxQuantity { get; set; }

        [Column(TypeName = "decimal(13,4)")]
        public decimal InitialStocks { get; set; }

        [Column(TypeName = "decimal(13,4)")]
        public decimal Stocks { get; set; }

        [Column(TypeName = "decimal(13,4)")]
        public decimal MinimumQuantity { get; set; }

        [Column(TypeName = "bit")]
        public bool IsTracked { get; set; }

        [Column(TypeName = "ntext")]
        public string Note { get; set; }

        public ProductCategory Category { get; set; }

        public int? ReferencedProductId { get; set; }

        [ForeignKey("ReferencedProductId")]
        public virtual Product ReferencedProduct { get; set; }

        [InverseProperty("Product")]
        public virtual ICollection<ProductDiscount> Discounts { get; set; }
    }
}
