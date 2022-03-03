using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue ts = new Queue();
            ts.Enqueue("Krishna");
            ts.Enqueue(22);
            ts.Enqueue("Engineer");
            ts.Enqueue(40000.00);
            ts.Enqueue(true);
            Console.WriteLine(ts.Count);
            while (ts.Count > 0)
            {
                Console.WriteLine(ts.Dequeue());
            }
            //foreach (object item in ts)
            //{
            //    Console.WriteLine(item);
            //}
            //ts.Dequeue();
            //Console.WriteLine("----");
            //foreach (object item in ts)
            //{
            //    Console.WriteLine(item);
            //}
            Console.ReadLine();
        }
    }
}
