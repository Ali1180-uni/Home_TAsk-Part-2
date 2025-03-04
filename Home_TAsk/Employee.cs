using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_TAsk
{
    internal class Employee
    {
        public string Name;
        public string Department;
        public int EmpID;
        public double Salery;

         public Employee()
        {
            Console.WriteLine("Please Enter the Name of Employee: ");
            Name = Console.ReadLine();
            Console.WriteLine("Please Enter the Department of Employee: ");
            Department = Console.ReadLine();
            Console.WriteLine("Please Enter the Employee ID: ");
            EmpID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the Salery of Employee: ");
            Salery = Convert.ToDouble(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine("The Name of Employee is: {0}", Name);
            Console.WriteLine("The Department of Employee is: {0}", Department);
            Console.WriteLine("The Employee ID is: {0}", EmpID);
            Console.WriteLine("The Salery of Employee is: {0}", Salery);
        }

        public void Increment(double per)
        {
            Salery += per;
            Console.WriteLine("Now The Increased Salery of Employee {0} is: {1}", Name, Salery);
        }
    }
}
