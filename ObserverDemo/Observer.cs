namespace ObserverDemo
{
    public abstract class Observer
    {
        protected Subject subject;
        public abstract void Notify(Subject subject);
    }
}
