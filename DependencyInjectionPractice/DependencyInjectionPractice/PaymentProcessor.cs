using System;
using DependencyInjectionPractice.Abstraction;

namespace DependencyInjectionPractice
{
    public class PaymentProcessor : IPaymentProcessor
    {
        
        public void ChargeCreditCard(string cardHolderName)
        {
            if (string.IsNullOrEmpty(cardHolderName))
            {
                throw new ArgumentException("Invalid Name");
            }
            
            Console.WriteLine("Calling Credit card API..");
        }
    }
}
