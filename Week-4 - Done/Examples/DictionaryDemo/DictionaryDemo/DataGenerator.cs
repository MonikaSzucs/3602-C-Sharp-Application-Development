using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class DataGenerator
    {
        public static PersonDictionary GetPeople()
        {
            PersonDictionary people = new PersonDictionary();

            people.Add("JS", new Person { FirstName = "Jerry", LastName = "Seinfeld" });
            people.Add("GC", new Person { FirstName = "George", LastName = "Costanza" });
            people.Add("EB", new Person { FirstName = "Elaine", LastName = "Benes" });
            people.Add("CK", new Person { FirstName = "Cosmo", LastName = "Kramer" });

            return people;
        }
    }
}
