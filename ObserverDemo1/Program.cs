using ObserverDemo1.Notifiers;

namespace ObserverDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var videoData = new VideoData();
            var facebook = new FacebookNotifier(videoData);
            var youtube = new YoutubeNotifier(videoData);
            videoData.SetDescription("Hề lố anh chị iem");
            videoData.RemoveObserver(youtube);
            videoData.SetDescription("leu leu kenh chat FA");
        }
    }
}
