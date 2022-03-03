using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class TestEmployee // Consuming Employee class from TestEmployee
    {
        public static void Main()
        {
            Employees emp = new Employees(101,"Jiyaul","Intern","Developer",40000,"Chennai");// passing value of six attributes
            Console.WriteLine("Eno:"+emp[0]);
            Console.WriteLine("Ename:"+emp[1]);  
            Console.WriteLine("Dname:"+emp[2]);
            Console.WriteLine("job:"+emp[3]);
            Console.WriteLine("Salary:"+emp[4]);
            Console.WriteLine("Location:"+emp[5]);

            emp[1] = "Raj";// Here  Previuos Values Changed  Through Indexing
            emp[4] = 35000.00;

            Console.WriteLine();
            Console.WriteLine("Eno:" + emp[0]);
            Console.WriteLine("Ename:" + emp[1]);
            Console.WriteLine("Dname:" + emp[2]);
            Console.WriteLine("job:" + emp[3]);
            Console.WriteLine("Salary:" + emp[4]);
            Console.WriteLine("Location:" + emp[5]);
            Console.ReadKey();
            
        }
    }
}
