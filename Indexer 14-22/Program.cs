using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class Employees
    {
        int Eno;//Declaration  Attributes of  Employee
        Double Salary;
        string Ename, job, Dname, Location;
        public Employees(int Eno,string Ename,string job, string Dname, double Salary,string location)//  Parameter constructor
        {
            this.Eno = Eno;
            this.Ename = Ename;
            this.Dname = Dname;
            this.job = job;
            this.Salary = Salary;
            this.Location = location;
        }
        public object this[int index] //  Here Performed Indexing method
        {
            get // Get accessor for  accessing Value
            {
                if (index == 0)
                    return Eno;
                else if (index == 1)
                    return Ename;
                else if (index == 2)
                    return Dname;
                else if (index == 3)
                    return job;
                else if (index == 4)
                    return Salary;
                else if (index == 5)
                    return Location;
                return null;
            }
            set//seet accessor for set the Value
            {
                if (index == 0)
                        Eno = (int)value;
                    else if (index == 1)
                        Ename = (string)value;
                    else if (index == 2)
                        Dname = (string)value;
                    else if (index == 3)
                        job = (string)value;
                    else if (index == 4)
                        Salary = (double)value;
                    else if (index == 5)
                        Location = (String)value;
            }
        }
    }
}
