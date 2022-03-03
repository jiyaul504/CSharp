using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al=new ArrayList();
            Console.WriteLine(al.Capacity);
            al.Add(200);
            al.Add(300);
            al.Add(400);
            al.Add(500);
            Console.WriteLine(al.Capacity);
            al.Add(600);// Autoresize increment of array
            Console.WriteLine(al.Capacity);
            al.Insert(3, 450);
            Console.WriteLine(al.Capacity);
            foreach (object obj in al)
               
                Console.Write(obj+ " ");
            Console.ReadLine();
        }
    }
}
