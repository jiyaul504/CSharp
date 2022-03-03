using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyException
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            try
            {


                Console.WriteLine("Enter The First Number:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter The Second Number:");
                int y = int.Parse(Console.ReadLine());
                int z = x / y;
                Console.WriteLine("The Result is:" + z);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block has been executed");
            }
            
                Console.WriteLine("End Of The Program:");
                Console.ReadLine();

        }
    }
}
