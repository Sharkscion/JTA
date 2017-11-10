using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    [Table("User")]
    public class User : Person
    {
        public string DisplayName { get; set; }

        public string PasswordStored { get; set; }

        [NotMapped]
        public string Password
        {
            set => PasswordStored = PasswordSecurityHelper.Encrypt(value);
        }

        
    }
}
