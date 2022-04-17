// See https://aka.ms/new-console-template for more information


// 2. Create a console application that checks if a day is a working day 🔹

// The app should request for a user to enter a date as an input or multiple inputs
// The app should then open and see if the day is a working day
// It should show the user a message whether the date they entered is working or not
// Weekends are not working
// 1 January, 7 January, 20 April, 1 May, 25 May, 3 August, 8 September, 12 October, 23 October, and 8 December are not working days as well
// It should ask the user if they want to check another date
// Yes - the app runs again
// No - the app closes

while (true) { 

Console.WriteLine("Enter a date");

bool isDate = DateTime.TryParse(Console.ReadLine(), out DateTime date);

try
{
    if (!isDate)
    {
        throw new Exception("Invalid input , enter date!");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

bool weekend = false;

if(date.DayOfWeek.Equals(DayOfWeek.Saturday) || date.DayOfWeek.Equals(DayOfWeek.Sunday))
{
    weekend = true;
}
List<DateTime> notWorkingDates = new List<DateTime>()
{
    new DateTime(date.Year, 1, 1),
    new DateTime(date.Year, 1, 7),
    new DateTime(date.Year, 4, 20),
    new DateTime(date.Year, 5, 1),
    new DateTime(date.Year, 5, 25),
    new DateTime(date.Year, 8, 3),
    new DateTime(date.Year, 9, 8),
    new DateTime(date.Year, 10, 12),
    new DateTime(date.Year, 10, 23),
    new DateTime(date.Year, 12, 8),
};

if(notWorkingDates.Any(d => d.Equals(date)) || weekend)
{
    Console.WriteLine($"{date.Date} is not working day");
}
else
{
    Console.WriteLine($"{date.Date} is working day ");
}
    var isInputInvalid = true;
    string userAnswer = string.Empty;
    while(isInputInvalid)
    {
        Console.WriteLine("You want to try another date?");
        Console.WriteLine("Yes or No?");

        userAnswer = Console.ReadLine();

        if (userAnswer.ToUpper() == "YES")
        {
            isInputInvalid = false;
        }
        else if (userAnswer.ToUpper() == "NO")
        {
            isInputInvalid = false;
        }
        else
        {
            Console.WriteLine("Invalid input");
        }

    }
    if(userAnswer.ToUpper() == "NO")
    {
        break;
    }


}