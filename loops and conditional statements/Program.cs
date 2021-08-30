using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 21;

            ///* while loop execution */
            //while (a < 20)
            //{
            //    Console.WriteLine("value of a: {0}", a);
            //    a++;
            //}

            /* do loop execution */
            //do
            //{
            //    Console.WriteLine("value of a: {0}", a);
            //    a = a + 1;
            //}
            //while (a < 20);
            //for (int a = 10; a < 20; a = a + 1)
            //{
            //    Console.WriteLine("value of a: {0}", a);
            //}
            //int i, j;

            //for (i = 2; i < 100; i++)
            //{
            //    for (j = 2; j <= (i / j); j++)
            //        if ((i % j) == 0) break; // if factor found, not prime
            //    if (j > (i / j)) Console.WriteLine("{0} is prime", i);
            //}
            //int a = 21;

            /* check the boolean condition using if statement */
            //if (a < 20)
            //{
            //    /* if condition is true then print the following */
            //    Console.WriteLine("a is less than 20");
            //}
            //Console.WriteLine("value of a is : {0}", a);
            //Console.ReadLine();
            //if (a < 20)
            //{
            //    /* if condition is true then print the following */
            //    Console.WriteLine("a is less than 20");
            //}
            //else
            //{
            //    /* if condition is false then print the following */
            //    Console.WriteLine("a is not less than 20");
            //}
            //Console.WriteLine("value of a is : {0}", a);
            //Console.ReadLine();

            //}
            //    int a = 100;

            //    /* check the boolean condition */
            //    if (a == 10)
            //    {
            //        /* if condition is true then print the following */
            //        Console.WriteLine("Value of a is 10");
            //    }
            //    else if (a == 20)
            //    {
            //        /* if else if condition is true */
            //        Console.WriteLine("Value of a is 20");
            //    }
            //    else if (a == 30)
            //    {
            //        /* if else if condition is true  */
            //        Console.WriteLine("Value of a is 30");
            //    }
            //    else
            //    {
            //        /* if none of the conditions is true */
            //        Console.WriteLine("None of the values is matching");
            //    }
            //    Console.WriteLine("Exact value of a is: {0}", a);
            //    Console.ReadLine();
            //}
            //char grade = 'B';

            //switch (grade)
            //{
            //    case 'A':
            //        Console.WriteLine("Excellent!");
            //        break;
            //    case 'B':
            //    case 'C':
            //        Console.WriteLine("Well done");
            //        break;
            //    case 'D':
            //        Console.WriteLine("You passed");
            //        break;
            //    case 'F':
            //        Console.WriteLine("Better try again");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid grade");
            //        break;
            //}
            //Console.WriteLine("Your grade is  {0}", grade);
            //Console.ReadLine();
            int a = 100;
            int b = 200;

            switch (a)
            {
                case 100:
                    Console.WriteLine("This is part of outer switch ");

                    switch (b)
                    {
                        case 200:
                            Console.WriteLine("This is part of inner switch ");
                            break;
                    }
                    break;
            }
            Console.WriteLine("Exact value of a is : {0}", a);
            Console.WriteLine("Exact value of b is : {0}", b);
            Console.ReadLine();
        }
    }
}
