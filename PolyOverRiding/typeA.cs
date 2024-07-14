using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.PolyOverRiding
{
    internal class typeA
    {
        public int A {  get; set; }
        
        public typeA(int a)
        {
            A = a;
        }
        public  void MyFun01()
        {
            Console.WriteLine("I am base [Parent]");
        }
        public virtual void MyFun02()
        {
            Console.WriteLine($"TypeA : A = {A}");
        }
    }
 }