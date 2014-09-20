using System.Text;

namespace FourthTry.commandPattern
{
    public class SimpleRemoteControl
    {
        readonly ICommand[] _onCommands;
        readonly ICommand[] _offCommands;
        ICommand _undoCommand;

        public SimpleRemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
            _undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand) 
		{
			_onCommands[slot] = onCommand;
			_offCommands[slot] = offCommand;
		}

        public void OnButtonWasPressed(int slot)
        {
            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }
        
        public void OffButtonWasPressed(int slot)
        {
            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }

        public void UndoButtonWasPressed()
        {
            _undoCommand.Undo();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("\n------ Remote Control -------\n");
            for (int i = 0; i < _onCommands.Length; i++)
            {
                sb.Append("[slot " + i + "] " + _onCommands[i].GetType().Name + "    " + _offCommands[i].GetType().Name + "\n");
            }
            return sb.ToString();
        }
    }
}
