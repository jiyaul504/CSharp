using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string j= "Jiyaul";
            string h = "Haque";
            string id = "700004";

            string jh = $"Mr.{j}{h}, id=700004";
            Console.WriteLine(jh);
            Console.ReadLine();
        }
    }
}
