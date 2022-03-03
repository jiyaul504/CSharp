using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class IMPLICIT
    {
        static void Main(string[] args)
        {
            byte b = 10;
            int i = b;// Here value converted into int and so
            long l = i;
            Console.WriteLine(i);// Display method to display the result
            Console.WriteLine(l); 
            Console.ReadLine ();    
        }
    }
}
