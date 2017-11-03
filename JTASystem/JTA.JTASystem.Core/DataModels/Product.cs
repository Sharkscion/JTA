using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTASystem.Models
{
    class Product
    {

        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual string Unit { get; set; }
        public virtual decimal BoxQuantity { get; set; }
        public virtual decimal InitQuantity { get; set; }
        public virtual decimal Stock { get; set; }
        public virtual decimal MinimumQuantity { get; set; }
        public virtual bool IsTracked { get; set; }
        public virtual string Note { get; set; }
        public virtual Category Category { get; set; }

        public virtual IList<ProductDiscount> Discounts { get; set; }
        public virtual IList<OrderDetail> Orders { get; set; }
        public Product()
        {
            Discounts = new List<ProductDiscount>();
            Orders = new List<OrderDetail>();
        }
    }
}
