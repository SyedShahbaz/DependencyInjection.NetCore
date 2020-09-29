using System;
using System.Collections.Generic;
using DependencyInjectionPractice.Abstraction;

namespace DependencyInjectionPractice
{
    public class ProductStockRepo : IProductStockRepo
    {
        private static Dictionary<Products, int> _ProductDictionary = SetUp();

        private static Dictionary<Products, int> SetUp()
        {
            var productStockDataBase = new Dictionary<Products, int>
            {
                { Products.Mic, 1 },
                { Products.Keyboard, 1 },
                { Products.Speaker, 1 },
                { Products.Mouse, 1 }
            };

            return productStockDataBase;
        }

        public bool IsInStock(Products products)
        {
            Console.WriteLine("Calling Database, checking product");
            return _ProductDictionary[products] > 0;
        }

        public void ReduceStock(Products products)
        {
            Console.WriteLine("Calling Database, decrementing product");
            _ProductDictionary[products]--;
        }

        public void AddStock(Products products)
        {
            Console.WriteLine("Calling Database, Adding product");
            _ProductDictionary[products]++;
        }
    }
}
