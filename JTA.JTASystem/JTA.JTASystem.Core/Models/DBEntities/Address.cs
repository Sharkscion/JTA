using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    [Table("Address")]
    public class Address
    {
        public int Id { get; set; }

        public virtual Person Person { get; set; }

        public int BranchNo { get; set; }

        public string AddressLine { get; set; }

        public string BarangayCode { get; set; }

        public string CityMunicipalityCode { get; set; }

        public string ProvinceCode { get; set; }

        [ForeignKey("BarangayCode")]
        public virtual Barangay Barangay { get; set; }

        [ForeignKey("CityMunicipalityCode")]
        public virtual CityMunicipality CityMunicipality { get; set; }

        [ForeignKey("ProvinceCode")]
        public virtual Province Province { get; set; }

        public virtual Route Route { get; set; }

        public Status.AddressStatus Status { get; set; }
    }
}
