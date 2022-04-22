using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public class Student : User, IStudent
    {
        public Dictionary<string, int> Grades { get; set;}
        public Student() { }
        public Student(int id,string name,string userName,string password, Dictionary<string,int> grades) 
            : base(id, name, userName, password) 
        {
            Grades = grades;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} Grades:");
            Console.WriteLine();
            foreach (KeyValuePair<string,int> pair in Grades) 
            {
                Console.WriteLine($"Subject: {pair.Key} - {pair.Value}");
            }
            Console.WriteLine("---------------------------------------");
        }
    }
}
