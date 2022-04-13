using System;
using P128HomeWork.Models;
using DemoLibrary;

namespace P128HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Product zavod = new Product("Bakixanov");
            zavod.Count = 10;
            zavod.Price = 0.65;

            Console.WriteLine($"Ad:{zavod.Name}Say:{zavod.Count}Qiymet:{zavod.Price} UmumiGelir: {zavod.TotalIncome}\n");
            zavod.Sell();
            zavod.Sell();
            zavod.Sell();
            Console.WriteLine($"Ad: {zavod.Name} Say: {zavod.Count} Qiymet: {zavod.Price} UmumiGelir: {zavod.TotalIncome.ToString("0.00")}");


            Milk milk = new Milk("Pal");
            milk.Count = 5;
            milk.Price = 5;
            milk.FatRate = 3.5;
            milk.Volume = 1;

            Console.WriteLine($"Ad: {milk.Name} " +
                $"Say: {milk.Count} " +
                $"Qiymet: {milk.Price} " +
                $"UmumiGelir: {milk.TotalIncome.ToString("0.00")} " +
                $"Yagliliq: {milk.FatRate} " +
                $"Litr: {milk.Volume}");

            milk.Sell();
            milk.Sell();
            milk.Sell();

            Console.WriteLine($"Ad: {milk.Name} " +
                $"Say: {milk.Count} " +
                $"Qiymet: {milk.Price} " +
                $"UmumiGelir: {milk.TotalIncome.ToString("0.00")} " +
                $"Yagliliq: {milk.FatRate} " +
                $"Litr: {milk.Volume}");


        }
    }
}
