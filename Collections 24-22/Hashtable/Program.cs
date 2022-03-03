using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hashtable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht=new Hashtable();
            ht.Add("Empid", 111);
            ht.Add("Ename", "Panda");
            ht.Add("Job", "Software Developer");
            ht.Add("Salary", 450000);
            ht.Add("Email", "jiyaul@impiger.com");
            ht.Add("Mobile", 7033804859);
            foreach(object key in ht.Keys)
            Console.WriteLine(ht[key]);
            Console.ReadLine();

        }
    }
}
