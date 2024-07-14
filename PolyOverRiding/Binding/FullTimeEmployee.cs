using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.PolyOverRiding.Binding
{
    internal class FullTimeEmployee:Employee
    {
        public FullTimeEmployee(int id,string name,int age,decimal salaray):base(id,name,age) {
            salary= salaray;
        }
        public decimal salary { get; set; }
        public new void GetEmployeeType()
        {
            Console.WriteLine("I am fullTime Employee");
        }
        public override void GetEmployeeData()
        {
            Console.WriteLine($"FullTimeEmployee : Id = {id}, Name= {name}, Age = {age}, Salary : {salary}");
        }


    }
}
