using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.PolyOverRiding.Binding
{
    internal class Employee
    {
        public int id {  get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public Employee(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        
        public void GetEmployeeType()
        {
            Console.WriteLine("I am Employee");
        }
        public virtual void GetEmployeeData()
        {
            Console.WriteLine($"Employee : Id = {id}, Name= {name}, Age = {age}");
        }
    
    }
}

