namespace ObserverPattern
{
    public class VideoData : Subject
    {
        private string _title;
        private string _description;
        private string _fileName;

        public string GetTitle()
        {
            return _title;
        }

        public void SetTitle(string title)
        {
            _title = title;
            VideoDataChange();
        }

        public string GetDescription()
        {
            return _description;
        }

        public void SetDescription(string description)
        {
            _description = description;
            VideoDataChange();
        }

        public string GetFileName()
        {
            return _fileName;
        }

        public void SetFileName(string fileName)
        {
            _fileName = fileName;
            VideoDataChange();
        }

        public void VideoDataChange() 
        {
            NotifyObserver(this, null);
        }
    }
}
