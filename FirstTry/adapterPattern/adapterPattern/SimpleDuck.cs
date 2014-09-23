using System;

namespace adapterPattern.adapterPattern
{
    public class SimpleDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("I'm Flying");
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}