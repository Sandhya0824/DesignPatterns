namespace VehiclePrototypePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleManager vehicleManager = new VehicleManager();

            for (int i = 0; i < 5; i++)
            {
                IVehicle vehicle = vehicleManager.CreateAudi();
                IVehicle vehicle1 = vehicleManager.CreateBMW();
            }
        }
    }
}