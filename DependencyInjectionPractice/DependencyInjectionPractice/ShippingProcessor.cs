using System;
using DependencyInjectionPractice.Abstraction;

namespace DependencyInjectionPractice
{
    public class ShippingProcessor : IShippingProcessor
    {
        private readonly IProductStockRepo _productStockRepo;

        public ShippingProcessor(IProductStockRepo productStockRepo)
        {
            _productStockRepo = productStockRepo ?? throw new Exception(nameof(productStockRepo));
        }

        public void MailProduct(Products product)
        {
            _productStockRepo.ReduceStock(product);
            Console.WriteLine("Calling Shipping API...");
        }
    }
}
