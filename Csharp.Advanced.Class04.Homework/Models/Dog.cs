using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Dog : Pet
    {
        public bool GoodBoi { get; set; }
        public string FavouriteFood { get; set; }
        public override void PrintInfo()
        {
            if (GoodBoi)
            {
                Console.WriteLine($"{Name} is a good boi and he's getting his favourite food {FavouriteFood}");
            }
            else
            {
                Console.WriteLine($"{Name} is not a good boi and he's not getting his favourite food {FavouriteFood}");
            }
        }
    }
}
