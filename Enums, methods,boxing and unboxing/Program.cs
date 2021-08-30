using System;
namespace Enums
{
    class Program
    {
        //    enum Months
        //{
        //    January,    // 0
        //    February,   // 1
        //    March,      // 2
        //    April,      // 3
        //    May,        // 4
        //    June,       // 5
        //    July        // 6
        //}
        //private static void Main(string[] args)
        //{
        //    int myNum = (int)Months.April;
        //    Console.WriteLine(myNum);
        //}
        //static void Main()
        //{
        //    int i = 1;
        //    object o = i; // boxing  
        //    int j = (int)o; // unboxing  
        //}
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }
        static double PlusMethod(double x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }
    }
}
