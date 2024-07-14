using OOP3.PolyOverRiding;
using OOP3.PolyOverRiding.Binding;
using static System.Net.WebRequestMethods;

namespace OOP3
{
    internal class Program
    {

        #region Overloading

        public static int sum(int x,int y) {
            return x+ y;
        }
        public static int sum(int x, int y,int z)
        {
            return x + y+z;
        }
        public static double sum(double x, double y)
        {
            return x + y;
        }
        public static double sum(int x, double y)
        {
            return x + y;
        }
        public static double sum(double x,int  y)
        {
            return x + y;
        }

        #endregion

        #region
        public static void ProcessEmployee(Employee employee) {

            employee.GetEmployeeType();
            employee.GetEmployeeData();

        }
        //public static void ProcessEmployee(PartTimeEmployee employee)
        //{

        //    employee.GetEmployeeType();
        //    employee.GetEmployeeData();

        //}
        #endregion

        #region
        #endregion

        static void Main(string[] args)
        {
            #region Polymorphism[overloading]

            //int result=sum(1, 2);
            //Console.WriteLine(result);
            //int result1 = sum(1, 2,3);
            //Console.WriteLine(result1);
            //double dou = sum(1.1, 2.2);
            //Console.WriteLine(dou);
            //double dou1 = sum(1.1, 2);
            //Console.WriteLine(dou1);
            //double dou2 = sum( 2,1.1);
            //Console.WriteLine(dou2);

            #endregion

            #region Polymorphism[overRiding]

            //typeA a = new typeA(1);
            //a.A = 2;
            //a.MyFun01();
            //a.MyFun02();

            //typeB b = new typeB(1,2);
            //b.A = 3;
            //b.B= 4;
            //b.MyFun01();
            //b.MyFun02();

            #endregion

            #region Binding 

            //typeA refBase;
            //refBase=new typeB(1,2);
            //refBase.A = 10;
            //refBase.MyFun01(); //static or early binding
            //refBase.MyFun02(); //Dynamic or late binding

            #endregion

            #region not binding

            //typeB childref =(typeB) new typeA(1);

            //typeA TypeA = new typeA(1);
            //typeB TypeB = (typeB)TypeA;
            //Console.WriteLine(TypeB.A);
            //Console.WriteLine(TypeB.B);

            //typeA TypeA = new typeB(2,1);
            //typeB TypeB = (typeB)TypeA;
            //Console.WriteLine(TypeB.A);
            //Console.WriteLine(TypeB.B);



            #endregion

            #region Binding Ex01

            //FullTimeEmployee FTE = new FullTimeEmployee(10, "Aliaa", 30, 6000);
            //ProcessEmployee(FTE);

            //PartTimeEmployee PTE=new PartTimeEmployee(20,"Mona",25,20,2.5M);
            //ProcessEmployee(PTE);
            #endregion

            #region Binding Ex02

            //typeA TypeA = new typeC(1, 2, 3);
            //TypeA.A = 10;
            ////TypeA.B = 20;
            ////TypeA.C = 30;


            //TypeA.MyFun01();//Static 
            //TypeA.MyFun02();//Dynamic


            //typeB TypeB = new typeC(1, 2, 3);
            //TypeB.A = 10;
            //TypeB.B = 20;
            //TypeB.MyFun01();
            //TypeB.MyFun02();


            //typeA TypeA = new typeE(1, 2, 3, 4, 5);
            //typeB TypeB = new typeE(1, 2, 3, 4, 5);
            //typeC TypeC = new typeE(1, 2, 3, 4, 5);


            //TypeA.MyFun02();
            //TypeB.MyFun02();
            //TypeC.MyFun02();


            //typeD TypeD=new typeE(1,2,3,4,5);
            //TypeD.MyFun02();

            #endregion
        }
    }
}
