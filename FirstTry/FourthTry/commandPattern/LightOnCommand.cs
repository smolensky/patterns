﻿namespace FourthTry.commandPattern
{
    public class LightOnCommand : ICommand
    {
        readonly Light  _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
           _light.On();
        }
    }
}