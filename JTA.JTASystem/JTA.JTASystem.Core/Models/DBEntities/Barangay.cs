
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    [Table("Barangay")]
    public class Barangay
    {
        [Key]
        public string Code { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public string RegionCode { get; set; }

        public string ProvinceCode { get; set; }

        public string CityMunicipalityCode { get; set; }

        [ForeignKey("RegionCode")]
        public virtual Region Region { get; set; }

        [ForeignKey("ProvinceCode")]
        public virtual Province Province { get; set; }

        [ForeignKey("CityMunicipalityCode")]
        public virtual CityMunicipality CityMunicipality { get; set; }
    }
}
