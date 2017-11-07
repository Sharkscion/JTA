using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    [Table("PurchaseOrder")]
    public class PurchaseOrder : Document
    {
        public string SupplierInvoice { get; set; }

        [Column(TypeName = "ntext")]
        public string PurchaseDescription { get; set; }

        [Column(TypeName = "bit")]
        public bool IsPosted { get; set; }
    }
}
