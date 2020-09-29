using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionPractice.Abstraction
{
    public interface IPaymentProcessor
    {
        void ChargeCreditCard(string cardHolderName);
    }
}
