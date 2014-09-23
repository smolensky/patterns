using System;

namespace templateMethodPattern.templateMethodPattern
{
    public class Coffee : Beverage
    {
        public override void Brew()
        {
            Console.WriteLine("Adding coffee... ok");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding sugar... ok");
        }
    }
}
