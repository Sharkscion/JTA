using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    public class SalesInvoice : Document
    {

        [Column(TypeName = "bit")]
        public bool IsDelivered { get; set; }

        [Column(TypeName = "decimal(13,4)")]
        public decimal AddedVat { get; set; }

        [Column(TypeName = "decimal(13,4)")]
        public decimal TotalSales { get; set; }
    }
}
