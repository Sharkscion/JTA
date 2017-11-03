using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTASystem.Models
{
    class ProductDiscount
    {
        public virtual Discount Discount {get; set;}
        public virtual Product Product { get; set; }
        public virtual int Level { get; set; }

    }
}
