using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConstructor
{
    class Car
    {
        string CarModel;
        int CarYear;
        public Car(string model,int year)//Parameterized Constructor
        {
            CarModel= model;
            CarYear= year;  
        }
        public Car(int year, string model )//Constructor overloaded
        {
            CarModel = model;
            CarYear = year;
        }
        //public Program()
        //{
        //    Console.WriteLine("Hello I am Constructor");
        //}
        static void Main(string[] args)
        {
            Car myCar = new Car(2022,"This is new Model Of Car");
            Console.WriteLine(myCar.CarModel);  
            Console.WriteLine(myCar.CarYear);
            Console.ReadLine();
           //Program program = new Program();?// User Difine Constructor
           // Console.ReadLine();
        }
    }
}
