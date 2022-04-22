using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Advanced.Class03.Homework
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public void Bark()
        {
            Console.WriteLine($"{Name}: Bark Bark!!");
        }
        public static bool Validate(Dog dog)
        {
            if (dog.Name == "" || dog.Id <= 0 || dog.Color == "")
            {
                //Console.WriteLine("Fill all properties!!");
                return false;
            }
            else if (dog.Name.Length <= 2) 
            {
                //Console.WriteLine("Your dog name is too short");
                return false;
            }
            else
            {
                //Console.WriteLine($"The dog {dog.Name} is a good boy");
                return true;
            }
        }
    }
}
