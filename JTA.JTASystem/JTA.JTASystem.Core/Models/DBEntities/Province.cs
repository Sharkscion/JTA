using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    [Table("Province")]
    public class Province
    {
        [Key]
        public string Code { get; set; }

        public string PSGCCode { get; set; }        

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public string RegionCode { get; set; }

        [ForeignKey("RegionCode")]
        public virtual Region Region { get; set; }

    }
}
