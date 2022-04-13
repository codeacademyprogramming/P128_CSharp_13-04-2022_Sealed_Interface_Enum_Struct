using System;
using P128Enum.Enums;

namespace P128Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Markani Daxil Et");
            //string marka = Console.ReadLine();

            //if (marka == "Isuzu")
            //{

            //}
            //else
            //{
            //    Console.WriteLine("Duz Daxil Et");
            //}

            //Console.WriteLine($"Id: {(int)Marka.Mercedes} Adi: {Marka.Mercedes}");

            //Console.WriteLine("Siyahidan Daxil etmek Isdediyniz Markanin Id-snini Daxil et:");
            //foreach (var item in Enum.GetValues(typeof(Marka)))
            //{
            //    Console.WriteLine($"Id: {(byte)item} Name: {item}");
            //}
            //string mar = Console.ReadLine();
            ////int.TryParse(mar, out int markanum);

            //int markanum;

            //while (!int.TryParse(mar, out markanum) || markanum<1 || markanum > 6)
            //{
            //    Console.WriteLine("Daxil Etdiyniz Deyer Intervalda Yoxdur");
            //    mar = Console.ReadLine();
            //}

            //Console.WriteLine($"Secdiyniz Marka {(Marka)markanum}");

            //string[] arr = Enum.GetNames(typeof(Marka));

            //foreach (string item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("Heftenin Gunun Daxil et");
            foreach (var item in Enum.GetValues(typeof(WeekDay)))
            {
                Console.WriteLine($"Id: {(int)item} {item}");
            }

            string weekDayStr = Console.ReadLine();
            int weekDayNum;

            while (!int.TryParse(weekDayStr, out weekDayNum) || weekDayNum < 1 || weekDayNum > 7)
            {
                Console.WriteLine("Duzgun Daxil Et");
                weekDayStr = Console.ReadLine();
            }

            switch (weekDayNum)
            {
                case 1:
                    Console.WriteLine("Birinci Gun");
                    break;
                case 2:
                    Console.WriteLine("ikinci Gun");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Istirahet");
                    break;
                default:
                    break;
            }
        }
    }
}
