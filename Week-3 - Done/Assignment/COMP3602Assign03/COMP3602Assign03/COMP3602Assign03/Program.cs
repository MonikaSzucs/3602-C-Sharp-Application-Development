// Monika Szucs 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP3602Assignment 03 - Invoice Parser - A00878763";
            
            // Reading the file pathway in the argument and passing it over to the ReadInvoiceFile Class
            InvoiceDetails employees = ReadInvoiceFile.GetInvoices(args);
            ConsolePrinter.PrintInvoiceDate(employees);
        }
    }
}
