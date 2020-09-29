using System;
using DependencyInjectionPractice.Abstraction;
using DependencyInjectionPractice.Dummy;
using Microsoft.Extensions.DependencyInjection;


namespace DependencyInjectionPractice
{
    public class ContainerBuilder
    {
        public IServiceProvider Build()
        {
            var container = new ServiceCollection();

            container.AddSingleton<IOrderManager, OrderManager>();
            container.AddSingleton<IPaymentProcessor, PaymentProcessor>();
            container.AddSingleton<IProductStockRepo, ProductStockRepo>();
            container.AddSingleton<IShippingProcessor, ShippingProcessor>();

            container.AddSingleton<IProcess, ProcessStarter>();
            container.AddSingleton<IProcess, DummyProcess>();

            return container.BuildServiceProvider();
        }
    }
}
