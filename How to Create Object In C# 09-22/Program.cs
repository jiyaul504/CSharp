using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassObject
{
    public class Calculator
    {
        int num1;
        int num2;
        int result; 
        void add()
        {
            result = num1 + num2;
            DisplayResult();
        }
        void Sub()
        {
            result=num1 - num2;
            DisplayResult();
        }
        void DisplayResult()
        {
            Console.WriteLine("Result is:"+result);
            Console.ReadLine ();
        }
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.num1 = 50;
            calculator.num2 = 10;
            calculator.add();
            calculator.Sub();    
        }
    }
}
