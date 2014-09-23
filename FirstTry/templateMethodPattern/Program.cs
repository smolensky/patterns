using System;
using templateMethodPattern.templateMethodPattern;

namespace templateMethodPattern
{
    class Program
    {
        static void Main()
        {
            var cupOfTea = new Tea();
            var cupOfCoffee = new Coffee();

            cupOfCoffee.MakeBeverage();

            Console.WriteLine("\n");

            cupOfTea.MakeBeverage();

            Console.ReadKey();
        }
    }
}
