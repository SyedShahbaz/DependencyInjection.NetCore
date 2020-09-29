using System;
using DependencyInjectionPractice.Abstraction;

namespace DependencyInjectionPractice
{

    public class OrderManager : IOrderManager
    {
        private readonly IProductStockRepo _productStockRepo;
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly IShippingProcessor _shippingProcessor;

        public OrderManager(IProductStockRepo productStockRepo, IPaymentProcessor paymentProcessor, IShippingProcessor shippingProcessor)
        {
            _productStockRepo = productStockRepo ?? throw new Exception(nameof(productStockRepo));
            _paymentProcessor = paymentProcessor ?? throw new Exception(nameof(paymentProcessor));
            _shippingProcessor = shippingProcessor ?? throw new Exception(nameof(shippingProcessor));
        }
        public void Submit(Products product, string cardName)
        {
            // check stock
            if (!_productStockRepo.IsInStock(product))
                throw new Exception($"{ product.ToString()} currently out of stock");

            // payment
            _paymentProcessor.ChargeCreditCard(cardName);

            // ship
            _shippingProcessor.MailProduct(product);

        }
    }
}
