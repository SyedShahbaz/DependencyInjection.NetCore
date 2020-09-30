using System;
using System.Linq;
using DependencyInjectionPractice.Abstraction;
using DependencyInjectionPractice.Dummy;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionPractice
{
    class Program
    {
        public static  readonly IServiceProvider Container = new ContainerBuilder().Build();
        static void Main(string[] args)
        {
            Container.GetServices<IProcess>().ToList().ForEach(p => p.Process());
            Console.WriteLine("Processing Done...");
        }
    }
}
