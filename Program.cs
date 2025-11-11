
using System;
using System.Globalization;

namespace PersonalizedGreetingGenerator;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your name:");
        string userName = Console.ReadLine() ?? "Friend";
        
        if (string.IsNullOrWhiteSpace(userName))
        {
            userName = "Friend";
        }

        DateTime currentDateTime = DateTime.Now;

        string currentDate = currentDateTime.ToString("yyyy-MM-dd");
        string currentTime = currentDateTime.ToString("HH:mm:ss");
        string dayOfWeek = currentDateTime.ToString("dddd");

        string timeOfDay = currentDateTime.Hour switch
        {
            >= 5 and < 12 => "Good morning",
            >= 12 and < 17 => "Good afternoon", 
            >= 17 and < 21 => "Good evening",
            _ => "Good night"
        };

        Console.WriteLine($"{timeOfDay}, {userName}! Today is {dayOfWeek}, {currentDate} and the current time is {currentTime}.");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
