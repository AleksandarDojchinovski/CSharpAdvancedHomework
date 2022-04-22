using Models.Interfaces;

namespace UsersDataBase
{
    public class Database
    {
        public Student aleksandar = new()
        {
            Name = "Aleksandar",
            Id = 1,
            Username = "Acko",
            Password = "Aleksandar123",
            Grades = new Dictionary<string, int>
            {
                 { "Math",7} ,{"English",8},{"Programming",6}
            }
        };
        public Student petko = new()
        {
            Name = "Petko",
            Id = 2,
            Username = "5ko",
            Password = "Petko123",
            Grades = new Dictionary<string, int> 
            {
                {"Macedonian",10},{"History",9},{"Geography",8}
            }
        };
        public Teacher vlatko = new(1, "Vlatko", "Vlatche", "Vlatko123", "C# Advanced");
        public Teacher trajko = new(2, "Trajko", "Trale", "Trajko123", "Macedonian");
    }
}