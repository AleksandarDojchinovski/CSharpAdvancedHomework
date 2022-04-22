// See https://aka.ms/new-console-template for more information

using CSharp.Advanced.Class03.Homework;

Dog sparky = new()
{
    Name = "Sparky",
    Color = "Brown",
    Id = 1
};
Dog rex = new() 
{
    Name = "Rex",
    Color = "Brown/Black",
    Id = 2
};
Dog rocky = new() { };

DogShelter.AddDog(rex);
DogShelter.AddDog(rocky);

DogShelter.AddDog(sparky);
DogShelter.PrintAll();



