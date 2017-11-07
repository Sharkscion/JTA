using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    public abstract class Person
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public PersonType Type { get; set; }

        [InverseProperty("Person")]
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
