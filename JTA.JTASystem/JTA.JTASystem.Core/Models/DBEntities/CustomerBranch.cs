using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    [Table("CustomerBranch")]
    public class CustomerBranch
    {
        public int Id { get; set; }

        public int BranchNo { get; set; }

        public virtual Customer Customer { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string TIN { get; set; }

        public CustomerLevel Level { get; set; }

        public CreditRating CreditRating { get; set; }

        public decimal CreditScrore { get; set; }

        public decimal CreditLimit { get; set; }

        [Column(TypeName = "ntext")]
        public string Note { get; set; }

        public Status.CustomerStatus Status { get; set; }
    }
}
