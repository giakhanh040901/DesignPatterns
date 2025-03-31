namespace ObserverPattern.Notifiers
{
    public class PhoneNotifier : Observer
    {
        public PhoneNotifier(Subject subject)
        {
            this.subject = subject;
            this.subject.AddObserver(this);
        }

        public override void Notify(Subject subject, object arg)
        {
            if (subject is VideoData videoData)
            {
                Console.WriteLine($"Notify all subscribers via PHONE with new data: ");
                Console.WriteLine($"Title: {videoData.GetTitle()}");
                Console.WriteLine($"Description: {videoData.GetDescription()}");
                Console.WriteLine($"File Name: {videoData.GetFileName()}");
            }
        }
    }
}
