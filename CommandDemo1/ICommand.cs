namespace CommandDemo1
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
