using P128ClassWork.Models;
using System;

namespace P128ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { };

            //Book[] books =new Book[10];
            Book[] books = { };
            Console.WriteLine("Siyahiya Elave Etmek Isdediyniz Sayi Daxil");
            int.TryParse(Console.ReadLine(), out int bookCount);

            for (int i = 0; i < bookCount; i++)
            {
                Console.WriteLine($"{i+1} ci Kitabin Adini Daxil Et");
                string name = Console.ReadLine();
                Console.WriteLine($"{i+1} ci Kitabin Sehife Sayini Daxil Et");
                int.TryParse(Console.ReadLine(), out int pagecount);
                Book book = new Book(name, pagecount);
                Array.Resize(ref books, books.Length + 1);
                books[books.Length-1] = book;
            }

            foreach (Book item in books)
            {
                Console.WriteLine($"{item.Name} {item.PageCount}");
            }
        }
    }
}
