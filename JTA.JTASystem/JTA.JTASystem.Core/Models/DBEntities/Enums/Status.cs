namespace JTA.JTASystem.Core
{
    public class Status
    {
        public enum ContactInformationStatus
        {
            Deactivated,
            Active            
        }

        public enum OrderStatus
        {
            Canceled,
            Delivered,
            Returned,
            Lost,
        }

        public enum AddressStatus
        {
            Deactivated,
            Active
        }

        public enum CustomerStatus
        {
            Archived,
            Active
        }

        public enum SupplierStatus
        {
            Archived,
            Active
        }

        public enum ProductStatus
        {
            Archived,
            Active
        }

        public enum DocumentStatus
        {
            
            Archived,
            Delivered,
            Posted,
        }

        public enum DocumentPaymentStatus
        {
            Paid = 1,
            PartiallyPaid,
            Unpaid,
            Overdue
        }
    }
}
