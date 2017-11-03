using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTASystem.Models
{
    class PurchaseOrder : Document
    {

        public string SupplierSI { get; set; }
        public string PurchaseDescription { get; set; }
        public Document ReturnSlip { get; set; }
        public bool IsPosted { get; set; }
    }
}
