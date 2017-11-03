using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTASystem.Models
{
    class OrderSlip : Document
    {
        public virtual Document ReturnSlip { get; set; }
        public virtual bool IsDelivered { get; set; }
    }
}
