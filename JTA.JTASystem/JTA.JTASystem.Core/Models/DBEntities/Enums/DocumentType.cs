
using System.ComponentModel;

namespace JTA.JTASystem.Core
{
    public enum DocumentType
    {
        [Description("Purchase Order")]
        PurchaseOrder,

        [Description("Sales Invoice")]
        SalesInvoice,

        [Description("Order Slip")]
        OrderSlip,
    }
}
