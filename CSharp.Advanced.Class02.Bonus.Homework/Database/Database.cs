using Models;

namespace Database
{
    public class Database
    {
        public Car fiatBravo = new()
        {
            Model = "Fiat",
            Color = "Grey",
            HorsePower = 120,
            CarType = Models.Enums.CarType.Sedan,
            EUT = Models.Enums.EngineUsageType.Oil
        };
        public Truck scania = new()
        {
            Model = "Scania",
            Color = "Black",
            HorsePower = 1200,
            EUT = Models.Enums.EngineUsageType.Electricity,
            TruckType = Models.Enums.TruckType.FireTruck
        };
    }
}