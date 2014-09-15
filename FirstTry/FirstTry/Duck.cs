using System;

namespace FirstTry
{
    class Programm
    {
        static void Main()
        {
            Duck littleDuck = new RubberDuck();
            Duck woodenDuck = new WoodenDuck();
            Duck simleDuck = new SimpleDuck();

            Console.WriteLine("1st duck");
            littleDuck.PerformFly();
            littleDuck.PerformQuack();
            littleDuck.Swim();

            Console.WriteLine("\n");

            Console.WriteLine("2nd duck");
            woodenDuck.PerformFly();
            woodenDuck.PerformQuack();
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

        public IFlyBehavior FlyBehavior;
        public IQuackBehavior QuackBehavior;

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }
    }

    public interface IFlyBehavior
    {
        void Fly();
    }

    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("With wings!");
        }
    }

    public class FlyWithOutWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly!");
        }
    }

    public interface IQuackBehavior
    {
        void Quack();
    }

    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("....");
        }
    }

    public class Squeack : IQuackBehavior
    {
        public void Quack()
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

        public RubberDuck()
        {
            QuackBehavior = new Squeack();
            FlyBehavior = new FlyWithOutWings();
        }
    }

    public class WoodenDuck : Duck
    {
        public override void Swim()
        {
            Console.WriteLine("I'm swimming");
        }

        public WoodenDuck()
        {
            QuackBehavior = new MuteQuack();
            FlyBehavior = new FlyWithOutWings();
        }
    }

    public class SimpleDuck : Duck
    {
        public override void Swim()
        {
            Console.WriteLine("I'm swimming!");
        }

        public SimpleDuck()
        {
            QuackBehavior = new Squeack();
            FlyBehavior = new FlyWithWings();
        }
    }
}
