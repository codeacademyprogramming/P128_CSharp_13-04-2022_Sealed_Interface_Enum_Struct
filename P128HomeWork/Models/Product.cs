using System;
using System.Collections.Generic;
using System.Text;

namespace P128HomeWork.Models
{
    class Product
    {
        public string Name;
        public double Price;
        public int Count;
        public double TotalIncome;

        public Product(string name)
        {
            Name = name;
        }

        public void Sell()
        {
            if (Count > 0)
            {
                Count--;
                TotalIncome += Price;
                return;
            }
            Console.WriteLine($"Satis Bas Vermedi Say: {Count}");
        }
    }
}
