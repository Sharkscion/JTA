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

        [Column(TypeName = "decimal(13,4)")]
        public decimal Quantity { get; set; }

        [Column(TypeName = "decimal(13,4)")]
        public decimal UnitPrice { get; set; }

        public Unit Unit { get; set; }

        public string Discount { get; set; }

        [Column(TypeName = "decimal(13,4)")]
        public decimal SubAmount { get; set; }

        public Status.Order Status {get; set;}

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        public virtual Document Document{ get; set; }
    }
}
