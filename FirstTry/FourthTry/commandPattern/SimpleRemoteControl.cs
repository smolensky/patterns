using System.Text;

namespace FourthTry.commandPattern
{
    public class SimpleRemoteControl
    {
        readonly ICommand[] _onCommands;
        readonly ICommand[] _offCommands;

        public SimpleRemoteControl()
        {
            _onCommands = new ICommand[5];
            _offCommands = new ICommand[5];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 1; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand) 
		{
			_onCommands[slot] = onCommand;
			_offCommands[slot] = offCommand;
		}

        public object OnButtonWasPressed(int slot)
        {
            return _onCommands[slot].Execute();
        }
        
        public object OffButtonWasPressed(int slot)
        {
            return _offCommands[slot].Execute();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("\n------ Remote Control -------\n");
            for (int i = 0; i < 2; i++)
            {
                sb.Append("[slot " + i + "] " + _onCommands[i].GetType().Name + "    " + _offCommands[i].GetType().Name + "\n");
            }
            return sb.ToString();
        }
    }
}
