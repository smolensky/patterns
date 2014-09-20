namespace FourthTry.commandPattern
{
    public class CeilingFanTurnOffCommand : ICommand
    {
        readonly CeilingFan _ceilingFan;

        public CeilingFanTurnOffCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _ceilingFan.TurnOff();
        }

        public void Undo()
        {
            _ceilingFan.TurnHigh();
        }
    }
}