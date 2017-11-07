
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    [Table("Customer")]
    public class Customer : Person
    {
        public virtual Person SalesPerson { get; set; }

        public int? ParentStoreId { get; set; }

        [ForeignKey("ParentStoreId")]
        public virtual Person ParentStore { get; set; }

        public virtual ICollection<Customer> Children { get; set; }

        [InverseProperty("Customer")]
        public virtual ICollection<CustomerBlockedProduct> BlockedProducts { get; set; }

        [InverseProperty("Customer")]
        public virtual ICollection<CustomerBranch> Branches { get; set; }

        [InverseProperty("Person")]
        public virtual ICollection<Document> DocumentsOrdered{ get; set; }

    }
}
