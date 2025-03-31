using ObserverPattern.Notifiers;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var videoData = new VideoData();
            var email = new EmailNotifier(videoData);
            _ = new PhoneNotifier(videoData);
            _ = new YoutubeNotifier(videoData);

            videoData.SetTitle("Observer Design Pattern");
            Console.WriteLine("-----------------------------");
            videoData.RemoveObserver(email);
            videoData.SetDescription("Gao ồ");
        }
    }
}
