using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stack1
{
    class Program
    {

        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push("Jiyaul");
            st.Push(22);
            st.Push(5.5);
            st.Push(false);
            st.Push("atul");

            //Console.WriteLine(st.Contains("Atul"));
            foreach (object item in st)
            {
                Console.WriteLine(item);
            }
            st.Clear();
            Console.WriteLine("-------------");
            foreach (object item in st)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
