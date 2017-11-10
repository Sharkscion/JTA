
using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    [Table("PersonType")]
    public class PersonType
    {
        public int Id { get; set; }

        public string Description { get; set; }

    }
}
