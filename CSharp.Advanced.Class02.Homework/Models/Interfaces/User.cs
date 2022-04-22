using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User() { }
        public User(int id, string name, string userName, string password)
        {
            Id = id;
            Name = name;
            Username = userName;
            Password = password;
        }
        public virtual void PrintInfo() 
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Username: {Username}");
        }
    }
}
