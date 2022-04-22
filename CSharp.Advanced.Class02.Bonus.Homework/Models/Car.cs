using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Car : Vehicle
    {
        public CarType CarType { get; set; }
        public override void Drive()
        {
            Console.WriteLine($"The {Model} is {CarType}, is using {EUT} engine and it has {HorsePower} hp");
        }
    }
}
