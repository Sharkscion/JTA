using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    [Table("Region")]
    public class Region
    {
        [Key]
        public string Code { get; set; }

        public string PSGCCode { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }
    }
}
