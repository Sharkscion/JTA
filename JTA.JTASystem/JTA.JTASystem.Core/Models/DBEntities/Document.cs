
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

        public int PersonId { get; set; }

        public int AddressId { get; set; }

        public int IssuedById { get; set; }

        public int SalesPersonId { get; set; }

        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }

        [ForeignKey("AddressId")]
        public virtual Address Address { get; set; }

        [ForeignKey("IssuedById")]
        public virtual Person IssuedBy { get; set; }

        [ForeignKey("SalesPersonId")]
        public virtual Person SalesPerson { get; set; }

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Timestamp]
        public byte[] Timestamp { get; set; }
        
        public Status.Document Status { get; set; }

        [Column(TypeName ="decimal(13,4)")]
        public decimal TotalAmount { get; set; }

        [Column(TypeName = "ntext")]
        public string Note { get; set; }

        [InverseProperty("Document")]
        public virtual ICollection<OrderDetail> DocumentOrderItems { get; set; }
    }
}
