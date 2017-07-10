namespace DelegatesTry2
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("Using Custome Delegates: ");
            Photo photo = new Photo() { Name = "Sai.jpg" };
            PhotoHandler photohand = new PhotoHandler();

            PhotoProcessor.PhotoEventHandler photoehand = photohand.loadPhoto;
            photoehand += photohand.enhancePhoto;

            PhotoProcessor pp = new PhotoProcessor();
            pp.Process(photo, photoehand);

            System.Console.WriteLine("Using Action Delegates: ");
            System.Action<Photo> actionhand = photohand.loadPhoto;
            actionhand += photohand.enhancePhoto;

            pp = new PhotoProcessor();
            pp.Process(photo, actionhand);

            System.Console.ReadLine();

        }

    }
}
