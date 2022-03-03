using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime datetime = DateTime.Now;
            Console.WriteLine("today date  is:"+datetime.ToString("dddd,dd,mmmm,yyyy"));
            Console.ReadLine();
            
        }
    }
}
