using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTASystem.Models
{
    class ContactInfo
    {
        public virtual string Contact { get; set; }
        public virtual String Type { get; set; }
        public virtual string ContactPerson { get; set; }
        public virtual Person Person { get; set; }
        public virtual Status Status { get; set; }        
    }

    public enum ContactType
    {
        Fax,
        Email,
        Telephone,
        Mobile
    }
}
