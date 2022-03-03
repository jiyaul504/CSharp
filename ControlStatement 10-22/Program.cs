using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 30;
            if(number == 10)
            {
                Console.WriteLine("Number is 10");
                Console.ReadLine();
            }
            else if(number == 20)
            {
                Console.WriteLine("Number Is 20");
                Console.ReadLine();
            }
            else if(number == 30)
            {
                Console.WriteLine("Number Is 30");
                Console.ReadLine(); 
            }
            else
            {
                Console.WriteLine("Invalid Number");
                Console.ReadLine();
            }
        }
    }
}
