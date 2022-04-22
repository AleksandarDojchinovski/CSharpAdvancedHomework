using Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class GasPump : IGasPump
    {
        public void PumpGas(Vehicle vehicle)
        {
            Console.WriteLine($"Your {vehicle.Model} is now full with {vehicle.EUT}");
            vehicle.isGasFull = true;
        }
    }
}
