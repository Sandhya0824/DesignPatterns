using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarmentFactoryMethodPattern
{
    public class WomenFactory : GarmentFactory
    {
        private readonly Type _type;

        public WomenFactory(Type garmentType)
        {
            _type = garmentType;
        }

        public override IGarment SelectType()
        {
            switch (_type)
            {
                case Type.TeeShirt:
                    return new TeeShirtWomen();
                case Type.Dress:
                    return new DressWomen();
            }
            return default;
        }
    }
}
