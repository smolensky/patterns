using System;

namespace FourthTry.commandPattern
{
    public class CeilingFan
    {
        public int High = 3;
        public int Medium = 2;
        public int Low = 1;
        public int Off = 0;
        private int _speed;

        public CeilingFan()
        {
            _speed = Off;
        }

        public void TurnHigh()
        {
            _speed = High;
            Console.WriteLine("Blowing strong");
        }
        
        public void TurnMedium()
        {
            _speed = Medium;
            Console.WriteLine("Blowing medium");
        }
        
        public void TurnLow()
        {
            _speed = Low;
            Console.WriteLine("Blowing weak");
        }

        public void TurnOff()
        {
            _speed = Off;
            Console.WriteLine("Turned off");
        }

        public int GetSpeed()
        {
            return _speed;
        }
    }
}