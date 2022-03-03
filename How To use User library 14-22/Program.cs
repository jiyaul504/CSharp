using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string ch = string.Empty;

            do
            {
                Console.WriteLine("Enter First Value");
                var a = Console.ReadLine();

                Console.WriteLine("Enter Second Value");
                var b = Console.ReadLine();

                int result1 = 0;
                int result2 = 0;

                var x = int.TryParse(a, out result1);
                var y = int.TryParse(b, out result2);

                if (x == true && y == true)
                    UserLibrary.Utils.AddValues(result1, result2);
                else if (!x ^ y)
                    UserLibrary.Utils.AddValues(a, b);
                else
                    Console.WriteLine("Give right values");

                Console.WriteLine("Press any key to continue the program (q to discontinue)");
                ch = Console.ReadLine();

            } while (!ch.Equals("q"));
        }
    }
}

