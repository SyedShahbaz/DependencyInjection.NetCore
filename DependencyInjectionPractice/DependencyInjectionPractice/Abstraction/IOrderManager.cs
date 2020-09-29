using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionPractice.Abstraction
{
    public interface IOrderManager
    {
        void Submit(Products product, string cardName);
    }
}
