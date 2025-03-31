namespace ObserverDemo.Notifier
{
    public class FacebookNotifier : Observer
    {
        public FacebookNotifier(Subject subject)
        {
            this.subject = subject;
            this.subject.AddObserver(this);
        }

        public override void Notify(Subject subject)
        {
            if (subject is VideoData videoData)
            {
                Console.WriteLine("Change");
                Console.WriteLine("Name:" + videoData.GetName());
                Console.WriteLine("Description:" + videoData.GetDescription());
            }
        }
    }
}
