using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePartTwo.Lesson_24_SOLID_ClasaOrder
{
    public interface IPaymentMethod
    {
        void ProcessPayment();
    }
    public class CreditCardPayment : IPaymentMethod
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment...");
        }
    }

    public class PayPalPayment : IPaymentMethod
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing PayPal payment...");
        }
    }

    public class BankTransferPayment : IPaymentMethod
    {
        public void ProcessPayment ()
        {
            Console.WriteLine("Processing bank transfer payment...");
        }
    }

    public class PaymentProcessor
    {
        public void Process(string paymentMethod)
        {
            IPaymentMethod payment = paymentMethod switch
            {
                "CreditCard" => new CreditCardPayment(),
                "PayPal" => new PayPalPayment(),
                "BankTransfer" => new BankTransferPayment(),
                _ => throw new ArgumentException("Invalid payment method")
            };

            payment.ProcessPayment();
        }
    }


}





       