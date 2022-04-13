using System;
using System.Collections.Generic;
using System.Text;

namespace P128ClassWork.Models
{
    class Book
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                while (value.Length < 3)
                {
                    Console.WriteLine("Duzgun Ddeyer Daxil Et: Minimum 3 simvol Ola Biler");
                    value = Console.ReadLine();
                }
                _name = value;
            }
        }
        private int _pagecount;
        public int PageCount
        {
            get => _pagecount;
            set
            {
                while (value < 10)
                {
                    Console.WriteLine("Duzgun Daxil Et");
                    string str = Console.ReadLine();
                    int.TryParse(str, out value);
                }
                _pagecount = value;
            }
        }

        public Book(string name, int pageCount)
        {
            Name = name;
            PageCount = pageCount;
        }
    }
}
