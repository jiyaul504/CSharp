using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStruct
{
    internal struct Struct
    {
        int i;
        public Struct(int i)
        {
            this.i = i; 
        }
        public void Display()
        {
            Console.WriteLine("This is my struct:"+i);  
        }
        static void Main(string[] args)
        {

            Struct s;
            s.i = 10;
            s.Display();

            Struct s2 = new Struct();
            s2.Display();

            Struct s3= new Struct(30);
            s3.Display();
            Console.ReadLine();
        }
    }
}
