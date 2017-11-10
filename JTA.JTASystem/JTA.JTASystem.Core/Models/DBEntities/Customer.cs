
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    [Table("Customer")]
    public class Customer : Person
    {
        public virtual Employee SalesPerson { get; set; }

        public int? ParentStoreId { get; set; }

        [ForeignKey("ParentStoreId")]
        public virtual Customer ParentStore { get; set; }

        [InverseProperty("Customer")]
        public virtual ICollection<CustomerBlockedProduct> BlockedProducts { get; set; }

        [InverseProperty("Customer")]
        public virtual ICollection<CustomerBranch> Branches { get; set; }

      
    }
}
