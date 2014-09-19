namespace FourthTry.commandPattern
{
    public class NoCommand : ICommand
    {
        public object Execute()
        {
            return "no";
        }
    }
}