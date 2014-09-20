using System;

namespace FourthTry.commandPattern
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("no");
        }

        public void Undo()
        {
            Console.WriteLine("nothing to undo");
        }
    }
}