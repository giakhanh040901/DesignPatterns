namespace CommandDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fan = new Fan();
            ICommand turnOnCommnad = new TurnOnCommand(fan);
            ICommand turnOffCommnad = new TurnOffCommand(fan);
            turnOnCommnad.Execute();
            turnOffCommnad.Execute();
        }
    }
}
