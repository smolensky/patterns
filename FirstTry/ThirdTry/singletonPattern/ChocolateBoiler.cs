using System;

namespace ThirdTry.singletonPattern
{
    class ChocolateBoiler
    {
        public static ChocolateBoiler UniqueInstance;
        private bool _empty;
        private bool _boiled;


        private ChocolateBoiler()
        {
            _empty = true;
            _boiled = false;
        }

        public static ChocolateBoiler GetInstance()
        {
            if (UniqueInstance == null)
                return UniqueInstance = new ChocolateBoiler();
            return UniqueInstance;
        }

        public void Fill()
        {
            if (IsEmpty())
            {
                _empty = false;
                _boiled = false;
                Console.WriteLine("Filling . . .");
            }
            else
                Console.WriteLine("Is full!!!");
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                _empty = true;
                Console.WriteLine("Draining . . .");
            }
            else
                Console.WriteLine("Nothing to drain or not boiled!!!");
        }

        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                _boiled = true;
                Console.WriteLine("Boiling . . .");
            }
            else
                Console.WriteLine("Empty or already boiled!!!");
        }

        public bool IsEmpty()
        {
            return _empty;
        }

        public bool IsBoiled()
        {
            return _boiled;
        }
    }
}
