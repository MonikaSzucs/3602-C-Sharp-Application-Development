using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpanDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "TimeSpan Demo";

            TimeSpan span = new TimeSpan(0, 0, 3690);

            Console.WriteLine($"Duration: {span.Hours:D2}:{span.Minutes:D2}:{span.Seconds:D2}");
            // outputs Duration: 01:01:30

            Console.WriteLine($"Total minutes: {span.TotalMinutes}\n");
            // outputs Total minutes: 61.5

            DateTime currentTime = DateTime.Now;

            DateTime futureEvent = new DateTime(2019, 12, 31, 20, 0, 0);
            Console.WriteLine($"Event scheduled at: {futureEvent:MMM d, yyyy hh:mm tt}");
            Console.WriteLine($"Current time:       {currentTime:MMM d, yyyy hh:mm tt}\n");

            TimeSpan timeToEvent = futureEvent - currentTime;

            Console.WriteLine("Event will occur in {0} day{1}, {2} hour{3}, {4} minute{5}, {6} second{7}.",
                               timeToEvent.Days,
                               timeToEvent.Days == 1 ? "" : "s",
                               timeToEvent.Hours,
                               timeToEvent.Hours == 1 ? "" : "s",
                               timeToEvent.Minutes,
                               timeToEvent.Minutes == 1 ? "" : "s",
                               timeToEvent.Seconds,
                               timeToEvent.Seconds == 1 ? "" : "s");
        }
    }
}
