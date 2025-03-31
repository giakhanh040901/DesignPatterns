namespace ObserverPattern
{
    public class Subject 
    {
        private List<Observer> _observers = new List<Observer>();

        public void AddObserver(Observer observer) 
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(Observer observer) 
        {
            _observers.Remove(observer);
        }

        public void NotifyObserver(Subject subject, object arg)
        {
            _observers.ForEach(x => x.Notify(subject, arg));
        }
    }
}
