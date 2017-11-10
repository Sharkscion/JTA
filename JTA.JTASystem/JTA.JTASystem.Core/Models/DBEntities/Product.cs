
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    [Table("Product")]
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Unit Unit { get; set; }

        [Column(TypeName = "bit")]
        public bool IsTracked { get; set; }

        [Column(TypeName = "ntext")]
        public string Note { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }

        public int? ReferencedProductId { get; set; }

        [ForeignKey("ReferencedProductId")]
        public virtual Product ReferencedProduct { get; set; }

        [InverseProperty("Product")]
        public virtual ICollection<ProductDiscount> Discounts { get; set; }

        [InverseProperty("Product")]
        public virtual ICollection<ProductVariant> Variants { get; set; }

        [InverseProperty("Product")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
