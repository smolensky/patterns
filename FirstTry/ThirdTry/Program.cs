using System;
using ThirdTry.singletonPattern;

namespace ThirdTry
{
    class Program
    {
        static void Main()
        {
            CheckNull();

            ChocolateBoiler boiler = ChocolateBoiler.GetInstance();

            CheckNull();

            //should work correct
            boiler.Fill();
            boiler.Boil();
            boiler.Drain();

            Console.WriteLine("\n");

            //should work incorrect
            boiler.Boil();
            boiler.Drain();
            boiler.Fill();
            boiler.Fill();
            boiler.Drain();

            Console.ReadKey();
        }

        private static void CheckNull()
        {
            Console.WriteLine(ChocolateBoiler._uniqueInstance == null
                ? "You have null here! \n Create an object!"
                : "You've created an object! \n You have no null anymore!");
        }
    }
}
