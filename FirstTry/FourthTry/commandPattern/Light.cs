using System;

namespace FourthTry.commandPattern
{
    public class Light
    {
        public object On()
        {
            return "Light was turned on";
        }

        public object Off()
        {
            return "Light was turned off";
        }
    }
}