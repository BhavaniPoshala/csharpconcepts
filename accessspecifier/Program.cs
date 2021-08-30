using System;

namespace ConsoleApp7
{
    class Program
    {
        protected string name = "bhavani";
    }
    class subprgm : Program
    {
        static void Main(string[] args)
        {
            subprgm obj = new subprgm();
            Console.WriteLine(obj.name);
        }
    }
}

