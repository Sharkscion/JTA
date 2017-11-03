using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTASystem.Models
{
    class Customer
    {
        public virtual int TIN { get; set; }
        public virtual int Level { get; set; }
        public virtual Terms Terms { get; set; }
        public virtual Person SalesPerson { get; set; }
        public virtual string CreditStanding { get; set; }
        public virtual decimal CreditLimit { get; set; }
        public virtual Status Status { get; set; }
        public virtual string Note { get; set; }
       
        public virtual IList<Document> Documents { get; set; }
        public virtual IList<CustomerBlockedProducts> BlockedProducts { get; set; }

        public Customer()
        {
            Documents = new List<Document>();
            BlockedProducts = new List<CustomerBlockedProducts>();
        }
    }
}
