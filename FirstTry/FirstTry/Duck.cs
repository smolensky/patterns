using System;

namespace FirstTry
{
    class Programm
    {
        static void Main()
        {
            var littleDuck = new RubberDuck();
            var woodenDuck = new WoodenDuck();
            var simleDuck = new SimpleDuck();

            Console.WriteLine("1st duck");
            littleDuck.Fly();
            littleDuck.Quack();
            littleDuck.Swim();

            Console.WriteLine("\n");

            Console.WriteLine("2nd duck");
            woodenDuck.Fly();
            woodenDuck.Quack();
            woodenDuck.Swim();

            Console.WriteLine("\n");

            Console.WriteLine("3rd duck");
            simleDuck.PerformFly();
            simleDuck.PerformQuack();
            simleDuck.Swim();

            Console.ReadKey();
        }
    }

    public abstract class Duck
    {
        public abstract void Swim();

        public void PerformFly()
        {
            FlyBehavior flyBehavior = new FlyBehavior();
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior quackBehavior = new QuackBehavior();
            quackBehavior.Quack();
        }
    }

    public class FlyBehavior
    {
        public virtual void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }

    public class FlyWithWings : FlyBehavior
    {
        public override void Fly()
        {
            Console.WriteLine("With wings!");
        }
    }

    public class FlyWithOutWings : FlyBehavior
    {
        public override void Fly()
        {
            Console.WriteLine("I can't fly!");
        }
    }

    public class QuackBehavior
    {
        public virtual void Quack()
        {
            Console.WriteLine("I'm quacking");
        }
    }

    public class MuteQuack : QuackBehavior
    {
        public override void Quack()
        {
            Console.WriteLine("....");
        }
    }

    public class Squeack : QuackBehavior
    {
        public override void Quack()
        {
            Console.WriteLine("Pew! Pew! Pew!!!");
        }
    }

    public class RubberDuck : Duck
    {
        public override void Swim()
        {
            Console.WriteLine("I'm swimming");
        }

        public void Fly()
        {
            var tryFly = new FlyWithOutWings();
            tryFly.Fly();
        }

        public void Quack()
        {
            var tryQuack = new Squeack();
            tryQuack.Quack();
        }
    }

    public class WoodenDuck : Duck
    {
        public override void Swim()
        {
            Console.WriteLine("I'm swimming");
        }

        public void Fly()
        {
            var tryFly = new FlyWithOutWings();
            tryFly.Fly();
        }

        public void Quack()
        {
            var tryQuack = new MuteQuack();
            tryQuack.Quack();
        }
    }

    public class SimpleDuck : Duck
    {
        public override void Swim()
        {
            Console.WriteLine("I'm swimming!");
        }
    }
}
