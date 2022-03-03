using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Student
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
        
    }
}
