using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JTASystem.Common;

namespace JTASystem.Models
{
    class User : Person
    {
        public virtual string Password { get { return Password; } set => PasswordHasher.Hash(value); }
        public virtual string DisplayName { get; set; }
    }
}
