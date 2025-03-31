using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDemo1
{
    public class VideoData : Subject
    {
        private string _name;
        private string _description;

        public void SetName(string name)
        {
            _name = name;
            VideoDataChange();
        }

        public string GetName()
        {
            return _name;
        }

        public void SetDescription(string description) 
        {
            _description = description;
            VideoDataChange();
        }

        public string GetDescription() 
        {
            return _description;
        }

        public void VideoDataChange()
        {
            NotifyObserver();
        }
    }
}
