using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Default Constructors";

            PersonVersion1 person1 = new PersonVersion1
            {
                FirstName = "Jerry",
                LastName = "Seinfeld",
                Email = "jerry@seinfeld.com",
                Age = 64
            };

            PersonVersion2 person2 = new PersonVersion2
            {
                FirstName = "George",
                LastName = "Costanza",
                Email = "george@costanza.com",
                Age = 58
            };

            PersonVersion3 person3 = new PersonVersion3
            {
                FirstName = "Elaine",
                LastName = "Benes",
                Email = "elaine@benes.com",
                Age = 57
            };

            PersonVersion4 person4 = new PersonVersion4
            {
                FirstName = "Cosmo",
                LastName = "Kramer",
                Email = "cosmo@kramer.com",
                Age = 69
            };

            Console.WriteLine(person1);
            Console.WriteLine(person2);
            Console.WriteLine(person3);
            Console.WriteLine(person4);
        }
    }
}
