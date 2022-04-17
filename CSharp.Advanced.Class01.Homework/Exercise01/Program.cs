// See https://aka.ms/new-console-template for more information

// 1. Create a console application that detects provided names in a provided text 

// The application should ask for names to be entered until the user enters x
// After that, the application should ask for a text
// When that is done the application should show how many times that name was included in the text ignoring upper/lower case

List<string> namesList = new List<string>();

while (true)
{
    Console.WriteLine("Enter a name:");
    string name = Console.ReadLine();
    if(name.ToUpper() == "X")
    {
        break;
    }
    else if(name == "")
    {
        Console.WriteLine("You must enter a name!");
    }
    else
    {
        namesList.Add(name);
    }
}
Console.WriteLine("Enter a text");

string text = Console.ReadLine();

List<string> newText = text.Split(" ").ToList();

foreach(string name in namesList)
{
    int counter = 0;
    foreach (string word in newText)
    {
        if(name.ToUpper() == word.ToUpper())
        {
            counter++;
        }
    }
    Console.WriteLine($"The name {name} is repeated {counter} times");
}
