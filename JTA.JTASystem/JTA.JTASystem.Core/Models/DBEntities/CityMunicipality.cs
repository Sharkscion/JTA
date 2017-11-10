using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    [Table("CityMunicipality")]
    public class CityMunicipality
    {
        [Key]
        public string Code { get; set; }

        public string PSGCCode { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public string ProvinceCode { get; set; }

        public string RegionCode { get; set; }

        [ForeignKey("ProvinceCode")]
        public virtual Province Province { get; set; }

        [ForeignKey("RegionCode")]
        public virtual Region Region{ get; set; }
    }
}
