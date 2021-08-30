using Interface;
using System;

namespace Interface
{
    interface IOne
    {
        void ONE(); //Pure Abstract Method Signature  
    }
    interface ITwo
    {
        void TWO();
    }
    class ODDEVEN : IOne, ITwo //Must Implement all the abstract method, in Derived class.  
    {
        public void ONE() //Implementation of Abstract Method.  
        {
            Console.WriteLine("This is ONE");
        }
        public void TWO()
        {
            Console.WriteLine("This is TWO");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is ODD");
        IOne obj1 = new ODDEVEN();
        obj1.ONE();
        Console.WriteLine("\n\nThis is EVEN");
        ITwo obj2 = new ODDEVEN();
        obj2.TWO();
        Console.ReadLine();
    }
}

