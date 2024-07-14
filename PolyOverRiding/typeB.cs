using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.PolyOverRiding
{
    internal class typeB:typeA
    {
        public int B {  get; set; }
        public typeB(int a,int b):base(a)
        {
            B = b;
        }
        public new void MyFun01()
        {
            Console.WriteLine("I am Derived [Child]");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"TypeB : A = {A} , B={B}");
        }
    }
}
