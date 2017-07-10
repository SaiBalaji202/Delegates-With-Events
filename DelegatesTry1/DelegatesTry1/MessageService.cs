using System;

namespace DelegatesTry1
{
    class MessageService
    {
        public void onVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Message Sended!" + e.Video);
        }
    }
}
