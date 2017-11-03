using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTASystem.Models
{
    class Address
    {

        public virtual int Id { get; set; }
        public virtual string AddressLine { get; set; }
        public virtual string City { get; set; }
        public virtual Route Route{ get; set; }
        public virtual Person Person { get; set; }
        public virtual Status Status { get; set; }



       
    }
}
