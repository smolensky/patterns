using System;

namespace templateMethodPattern.templateMethodPattern
{
    public abstract class Beverage
    {
        public void MakeBeverage()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        public abstract void Brew();

        public abstract void AddCondiments();

        public void BoilWater()
        {
            Console.WriteLine("Boiling water... ok");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring in cup... ok");
        }
    }
}
