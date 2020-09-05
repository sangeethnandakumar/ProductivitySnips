using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProductivitySniplets
{

    public class VideoEventArgs : EventArgs
    {
        public string EncodedVideoLocation { get; set; }
    }


    public class VideoEncorder
    {
        //Define events with in-built generic delegates
        public event EventHandler<VideoEventArgs> OnEncodingStarted;
        public event EventHandler<VideoEventArgs> OnEncodingFinished;

        public void Encode(string video)
        {
            //Raise events on start...
            RaiseStarted(video);

            Thread.Sleep(3000);

            //Raise events on end...
            RaiseFinished(video);
        }

        protected virtual void RaiseStarted(string video)
        {
            OnEncodingStarted?.Invoke(this, new VideoEventArgs { EncodedVideoLocation = video });
        }

        protected virtual void RaiseFinished(string video)
        {
            OnEncodingFinished?.Invoke(this, new VideoEventArgs { EncodedVideoLocation = video });
        }
    }
}
