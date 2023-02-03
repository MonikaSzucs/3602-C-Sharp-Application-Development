using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "List Demo";

            PersonList people = DataGenerator.GetPeople();

            ConsolePrinter.ShowPeople(people);

            people.RemoveAt(1);

            ConsolePrinter.ShowPeople(people);

            Person person = people[0];

            people.Remove(person);

            ConsolePrinter.ShowPeople(people);
        }
    }
}
