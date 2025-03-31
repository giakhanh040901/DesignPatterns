namespace CommandDemo1
{
    public class TurnOnCommand : ICommand
    {
        private readonly Fan _fan;

        public TurnOnCommand(Fan fan)
        {
            _fan = fan;
        }
        public void Execute()
        {
            _fan.TurnOn();
        }

        public void Undo()
        {
            _fan.TurnOff();
        }
    }
}
