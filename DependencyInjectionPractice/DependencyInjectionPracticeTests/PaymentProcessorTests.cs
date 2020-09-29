using System;
using System.Collections.Generic;
using System.Text;
using DependencyInjectionPractice;
using DependencyInjectionPractice.Abstraction;
using Moq;
using Xunit;

namespace DependencyInjectionPracticeTests
{
    public class PaymentProcessorTests
    {
        [Fact]
        public void ThrowException_CardNameIsEmptyOrNull()
        {
            var paymentProcessor = new PaymentProcessor();
            Assert.ThrowsAny<Exception>(() => paymentProcessor.ChargeCreditCard(""));
        }
    }
}
