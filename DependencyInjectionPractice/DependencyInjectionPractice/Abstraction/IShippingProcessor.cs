using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionPractice.Abstraction
{
    public interface IShippingProcessor
    {
        void MailProduct(Products product);
    }
}
