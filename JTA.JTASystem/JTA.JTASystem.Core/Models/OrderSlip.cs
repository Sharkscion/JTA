using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    [Table("OrderSlip")]
    public class OrderSlip : Document
    {
        [Column(TypeName = "bit")]
        public bool IsDelivered { get; set; }
    }
}
