using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTASystem.Models
{
    class OrderDetail
    {
        public virtual int IdOrderNum { get; set; }
        public virtual Document Document { get; set; }
        public virtual Product Product { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }
        public decimal UnitPrice { get; set; }
        public Discount Discount { get; set; }
        public decimal SubTotal { get; set; }
        public Status Status { get; set; }
    }
}
