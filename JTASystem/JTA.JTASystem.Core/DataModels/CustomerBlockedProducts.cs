using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTASystem.Models
{
    class CustomerBlockedProducts
    {
        public virtual Person Customer { get; set; }
        public virtual Product Product { get; set; }
        public string Reason { get; set; }
    }
}
