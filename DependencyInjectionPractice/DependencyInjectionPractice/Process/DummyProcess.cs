using System;

namespace DependencyInjectionPractice.Dummy
{
    public class DummyProcess : IProcess
    {
        public void Process()
        {
            Console.WriteLine("This is Dummy Process just for fun :P");
        }
    }
}
