using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Example
    {
        public static bool Check<T>(T a, T b)
        {
            bool c=a.Equals(b);
            return c;
        }
        //public static void ShowArray<T>(T[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.WriteLine(arr[i]);

        //    }
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
           
            
            Console.WriteLine(Example.Check(10,20));
            Console.WriteLine(Example.Check("Jiyaul","Jiyaul"));
             Console.WriteLine(Example.Check("Jiyaul","Jiyaul"));
            //int[] Number=new int[3];
            //Number[0]=1;    
            //Number[1]=2;
            //Number[2]=3;
            //string[] String=new string[3];
            //String[0] = "Jiyaul";
            //String[1] = "Krishna";
            //String[2] = "Atul";
            //double[] Double=new double[3];
            //Double[0] = 4.5;
            //Double[1] = 5.4;
            //Double[2] = 6.4;
            //Example.ShowArray(Number);
            //Example.ShowArray(String);
            //Example.ShowArray(Double);
            Console.ReadLine();
        }
    }
}
