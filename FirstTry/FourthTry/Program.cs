using System;
using FourthTry.commandPattern;

namespace FourthTry
{
    class Program
    {
        static void Main()
        {
            var remote = new SimpleRemoteControl();
            var light = new Light();
            var garageDoor = new GarageDoor();
            var lightOn = new LightOnCommand(light);
            var garageOpen = new GarageDoorOpenCommand(garageDoor);
            
            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();
            remote.SetCommand(garageOpen);
            remote.ButtonWasPressed();

            Console.ReadKey();
        }
    }
}
