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
            var lightOff = new LightOffCommand(light);

            var garageDoorOpen = new GarageDoorOpenCommand(garageDoor);
            var garageDoorClose = new GarageDoorCloseCommand(garageDoor);

            remote.SetCommand(0, lightOn, lightOff);
            remote.SetCommand(1, garageDoorOpen, garageDoorClose);

            Console.WriteLine(remote);

            remote.OnButtonWasPressed(0);
            remote.OnButtonWasPressed(1);
            remote.OffButtonWasPressed(0);
            remote.OffButtonWasPressed(1);

            Console.ReadKey();
        }
    }
}
