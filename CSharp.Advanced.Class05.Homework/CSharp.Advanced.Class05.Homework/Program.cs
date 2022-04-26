// See https://aka.ms/new-console-template for more information
Database.Database database = new Database.Database();
Console.WriteLine("Persons firstnames  starting with 'R', ordered by Age -DESCENDING ORDER");

Database.Database.people.Where(x => x.FirstName[0] == 'R')
    .OrderByDescending(x=> x.Age)
    .ToList()
    .ForEach(x=> Console.WriteLine(x.FirstName));

Console.WriteLine("Brown dogs names and ages older than 3 years, ordered by Age -ASCENDING ORDER");
Database.Database.dogs.Where(x => x.Color == "Brown" && x.Age > 3)
    .OrderBy(x => x.Age)
    .Select(x => $"Dog name: {x.Name}, Age: {x.Age}")
    .ToList()
    .ForEach(x => Console.WriteLine(x));

Console.WriteLine("Persons with more than 2 dogs, ordered by Name -DESCENDING ORDER");
Database.Database.people.Where(x => x.Dogs.Count() > 2)
    .OrderByDescending(x => x.FirstName)
    .ToList()
    .ForEach(x => Console.WriteLine(x.FirstName));

Console.WriteLine("Freddy`s dogs names older than 1 year");

Database.Database.people.First(x => x.FirstName == "Freddy")
    .Dogs.Where(x => x.Age > 1)
    .ToList()
    .ForEach(x => Console.WriteLine(x.Name));
    

Console.WriteLine("Nathen`s first dog");

var nathenFirstDog = Database.Database.people.First(x => x.FirstName == "Nathen")
    .Dogs[0].Name;

Console.WriteLine(nathenFirstDog);

Console.WriteLine("All white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name " +
    "-ASCENDING ORDER");

Database.Database.people.Where(x=> x.FirstName == "Cristofer" || x.FirstName == "Freddy" || x.FirstName == "Erin"
|| x.FirstName == "Amelia")
    .SelectMany(x => x.Dogs)
    .Where(x=> x.Color == "White")
    .OrderBy(x=> x.Name)
    .ToList()
    .ForEach(x=> Console.WriteLine(x.Name));