
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    [Table("Document")]
    public abstract class Document
    {
        [Key, Column(Order = 1)]
        public int Id { get; set; }

        [Key, Column(Order = 2)]
        public DocumentType Type { get; set; }

        [Key, Column(Order = 3)]
        public DateTime DateIssued { get; set; }

        public Terms Terms { get; set; }

        public virtual Person Person { get; set; }

        public virtual Address Address { get; set; }

        public int? IssuedById { get; set; }

        public int? SalesPersonId { get; set; }

        [ForeignKey("SalesPersonId")]
        public virtual Employee SalesPerson { get; set; }

        [ForeignKey("IssuedById")]       
        public virtual Employee IssuedBy { get; set; }

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Timestamp]
        public byte[] Timestamp { get; set; }
        
        public Status.DocumentStatus Status { get; set; }

        public Status.DocumentPaymentStatus PaymentStatus { get; set; }

        public decimal TotalAmount { get; set; }

        [Column(TypeName = "ntext")]
        public string Note { get; set; }

        [InverseProperty("Document")]
        public virtual ICollection<OrderDetail> DocumentOrderItems { get; set; }
    }
}
