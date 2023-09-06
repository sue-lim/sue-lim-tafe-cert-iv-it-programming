using System;


/*
 * Exercise 7 – Parameters
Create a mathematical function that takes two parameters that are numeric types and 
performs a basic arithmetic function on them and prints the result to the console.
Try addition and multiplication.
*/

// STUDENT ID 20111218 | NAME: PUI LIM | DATE:5/9/2023

namespace myApplicationS4E7
{
    class Program
    {
        // CREATE FUNCTION WITH INT PARAMETERS 
        static void ArithmeticFunction(int x, int y)
        {
            int NumAddition = x + y;
            int NumMultiplier = x * y;

            // PRINT TO SCREEN 
            Console.WriteLine($"{x} + {y}" + " = " + NumAddition);
            Console.WriteLine($"{x} x {y}" + " = " + NumMultiplier);
        }

        // CALLING FUNCTION WITH ARGUMENTS 
        static void Main()
        {
            ArithmeticFunction(5, 2);
        }
    }
}