namespace FourthTry.commandPattern
{
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}