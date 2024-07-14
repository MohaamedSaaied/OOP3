using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP3.PolyOverRiding.Binding
{
    internal class PartTimeEmployee:Employee
    {
        public int CountOfHours {  get; set; }
        public decimal HourRate { get; set; }
        public PartTimeEmployee(int id,string name , int age,int c,decimal r):base( id,name ,age) {
            this.CountOfHours = c;
            this.HourRate = r;
        }
        public new void GetEmployeeType()
        {
            Console.WriteLine("I am Part Time Employee");
        }
        public override void GetEmployeeData()
        {
            Console.WriteLine($"Part Time Employee : ID = {id}, Name = {name}, Age : {age}, Count of Hours = {CountOfHours}, Hour Rate = {HourRate}");
        }
    }
}
