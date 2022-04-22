using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Vehicle
    {
        public bool isClean { get; set; }
        public bool isGasFull { get; set; }
        public bool isBroken {get;set;}
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string Color { get; set; }
        public EngineUsageType EUT { get; set; }
        public Vehicle() { }
        public Vehicle(string model, int hp, string color,EngineUsageType eut)
        {
            Model = model;
            HorsePower = hp;
            Color = color;
            EUT = eut;
        }
        public abstract void Drive();
    }
}
