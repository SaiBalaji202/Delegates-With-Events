using System;

namespace DelegatesTry1
{
    class MailService
    {
        public void onVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Mail Sended! " + e.Video);
        }
    }
}
