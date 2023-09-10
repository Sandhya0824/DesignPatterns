using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclePrototypePattern
{
    public class BMWBuilder : IVehicle
    {
        public string Engine { get; set; }
        public string VehicleNo { get; set; }

        public IVehicle Clone()
        {
            Console.WriteLine("BMW is Cloned");
            return (IVehicle)MemberwiseClone();
        }

        public void Initialize()
        {
            Console.WriteLine("BMW is Initialized");
        }
    }
}
