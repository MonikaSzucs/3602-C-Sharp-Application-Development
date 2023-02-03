using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "DateTime Demo";

            DateTime today = new DateTime(2019, 10, 1);

            int year = today.Year;
            int month = today.Month;
            int day = today.Day;

            DateTime tomorrow = today.AddDays(1);
            DateTime yesterday = today.AddDays(-1);

            string todayString = today.ToString("MMM d, yyyy");
            // returns Oct 1, 2019

            Console.WriteLine($"Today is:      {todayString}");
            Console.WriteLine($"Tomorrow is:   {tomorrow.ToString("MMM d, yyyy")}");
            Console.WriteLine($"Yesterday was: {yesterday:MMM d, yyyy}\n");

            // get system date time
            Console.WriteLine($"System date:       {DateTime.Now:MMM d, yyyy}");
            Console.WriteLine($"System date/time:  {DateTime.Now:MMM d, yyyy hh:mm tt}");
            Console.WriteLine($"System date/time2: {DateTime.Now:MMM d, yyyy hh:mm:ss tt}");
            Console.WriteLine($"System ticks:      {DateTime.Now.Ticks:N0}");
        }
    }
}
