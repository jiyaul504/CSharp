using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace StringBuilder1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string str = "Hi";
            //str = str + "Jiyaul";
            //str = str + "How are u";
            //Console.WriteLine(str);
            //Console.ReadLine();
            string s = "";
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
           
            for(int i=1; i<=100000;i++)
            {
                s = s + i;
            }
            sw.Stop();
            StringBuilder sb = new StringBuilder();
            Stopwatch sw2 = Stopwatch.StartNew();
            sw2.Start();
            for (int i = 1; i <= 100000; i++)
            {
                sb.Append(i);
            }
            sw2.Stop();
            Console.WriteLine("Time Taken For String:"+sw.ElapsedMilliseconds);
            Console.WriteLine("Time Taken For StringBuilder:" + sw2.ElapsedMilliseconds);
            Console.ReadLine();
        }

    }
}
