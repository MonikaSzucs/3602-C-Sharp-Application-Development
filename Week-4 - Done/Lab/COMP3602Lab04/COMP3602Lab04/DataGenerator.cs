// Monika Szucs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab04
{
    class DataGenerator
    {
        public static PersonList GetPeople()
        {
            PersonList people = new PersonList(10)
            {
                new Person { FirstName = "Moe", LastName = "Howard", Age = 63 },
                new Person { FirstName = "Curley", LastName = "Howard", Age = 58 },
                new Person { FirstName = "Larry", LastName = "Fine", Age = 61 },
                new Person { FirstName = "Larry", LastName = "Sanders", Age = 57 },
                new Person { FirstName = "Hank", LastName = "Kingsley", Age = 61 },
                new Person { FirstName = "Cosmo", LastName = "Kramer", Age = 55 },
                new Person { FirstName = "Elaine", LastName = "Benes", Age = 52 },
                new Person { FirstName = "Jerry", LastName = "Seinfeld", Age = 55 },
                new Person { FirstName = "George", LastName = "Costanza", Age = 53 },
                new Person { FirstName = "Art", LastName = "Vandelay", Age = 48 }
            };

            return people;
        }
    }
}
