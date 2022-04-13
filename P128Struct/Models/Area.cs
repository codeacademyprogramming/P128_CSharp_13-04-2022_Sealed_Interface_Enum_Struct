using System;
using System.Collections.Generic;
using System.Text;

namespace P128Struct.Models
{
    struct Area
    {
        public int A;
        public int B { get; set; }

        public Area(int a, int b)
        {
            A = a;
            B = b;

            Console.WriteLine(SumArea());
        }

        public int SumArea()
        {
            return A * B;
        }
    }
}
