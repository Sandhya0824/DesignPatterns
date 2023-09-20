using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace GarmentFactoryMethodPattern
{
    public abstract class GarmentFactory : IGarmentFactory
    {
        public static IGarment ChooseGarment(Section section, Type garmentType)
        {
            IGarmentFactory _garmentFactory = null;

            if (section == Section.Women)
            {
                _garmentFactory = new WomenFactory(garmentType);
            }
            else if (section == Section.Men)
            {
                _garmentFactory = new MenFactory(garmentType);
            }
            return _garmentFactory.SelectType();
        }

        public void Description()
        {

        }

        public virtual IGarment SelectType()
        {
            return null;
        }
    }
}
