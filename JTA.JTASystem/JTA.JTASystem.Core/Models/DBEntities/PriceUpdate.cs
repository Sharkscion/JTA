using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    [Table("PriceUpdate")]
    public class PriceUpdate
    {
        public int Id { get; set; }

        public virtual ProductVariant ProductVariant { get; set; }

        public decimal UpdatedPrice {get; set; }

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Timestamp]
        public byte[] Timestamp { get; set; }

    }
}
