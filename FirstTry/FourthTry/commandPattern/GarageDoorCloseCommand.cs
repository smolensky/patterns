namespace FourthTry.commandPattern
{
    public class GarageDoorCloseCommand : ICommand
    {
        readonly GarageDoor _garageDoor;

        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public object Execute()
        {
            return _garageDoor.Down();
        }
    }
}