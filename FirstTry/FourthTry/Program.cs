﻿using System;
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
            var ceilingFan = new CeilingFan();

            var lightOn = new LightOnCommand(light);
            var lightOff = new LightOffCommand(light);

            var garageDoorOpen = new GarageDoorOpenCommand(garageDoor);
            var garageDoorClose = new GarageDoorCloseCommand(garageDoor);

            var ceilingFanTurnOn = new CeilingFanTurnOnHighCommand(ceilingFan);
            var ceilingFanTurnOff = new CeilingFanTurnOffCommand(ceilingFan);

            remote.SetCommand(0, lightOn, lightOff);
            remote.SetCommand(1, garageDoorOpen, garageDoorClose);
            remote.SetCommand(2, ceilingFanTurnOn, ceilingFanTurnOff);

            Console.WriteLine(remote);

            remote.OnButtonWasPressed(0);
            remote.OffButtonWasPressed(0);
            remote.OnButtonWasPressed(1);
            remote.OffButtonWasPressed(1);
            remote.OnButtonWasPressed(2);
            //remote.OffButtonWasPressed(2);

            remote.UndoButtonWasPressed();
            //remote.UndoButtonWasPressed();
            //remote.UndoButtonWasPressed();

            Console.ReadKey();
        }
    }
}
