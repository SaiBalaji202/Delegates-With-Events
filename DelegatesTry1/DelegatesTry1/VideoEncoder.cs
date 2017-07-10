using System;

namespace DelegatesTry1
{
    class VideoEncoder
    {
        // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs e);
        // public event VideoEncodedEventHandler VideoEncoded;

        public EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video....");
            System.Threading.Thread.Sleep(2000);
            onVideoEncoded(video);
        }

        protected virtual void onVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video.Title });
            }
        }
    }
}
