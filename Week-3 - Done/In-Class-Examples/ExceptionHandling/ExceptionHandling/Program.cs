using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exception Handling Demo";

            try
            {
                int age = Convert.ToInt32("10");
                //string path = args[0];
                Console.WriteLine("Next statement in Try Block");
            }

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Handling type IndexOutOfRange");
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Handling type FormatException");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Handling type Exception");
            }

            finally
            {
                Console.WriteLine("Finally Block executed");
            }

            Console.WriteLine("Next statement in program");
        }
    }
}
