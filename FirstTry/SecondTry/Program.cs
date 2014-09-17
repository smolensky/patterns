using System;
using SecondTry.decoratorPattern;

namespace SecondTry
{
    class Program
    {
        static void Main()
        {
            Beverage beverage1 = new DarkRoast();
            
            Beverage beverage2 = new Espresso();
            beverage2 = new Milk(beverage2);
            
            Beverage beverage3 = new DarkRoast();
            beverage3 = new Milk(beverage3);
            beverage3 = new Whip(beverage3);

            Console.WriteLine(beverage1.GetDescription() + "\n" + beverage1.Cost());
            Console.WriteLine(beverage2.GetDescription() + "\n" + beverage2.Cost());
            Console.WriteLine(beverage3.GetDescription() + "\n" + beverage3.Cost());

            Console.ReadKey();
        }
    }
}
