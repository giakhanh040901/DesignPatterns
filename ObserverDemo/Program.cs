using ObserverDemo.Notifier;

namespace ObserverDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var videoData = new VideoData();
            var email = new EmailNotifier(videoData);
            var facebook = new FacebookNotifier(videoData);

            videoData.SetDescription("Gao o");
            videoData.RemoveObserver(facebook);
            Console.WriteLine("----------------------");
            videoData.SetName("Meo meo");
        }
    }
}
