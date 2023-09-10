using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarmentFactoryMethodPattern
{
    public interface IGarmentFactory : IGarment
    {
        IGarment SelectType();
    }
}
