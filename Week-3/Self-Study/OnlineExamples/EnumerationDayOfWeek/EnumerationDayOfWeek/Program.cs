using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationDayOfWeek
{
    public enum DayOfWeek
    {
        Sunday
      , Monday
      , Tuesday
      , Wednesday
      , Thursday
      , Friday
      , Saturday
    }

    public enum DayOfWeekAsLong : long
    {
        Sunday
      , Monday
      , Tuesday
      , Wednesday
      , Thursday
      , Friday
      , Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Enumeration DayOfWeek Demo";

            DayOfWeek day = DayOfWeek.Tuesday;
            DayOfWeek nextDay = day + 1;

            Console.WriteLine($"Today is:    {day}");
            Console.WriteLine($"Tomorrow is: { nextDay}");

            string stringDay = "Thursday";
            if(Enum.TryParse(stringDay, out DayOfWeek parsedEnumDay))
            {
                Console.WriteLine($"The dat passed in as a string parsed to this enum: {parsedEnumDay}");
                if(parsedEnumDay == DayOfWeek.Sunday)
                {
                    Console.WriteLine("The day passed in as a string was Sunday!");
                } else
                {
                    Console.WriteLine("The day passed in as a string was NOT Sunday!");
                }
            }
        }
    }
}
