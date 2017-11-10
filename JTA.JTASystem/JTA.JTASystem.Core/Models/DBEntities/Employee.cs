using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    [Table("Employee")]
    public class Employee : Person
    {
        [Column(TypeName = "date")]
        public DateTime DateEmployed{ get; set;}

        public decimal Salary { get; set; }

        [InverseProperty("SalesPerson")]
        public virtual ICollection<Customer> Customers { get; set; }

        [InverseProperty("IssuedBy")]
        public virtual ICollection<Document> DocumentsIssued { get; set; }

        [InverseProperty("SalesPerson")]
        public virtual ICollection<Document> DocumentsAssigned { get; set; }

    }
}
