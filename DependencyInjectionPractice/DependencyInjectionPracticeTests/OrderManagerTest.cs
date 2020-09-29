using System;
using DependencyInjectionPractice;
using DependencyInjectionPractice.Abstraction;
using Moq;
using Xunit;

namespace DependencyInjectionPracticeTests
{
    public class OrderManagerTest
    {
        [Fact]
        public void ThrowException_ProductOutOfStock()
        {
            var productStockRepositoryMock = new Mock<IProductStockRepo>();
            productStockRepositoryMock.Setup(m => m.IsInStock(It.IsAny<Products>())).Returns(false);

            var paymentProcessorMock = new Mock<IPaymentProcessor>();
            var shippingProcessorMock = new Mock<IShippingProcessor>();

            var orderManager = new OrderManager(productStockRepositoryMock.Object, paymentProcessorMock.Object,
                shippingProcessorMock.Object);

            Assert.ThrowsAny<Exception>(() => orderManager.Submit(Products.Keyboard, "Test"));
        }
    }
}
