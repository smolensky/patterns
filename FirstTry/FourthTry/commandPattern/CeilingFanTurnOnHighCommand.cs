namespace FourthTry.commandPattern
{
    public class CeilingFanTurnOnHighCommand : ICommand
    {
        readonly CeilingFan _ceilingFan;
        int _prevSpeed;

        public CeilingFanTurnOnHighCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _ceilingFan.TurnHigh();
            _prevSpeed = _ceilingFan.High;
        }

        public void Undo()
        {
            if (_prevSpeed == _ceilingFan.High)
                _ceilingFan.TurnMedium();
            else if (_prevSpeed == _ceilingFan.Medium)
                _ceilingFan.TurnLow();
            else if (_prevSpeed == _ceilingFan.Low)
                _ceilingFan.TurnOff();
        }
    }
}