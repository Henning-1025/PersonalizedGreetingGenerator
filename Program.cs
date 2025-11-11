namespace PersonalizedGreetingGenerator;

class Program
{
    static void Main(string[] args)
    {
        DateTime currentDateTime = DateTime.Now;

        string currentDate = currentDateTime.ToString("yyyy-MM-dd");
        string currentTime = currentDateTime.ToString("HH:mm:ss");
        string dayOfWeek = currentDateTime.ToString("dddd");

        Console.WriteLine($"Hello! Today is {dayOfWeek}, {currentDate} and the current time is {currentTime}.");

    }
}
