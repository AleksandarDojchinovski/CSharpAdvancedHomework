using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Truck : Vehicle
    {
        public TruckType TruckType { get; set; }
        public override void Drive()
        {
            Console.WriteLine($"The {Model} we are driving is a {TruckType}");
        }
    }
}
