namespace CommandDemo
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
