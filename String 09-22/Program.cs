using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your FirstName:");
            string firstname=Console.ReadLine();
            Console.Write("Ennter Your LastName:");
            string lastname = Console.ReadLine();
            Console.WriteLine("Hello!" +firstname+lastname);
            Console.ReadLine();
        }
    }
}
