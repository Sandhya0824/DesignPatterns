using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarmentFactoryMethodPattern
{
    public class MenFactory : GarmentFactory
    {
        private readonly Type _type;

        public MenFactory(Type garmentType)
        {
            _type = garmentType;
        }

        public override IGarment SelectType()
        {
            switch (_type)
            {
                case Type.Trouser:
                    return new TrouserMen();
                case Type.TeeShirt:
                    return new TeeShirtMen();
                case Type.Polos:
                    return new PolosMen();

            }
            return default;
        }

    }
}
