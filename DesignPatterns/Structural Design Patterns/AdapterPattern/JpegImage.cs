using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class JpegImage : IImage
    {
        public void DisplayImage()
        {
            Console.WriteLine("Displaying JPEG image");
        }
    }
}
