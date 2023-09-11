using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class PngImageAdapter : IImage
    {
        private PngImage pngImage;

        public PngImageAdapter(PngImage image)
        {
            pngImage = image;
        }

        public void DisplayImage()
        {
            pngImage.ShowPngImage();
        }

    }
}
