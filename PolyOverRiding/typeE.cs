using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.PolyOverRiding
{
    internal class typeE:typeD
    {
        public int E { get; set; }

        public typeE(int a,int b,int c,int d,int e):base(a,b,c,d)
        {
            E = e;
        }
        public new void MyFun01()
        {
            Console.WriteLine("I am Derived [Grand Child of grand Child]");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"TypeD : A ={A} , B = {B},C = {C} ,D = {D}");
        }
    }
}
