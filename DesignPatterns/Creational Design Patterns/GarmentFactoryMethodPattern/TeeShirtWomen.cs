using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarmentFactoryMethodPattern
{
    public class TeeShirtWomen : AbstractWomen
    {
        public override string ToString()
        {
            return $"Women's TeeShirt";
        }
    }
}
