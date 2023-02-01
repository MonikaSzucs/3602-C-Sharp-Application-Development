using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Queue Demo";

            StringQueue queue = new StringQueue();

            queue.Enqueue("One");
            queue.Enqueue("Two");
            queue.Enqueue("Three");

            while (queue.Count > 0) // always check for content
            {                       // prior to calling Dequeue
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
