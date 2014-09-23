using System;

namespace templateMethodPattern.templateMethodPattern
{
    public class Tea : Beverage
    {
        public override void Brew()
        {
            Console.WriteLine("Steeping tea bag... ok");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding milk... ok");
        }
    }
}