using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Advanced.Class03.Homework
{
    public static class DogShelter
    {
        public static List<Dog> DogList { get; set; } = new List<Dog>();
        public static void AddDog(Dog dog) 
        {
            if (Dog.Validate(dog))
            {
                DogList.Add(dog);
            }
            else
            {
                Console.WriteLine($"Invalid dog!");
            }
        }
        public static void PrintAll() 
        {
            Console.WriteLine("Sheltered dogs:");
            DogList.ForEach(dog => Console.WriteLine(dog.Name));
        }
    }
}
