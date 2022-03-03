using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            list.Add(70);
            for (int i = 0; i < list.Count; i++) 
            Console.Write(list[i]+" ");
            Console.WriteLine();
            list.Insert(3, 45);
            foreach (int i in list)
                Console.Write(i + " ");
            Console.WriteLine();
            list.Remove(3);
            foreach (int i in list)
                Console.Write(i + " ");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
