﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public int Size { get; set; }
        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} is {Color} fish and is {Size}cm long");
        }
    }
}
