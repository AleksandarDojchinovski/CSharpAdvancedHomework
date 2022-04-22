using Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CarWash : ICarWash
    {
        public void WashCar(Car car)
        {
            Console.WriteLine($"Your car {car.Model} is now clean!");
            car.isClean = true;
        }

        public void WashTruck(Truck truck)
        {
            Console.WriteLine($"Your truck {truck.Model} is now clean!");
            truck.isClean = true;
        }
    }
}
