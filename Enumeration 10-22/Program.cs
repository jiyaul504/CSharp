using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnumeration
{
    public enum Days: byte
    {
        Monday,
        Tuesday=22,
        Wednesday=23,
        Thursday=24,
        Friday=25, 
        Saturday=26,
        
    }
    internal class Program
    {
        public static Days MeetingDate{get; set;} =Days.Monday;
        static void Main(string[] args)
        {
            //foreach (byte i in Enum.GetValues(typeof(Days)))
            //Console.WriteLine(i+":"+(Days)i);
            //foreach (string s in Enum.GetNames(typeof(Days)))
            //Console.WriteLine(s);
            //Console.ReadLine();
            Console.WriteLine(MeetingDate);
            MeetingDate = Days.Friday;
            Console.WriteLine(MeetingDate);
            Console.ReadLine();

        }
    }
}
