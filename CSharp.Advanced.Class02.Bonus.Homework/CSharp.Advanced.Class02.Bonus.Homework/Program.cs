// See https://aka.ms/new-console-template for more information

using Models;
using Services;

Database.Database data = new();
CarCenter carCenter = new CarCenter();

data.fiatBravo.Drive();
data.scania.Drive();

Console.WriteLine(data.fiatBravo.isClean);
carCenter.CarWash.WashCar(data.fiatBravo);
Console.WriteLine(data.fiatBravo.isClean);

carCenter.RepairService.CheckVehicle(data.scania);
carCenter.RepairService.FixVehicle(data.scania);
data.scania.isBroken = true;
carCenter.RepairService.CheckVehicle(data.scania);
carCenter.RepairService.FixVehicle(data.scania);

Console.WriteLine(data.fiatBravo.isGasFull);
carCenter.GasPump.PumpGas(data.fiatBravo);
carCenter.GasPump.PumpGas(data.scania);
Console.WriteLine(data.scania.isGasFull);

