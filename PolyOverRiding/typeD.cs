using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.PolyOverRiding
{
    internal class typeD:typeC
    {
        public int D { get; set; }
        public typeD(int a,int b,int c,int d):base(a,b,c) {
            D = d;
        }
        public new void MyFun01() {
            Console.WriteLine("I am Derived [Child of grand Child]");
        }
        public new virtual void MyFun02()
        {
            Console.WriteLine($"TypeD : A ={A} , B = {B},C = {C} ,D = {D}");
        }
    }
}
