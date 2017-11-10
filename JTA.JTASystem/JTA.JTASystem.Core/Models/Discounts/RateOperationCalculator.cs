namespace JTA.JTASystem.Core
{
    public class RateOperationCalculator
    {
        public static decimal RevertAddedRate(decimal amount, decimal rate)
        {
            return amount -= rate;
        }

        public static decimal RevertDiscountRate(decimal amount, decimal rate)
        {
            return amount += (100-rate)/100;
        }

        public static decimal ApplyAddRate(decimal amount, decimal rate)
        {
            return amount += rate;
        }

        public static decimal ApplyDiscountRate(decimal amount, decimal rate)
        {
            return amount *= (100-rate)/100;
        }
    }
}
