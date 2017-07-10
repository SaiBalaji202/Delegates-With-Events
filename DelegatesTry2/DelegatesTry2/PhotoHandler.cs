namespace DelegatesTry2
{

    class PhotoHandler
    {
        public void loadPhoto(Photo photo)
        {
            System.Console.WriteLine("Photo Loaded! " + photo.Name);
        }
        public void enhancePhoto(Photo photo)
        {
            System.Console.WriteLine("Photo Enhanced! " + photo.Name);
        }
    }
}
