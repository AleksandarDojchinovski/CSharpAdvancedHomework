using Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RepairService : IRepairService
    {
        public void CheckVehicle(Vehicle vehicle)
        {
            if (vehicle.isBroken)
            {
                Console.WriteLine("You need to repair your vehicle.");
            }
            else
            {
                Console.WriteLine("Your vehicle is in a good shape.");
            }
        }

        public void FixVehicle(Vehicle vehicle)
        {
            if (vehicle.isBroken)
            {
                Console.WriteLine("Your vehicle is now fixed!");
                vehicle.isBroken = false;
            }
            else
            {
                Console.WriteLine("You have nothing to repair!");
            }
        }
    }
}
