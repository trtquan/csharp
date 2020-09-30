using System;

namespace date_time
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentTime = DateTime.Now;
            var today = DateTime.Today;
            var someDate = new DateTime(2020, 10, 1);
            var tomorrow = DateTime.Today.AddDays(1);
            var yesterday = DateTime.Today.AddDays(-1);
            Console.WriteLine($"{nameof(currentTime)}: {currentTime}");
            Console.WriteLine($"{nameof(today)}: {today}");
            Console.WriteLine($"{nameof(someDate)}: {someDate}");
            Console.WriteLine($"{nameof(tomorrow)}: {tomorrow}");
            Console.WriteLine($"{nameof(yesterday)}: {yesterday}");

            DateTime nextYear = new DateTime(DateTime.Today.Year + 1, 1, 1);
            TimeSpan duration = nextYear - DateTime.Today;
            Console.WriteLine($"There are {duration.TotalDays} days left in the year");
        }
    }
}
