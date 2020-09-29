using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionPractice.Abstraction
{
    public interface IProductStockRepo
    {
        bool IsInStock(Products products);
        void ReduceStock(Products products);
        void AddStock(Products products);
    }
}
