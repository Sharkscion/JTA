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

        [Column(TypeName = "decimal(13, 4)")]
        public decimal Salary { get; set; }

        [InverseProperty("SalesPerson")]
        public virtual ICollection<Customer> Customers { get; set; }

        [InverseProperty("SalesPerson")]
        public virtual ICollection<Document> DocumentsHandled { get; set; }

    }
}
