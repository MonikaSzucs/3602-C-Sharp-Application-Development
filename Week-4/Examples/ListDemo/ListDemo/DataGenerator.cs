using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class DataGenerator
    {
        public static PersonList GetPeople()
        {
            PersonList people = new PersonList();

            people.Add(new Person { FirstName = "Jerry", LastName = "Seinfeld" });
            people.Add(new Person { FirstName = "George", LastName = "Costanza" });
            people.Add(new Person { FirstName = "Elaine", LastName = "Benes" });
            people.Add(new Person { FirstName = "Cosmo", LastName = "Kramer" });

            // people.Add(new Widget { Id = 1001, Description = "Nice Widget" }); // No Go

            return people;
        }
    }
}
