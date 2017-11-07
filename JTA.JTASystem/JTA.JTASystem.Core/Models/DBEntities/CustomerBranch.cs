using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    [Table("CustomerBranch")]
    public class CustomerBranch
    {
        [ForeignKey("Customer")]
        [Column(Order = 1)]
        public int Id { get; set; }

        [Column(Order = 2)]
        public int BranchNo { get; set; }

        public virtual Customer Customer { get; set; }

        [Column(TypeName = "nchar(15)")]
        public string TIN { get; set; }

        public CustomerLevel Level { get; set; }

        public CreditRating CreditRating { get; set; }

        [Column(TypeName = "decimal(13,4)")]
        public decimal CreditLimit { get; set; }

        [Column(TypeName = "ntext")]
        public string Note { get; set; }

        public Status.Customer Status { get; set; }
    }
}
