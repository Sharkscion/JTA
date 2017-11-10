
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    [Table("ContactInformation")]
    public class ContactInformation
    {
        [Key]
        public string ContactValue { get; set; }

        public int BranchNo { get; set; }

        public ContactType Type { get; set; }

        public string ContactPerson { get; set; }

        public Status.ContactInformationStatus Status { get; set; }

        public virtual Person Person { get; set; }
    }
}
