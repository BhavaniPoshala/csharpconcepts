using System;

namespace callby_value
{
    class Program
    {
        // User defined function  
        public void Show(int val)//for call by ref we will use ref keyword before int
        {
            val *= val; // Manipulating value  
            Console.WriteLine("Value inside the show function " + val);
            // No return statement  
        }
        // Main function, execution entry point of the program  
        static void Main(string[] args)
        {
            int val = 50;
            Program program = new Program(); // Creating Object  
            Console.WriteLine("Value before calling the function " + val);
            program.Show(val); // Calling Function by passing value //for call by reference we will use ref keyword before val           
            Console.WriteLine("Value after calling the function " + val);
        }
    }
}
