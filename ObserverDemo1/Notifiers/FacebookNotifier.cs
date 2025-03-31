namespace ObserverDemo1.Notifiers
{
    public class FacebookNotifier : Observer
    {
        public FacebookNotifier(Subject subject) 
        {
            Subject = subject;
            Subject.AddObserver(this);
        }
        public override void Notify()
        {
            if (Subject is VideoData videoData)
            {
                Console.WriteLine("Notify Facebook");
                Console.WriteLine("Name: " + videoData.GetName());
                Console.WriteLine("Description: " + videoData.GetDescription());
            }
        }
    }
}
