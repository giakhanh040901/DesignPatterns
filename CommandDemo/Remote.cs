namespace CommandDemo
{
    public class Remote
    {
        private readonly ICommand _turnOnCommand;
        private readonly ICommand _turnOffCommand;

        public Remote(ICommand turnOnCommand, ICommand turnOffCommand)
        {
            _turnOnCommand = turnOnCommand;
            _turnOffCommand = turnOffCommand;
        }

        public void TurnOnButtonClick()
        {
            _turnOnCommand.Execute();
        }

        public void TurnOffButtonClick() 
        {
            _turnOffCommand.Execute();
        }
    }
}
