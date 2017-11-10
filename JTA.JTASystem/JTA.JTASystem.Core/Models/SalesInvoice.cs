using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    public class SalesInvoice : Document
    {

        [Column(TypeName = "bit")]
        public bool IsDelivered { get; set; }

        public decimal AddedVat { get; set; }

        public decimal TotalSales { get; set; }
    }
}
