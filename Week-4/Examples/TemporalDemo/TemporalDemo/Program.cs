using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemporalDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Temporal Demo";

            DateTime today = DateTime.Now;

            DateTime tomorrow = today.AddDays(1);

            DateTime yesterday = today.AddDays(-1);

            DateTime yesterdayDateOnly = yesterday.Date;

            TimeSpan yesterdayTimeOnly = yesterday.TimeOfDay;

            DateTime beginningOfMonth = new DateTime(DateTime.Now.Year
                                                   , DateTime.Now.Month
                                                   , 1);

            DateTime endOfMonth = beginningOfMonth.AddMonths(1).AddDays(-1);

            DateTime beginningOfYear = new DateTime(DateTime.Now.Year
                                                  , 1
                                                  , 1);

            Console.WriteLine($"Today is:      {today:MMM d, yyyy}");
            Console.WriteLine($"Tomorrow is:   {tomorrow:yyyy/MM/dd}");
            Console.WriteLine($"Yesterday was: {yesterday}");
            Console.WriteLine($"Yesterday was: {yesterdayDateOnly}");
            Console.WriteLine($"Yesterday was: {yesterdayTimeOnly}\n");

            Console.WriteLine($"BofM was:      {beginningOfMonth.ToShortDateString()}");
            Console.WriteLine($"EofM is:       {endOfMonth.ToString()}");
            Console.WriteLine($"BofY was:      {beginningOfYear.ToLongDateString()}\n");

            Console.WriteLine($"Min DateTime Value: {DateTime.MinValue}");
            Console.WriteLine($"Max DateTime Value: {DateTime.MaxValue}\n");

            Console.WriteLine($"Ticks on Jan 1, 0001: {new DateTime(1, 1, 1).Ticks:N0}");
            Console.WriteLine($"Ticks on Jan 2, 0001: {new DateTime(1, 1, 2).Ticks:N0}\n");

            Console.WriteLine($"Ticks since Jan 1, 0001: {DateTime.Now.Ticks:N0}\n");
        }
    }
}
