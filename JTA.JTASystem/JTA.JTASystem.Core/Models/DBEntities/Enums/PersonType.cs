using System.ComponentModel;
namespace JTA.JTASystem.Core
{
    public enum PersonType
    {
        Administrator,
        Customer,
        Manager,
        [Description("Sales Person")]
        SalesPerson,
        Staff,
        Supplier,
        [Description("Vice Manager")]
        ViceManager,

    }
}
