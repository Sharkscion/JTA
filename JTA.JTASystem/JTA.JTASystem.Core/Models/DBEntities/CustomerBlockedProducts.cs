using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    [Table("CustomerBlockedProducts")]
    public class CustomerBlockedProduct
    {

        [Key, Column(Order = 1)]
        public int PersonId { get; set; }

        [Key, Column(Order = 2)]
        public string ProductId { get; set; }

        [ForeignKey("PersonId")]
        public virtual Customer Customer { get; set; }

        public virtual Product Product { get; set; }

        [Column(TypeName ="ntext")]
        public string Reason { get; set; }
    }
}
