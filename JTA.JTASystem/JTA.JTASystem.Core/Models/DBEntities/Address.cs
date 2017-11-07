using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    [Table("Address")]
    public class Address
    {
        public int Id { get; set; }

        public int PersonId { get; set; }

        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }

        public int BranchNo { get; set; }

        public string AddressLine { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public int RouteId { get; set; }

        public virtual Route Route { get; set; }

        public Status.Address Status { get; set; }
    }
}
