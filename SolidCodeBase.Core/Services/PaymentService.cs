namespace SolidCodeBase.Core.Services
{
    public interface IPaymentService
    {
        void ProcessPayment(double amount);
    }

    public class CreditCardPaymentService : IPaymentService
    {
        public void ProcessPayment(double amount)
        {
            // credit card payment transactions
        }
    }

    public class PayPalPaymentService : IPaymentService
    {
        public void ProcessPayment(double amount)
        {
            // PayPal payment transactions
        }
    }
}