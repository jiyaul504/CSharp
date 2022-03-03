using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public class Studendt
    {
        private string firstname;
        private string lastname; 
        public string Firstname
        {
            set { firstname = value; }
            get { return firstname; }
        }
        public string Lastname
        {
            set { lastname = value; }
            get { return lastname; }
        }
        public string getCompleteName()
        {
            return firstname + " " + lastname;
        }
        static void Main(string[] args)
        {
            Student student=new Student();
            student.Firstname = "Jiyaul";
            student.Lastname = "Haque";
            Console.WriteLine("Your complete name is :"+student.getCompleteName());
            Console.ReadLine();
        }
    }
}
