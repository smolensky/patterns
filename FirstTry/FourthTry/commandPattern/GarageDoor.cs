using System;

namespace FourthTry.commandPattern
{
    public class GarageDoor
    {
        public object Up()
        {
            return "Garage door was opened.";
        }

        public object Down()
        {
            return "Garage door was closed.";
        }

        public void Stop()
        {
            Console.WriteLine("Garage door moving was stopped.");
        }

        public void LightOn()
        {
            Console.WriteLine("Light in garage was turned on");
        }

        public void LightOff()
        {
            Console.WriteLine("Light in garage was turned off");
        }
    }
}