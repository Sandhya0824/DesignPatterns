namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IImage jpegImage = new JpegImage();
            IImage pngImage = new PngImageAdapter(new PngImage());

            jpegImage.DisplayImage();

            pngImage.DisplayImage();
        }
    }
}