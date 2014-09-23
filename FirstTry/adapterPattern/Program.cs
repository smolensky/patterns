using System;
using adapterPattern.adapterPattern;

namespace adapterPattern
{
    class Program
    {
        static void Main()
        {
            var simpleDuck = new SimpleDuck();
            var simpleTurkey = new SimpleTurkey();

            var turkeyAdapter = new TurkeyAdapter(simpleTurkey);

            Console.WriteLine("\nTurkey:");
            simpleTurkey.Gobble();
            simpleTurkey.Fly();

            Console.WriteLine("\nDuck:");
            TestDuck(simpleDuck);

            Console.WriteLine("\nTurkey w/ adapter:");
            TestDuck(turkeyAdapter);

            Console.ReadKey();
        }

        static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
