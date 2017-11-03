using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTASystem.Models
{
    class Document
    {
        public virtual int Id { get; set; }
        public virtual Person Recipient { get; set; }
        public virtual Address Address { get; set; }
        public virtual string Type { get; set; }
        public Person IssuedBy { get; set; }
        public Person SalesPerson { get; set; }
        public DateTime DateIssued { get; set; }
        public DateTime DateUpdated { get; set; }
        public Status Status { get; set; }
        public decimal TotalAmount { get; set; }
        public string Note { get; set; }

        public virtual IList<OrderDetail> OrderItems { get; set; }

        public Document()
        {
            OrderItems = new List<OrderDetail>();
        }
    }

    public enum DocumentType
    {
        [Description("Purchase Order")]
        PurchaseOrder,

        [Description("Sales Invoice")]
        SalesInvoice,

        [Description("Order Slip")]
        OrderSlip,

        [Description("Return Slip")]
        ReturnSlip


    }
}
