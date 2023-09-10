using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclePrototypePattern
{
    public class VehicleManager
    {
        BMWBuilder bmw;
        AudiBuilder audi;

        public VehicleManager()
        {
            bmw = new BMWBuilder();
            bmw.Initialize();

            audi = new AudiBuilder();
            audi.Initialize();
        }

        public IVehicle CreateAudi()
        {
            return audi.Clone();
        }

        public IVehicle CreateBMW()
        {
            return bmw.Clone();
        }
    }
}
