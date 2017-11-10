using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        [Key, Column(Order = 1)]
        public int OrderNum { get; set; }

        [ForeignKey("Document")]
        [Key, Column(Order = 2)]
        public int DocumentId { get; set; }

        [ForeignKey("Document")]
        [Key, Column(Order = 3)]
        public DocumentType Type { get; set; }

        [ForeignKey("Document")]
        [Key, Column(Order = 4)]
        public DateTime DateIssued { get; set; }

        public int ProductId { get; set; }

        public int? ProductVariantId { get; set; }

        public decimal Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public Unit Unit { get; set; }

        public string Discount { get; set; }

        public decimal SubAmount { get; set; }

        public Status.OrderStatus Status {get; set;}

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [ForeignKey("ProductVariantId")]
        public virtual ProductVariant ProductVariant { get; set; }

        public virtual Document Document{ get; set; }
    }
}
