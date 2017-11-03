using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTASystem.Models
{
    class SalesInvoice : Document
    {

        public Document ReturnSlip { get; set; }
        public Document PurchaseOrder { get; set; }
        public Terms Terms { get; set; }
        public bool IsDelivered { get; set; }
        public decimal AddedVAT { get; set; }
        public decimal TotalSales { get; set; }
    }
}
