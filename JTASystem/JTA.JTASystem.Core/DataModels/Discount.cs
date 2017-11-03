using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTASystem.Models
{
    class Discount
    {
        public virtual int Id { get; set; }
        public virtual string Label { get; set; }
        public virtual decimal NumericValue { get; set; }
    }
}
