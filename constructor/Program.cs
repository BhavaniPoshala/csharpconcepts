using System;
namespace Construtor
{
    class addition
    {
        int a, b;
        public addition(int x, int y)   //default contructor
        {
            a = x;
            b = y;
        }
        public static void Main()
        {
            addition obj = new addition(100, 120); //an object is created , constructor is called
            Console.WriteLine(obj.a);
            Console.WriteLine(obj.b);
            Console.Read();
        }
    }
}
