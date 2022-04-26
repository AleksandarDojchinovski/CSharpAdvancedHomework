using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }  
        public int LivesLeft { get; set; }

        public override void PrintInfo()
        {
            if (Lazy)
            {
                Console.WriteLine($"{Name} is lazy cat with {LivesLeft} lives left");
            }
            else
            {
                Console.WriteLine($"{Name} is a cool cat with {LivesLeft} lives left");
            }
        }
    }
}
