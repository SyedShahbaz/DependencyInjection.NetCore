using System;
using DependencyInjectionPractice.Abstraction;

namespace DependencyInjectionPractice.Dummy
{
    public class ProcessStarter : IProcess
    {
        private readonly IOrderManager _orderManager;

        public ProcessStarter(IOrderManager orderManager)
        {
            _orderManager = orderManager;
        }

        public void Process()
        {
            var product = string.Empty;

            while (product != "exit")
            {
                Console.WriteLine(@"Enter a Product:
                Keyboard = 0,
                Mouse = 1,
                Mic = 2,
                Speaker = 3,
                Enter exit to Exit :P");

                product = Console.ReadLine();
                try
                {
                    if (Enum.TryParse(product, out Products productEnum))
                    {
                        Console.WriteLine("Enter Cardholder Name");
                        var cardHolder = Console.ReadLine();

                        _orderManager.Submit(productEnum, !string.IsNullOrEmpty(cardHolder) ? cardHolder : "Default");
                    }
                    else
                    {
                        Console.WriteLine("Invalid product");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}   

