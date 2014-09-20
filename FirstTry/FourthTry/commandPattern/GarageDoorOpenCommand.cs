namespace FourthTry.commandPattern
{
    public class GarageDoorOpenCommand : ICommand
    {
        readonly GarageDoor _garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Up();
        }
    }
}