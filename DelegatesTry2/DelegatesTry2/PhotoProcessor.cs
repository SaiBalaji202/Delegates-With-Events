namespace DelegatesTry2
{
    class PhotoProcessor
    {

        public delegate void PhotoEventHandler(Photo p);
        public void Process(Photo p, PhotoEventHandler photoevehand)
        {
            photoevehand(p);
        }

        public void Process(Photo p, System.Action<Photo> photoevehand)
        {
            photoevehand(p);
        }

    }
}
