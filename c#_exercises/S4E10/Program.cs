using System;

/*
Exercise 10 – Return
Update your exercise 7 functions to return values and remove the print statement from the function itself. 
Instead, the function will calculate and return the value only. 
Use the function inside a Console.WriteLine() to then print the result like this:
Console.WriteLine(Add(4,7));
The output should look like this:
“4 x 10 = 40” or “5 + 6 = 11”
*/

// STUDENT ID 20111218 | NAME: PUI LIM | DATE:5/9/2023

namespace MyApplicationS4E10
{
    class Program
    {
        // CREATE METHOD / FUNCTION 
        static int ReturnFunction(int x, int y)
        {
            // FUNCTION TO RETURN THE PRODUCT OF X & Y 
            return x * y;
        }

        // CALL THE FUNCTION 
        static void Main()

        {
            // DECLARE THE VARIABLES 
            int x = 4;
            int y = 10;
            // STORE THE RESULTS IN THE VARIABLE result 
            int result = ReturnFunction(x, y);

            // PRINT THE VALUES OF X x Y ALONG WITH THE RESULT 
            Console.WriteLine($"{x} x {y} = {result}");
        }
    }

}


