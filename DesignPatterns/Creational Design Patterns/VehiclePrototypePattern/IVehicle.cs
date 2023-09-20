using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclePrototypePattern
{
    public interface IVehicle
    {
        string Engine { get; set; }
        string VehicleNo { get; set; }
        void Initialize();
        IVehicle Clone();
    }
}
