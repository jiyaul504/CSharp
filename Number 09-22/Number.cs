using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number
{
    internal class SumofNumber
    {
        static void Main(string[] args)
        {

            Console.Write("Enter The FirstNumber:");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The SecondNumber:");
            int num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition of : {0}", num1 + num2);
            Console.ReadLine();
        }
        }
    }

