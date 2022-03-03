using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Example<T>
    {
        T box;
        public T Box
        {
            set
            {
                this.box = value;
            }
            get
            {
                return this.box;
            }
        }
        //public Example(T b)
        //{
        //    this.box = b;
        //}
        //public T GetBox()
        //{
        //    return  this.box;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Example<string> example1 = new Example<string>();
            Example<int> example = new Example<int>();
            example.Box = 15;
            example1.Box = "Jiyaul";
            Console.WriteLine(example1.Box);
            Console.WriteLine(example.Box); 
            //Example<int> ex = new Example<int>(20);
            //Example<string> ex1 = new Example<string>("Jiyaul");
            //Console.WriteLine(ex.GetBox());
            //Console.WriteLine(ex1.GetBox());
            Console.ReadLine();
        }
    }
}
