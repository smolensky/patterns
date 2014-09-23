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

            var duckAdapter = new DuckAdapter(simpleDuck);
            var turkeyAdapter = new TurkeyAdapter(simpleTurkey);

            var duckFacade = new DuckAndTurkeyFacade();

            Console.WriteLine("\nTurkey:");
            TestTurkey(simpleTurkey);

            Console.WriteLine("\nDuck:");
            TestDuck(simpleDuck);

            Console.WriteLine("\nTurkey w/ adapter:");
            TestDuck(turkeyAdapter);

            Console.WriteLine("\nDuck w/ adapter:");
            TestTurkey(duckAdapter);

            Console.WriteLine("\n");

            duckFacade.DoThings();

            Console.ReadKey();
        }

        static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }

        static void TestTurkey(ITurkey turkey)
        {
            turkey.Gobble();
            turkey.Fly();
        }
    }
}
