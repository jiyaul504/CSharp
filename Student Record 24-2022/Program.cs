using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Details
{
    class Programs
    {
        public class Student
        {
            public string First { get; set; }
            public string Last { get; set; }
            public int ID { get; set; }
            public List<int> Marks;
            public ContactInfo GetContactInfo(Programs pg, int id)
            {
                ContactInfo allinfo =(from ci in pg.contactList where ci.ID == id select ci)
                    .FirstOrDefault();

                return allinfo;
            }

            public override string ToString()
            {
                return First + "" + Last + " :  " + ID;
            }
        }

        public class ContactInfo
        {
            public int ID { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public override string ToString() { return Email + "," + Phone; }
        }

        public class ScoreInfo
        {
            public double Average { get; set; }
            public int ID { get; set; }
        }
        List<Student> students = new List<Student>()
        {
             new Student {First="Jiyaul", Last="Haque", ID=1,
                          Marks= new List<int>() {97, 92, 81, 60}},
             new Student {First="Krishna", Last=".Singh", ID=2,
                          Marks= new List<int>() {75, 84, 91, 39}},
             new Student {First="Atul", Last="Gopal", ID=3,
                          Marks= new List<int>() {88, 94, 65, 91}},
             new Student {First="Irshad", Last="Ali", ID=4,
                          Marks= new List<int>() {97, 89, 85, 82}},
        };
        List<ContactInfo> contactList = new List<ContactInfo>()
        {
            new ContactInfo {ID=111, Email="jiyaul@impiger.com", Phone="7033804859"},
            new ContactInfo {ID=112, Email="krishna@impiger.com", Phone="9695468101"},
            new ContactInfo {ID=113, Email="atul@impiger.com", Phone="7869697568"},
            new ContactInfo {ID=114, Email="irshad@impiger.com", Phone="9870098761"}
        };


        static void Main(string[] args)
        {
            Programs pg = new Programs();

            IEnumerable<Student> studentQuery1 =from student in pg.students where student.ID > 1 select student;

            
            Console.WriteLine("Name    : ID");
            
            foreach (Student s in studentQuery1)
            {
                Console.WriteLine(s.ToString());
            }
            Console.ReadLine();
        }
    }
}
