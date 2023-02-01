using System;
using System.Collections;
// using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ArrayList Demo";

            ArrayList students = new ArrayList();

            Student tempStudent;

            students.Add(new Student { Id = "A00123456", FirstName = "Cosmo", LastName = "Kramer" });
            students.Add(new Student { Id = "A00123412", FirstName = "Charlie", LastName = "Harper" });

            //Console.WriteLine(students[0].); // will not work without casting

            tempStudent = (Student)students[0];

            Console.WriteLine(tempStudent.Id);

            students.Add(new Cat { Name = "Felix" });  // this is not desirable (but permitted)

            foreach (object item in students)
            {
                Console.WriteLine(item);
            }
        }
    }
}
