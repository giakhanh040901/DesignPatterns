namespace ObserverDemo1.Notifiers
{
    public class YoutubeNotifier : Observer
    {
        public YoutubeNotifier(Subject subject) 
        {
            Subject = subject;
            Subject.AddObserver(this);
        }
        public override void Notify()
        {
            if (Subject is VideoData videoData)
            {
                Console.WriteLine("Notify Youtube");
                Console.WriteLine("Name: " + videoData.GetName());
                Console.WriteLine("Description: " + videoData.GetDescription());
            }
        }
    }
}
