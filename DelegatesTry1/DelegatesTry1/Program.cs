using System;

namespace DelegatesTry1
{
    class Program
    {
        static void Main(string[] args)
        {
            Video v = new Video() { Title = "Sai Baba Song.mp4" };
            VideoEncoder ve = new VideoEncoder();

            MailService mailserv = new MailService();
            MessageService msgserv = new MessageService();

            ve.VideoEncoded += mailserv.onVideoEncoded;
            ve.VideoEncoded += msgserv.onVideoEncoded;

            ve.Encode(v);
            Console.WriteLine("Encoded");
            Console.ReadLine();
        }
    }
}
