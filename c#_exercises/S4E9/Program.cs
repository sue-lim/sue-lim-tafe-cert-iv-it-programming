using System;

/*  Exercise 9 – String check for int 
 *  Create a function that takes two parameters, one that is a string, and the other is an int. 
 *  *** Check if the string contains the value of the int anywhere in it. 
 *  Note: There are a few ways to achieve this exercise. One uses string contains, the other can be to loop and check each character. 
 *  What are the drawbacks of each? */

// STUDENT ID 20111218 | NAME: PUI LIM | DATE: 5/9/2023 

// FIRST ATTEMPT REFERENCE TO: https://codelikeadev.com/blog/check-if-string-is-number-csharp


namespace MyApplicationS4E9
{ 
    class Program {
        static void Main()
        {
            // DISPLAY IN CONSOLE FOR AN INPUT
            Console.WriteLine("Enter an number: ");

            // STORES INPUT AS STRING AND STORES AS STRYR 
            string? strYear = Console.ReadLine();

            // PARSE strYear AS AN INTEGER USING INT.PARSE WITH A BOOL 
            bool checkYear = int.TryParse(strYear, out int year);

            // IF THIS IS STRUE THEN VALID MSG BELOW, IF NOT ELSE MSG NOT VALID 
            if (checkYear == true)
            {
                Console.WriteLine($"String is a valid number. The value is: {year}");
            }
            else
            {
                Console.WriteLine("String is not a valid number");
            }
        }
       
    }

}


// SECOND ATTEMPT REFERENCE TO CHAT GPT 

/*

namespace MyApplicationS4E9
{
    class Program
    {
        static bool ContainsInt(string input, int value)
        {
            // Convert the int to a string for comparison
            string intAsString = value.ToString();

            // Check if the input string contains the int as a substring
            return input.Contains(intAsString);
        }

        static void Main()
        {
            Console.WriteLine("Enter a string: ");
            string inputString = Console.ReadLine();

            Console.WriteLine("Enter an integer: ");
            if (int.TryParse(Console.ReadLine(), out int intValue))
            {
                if (ContainsInt(inputString, intValue))
                {
                    Console.WriteLine($"The string contains the integer value {intValue}.");
                }
                else
                {
                    Console.WriteLine($"The string does not contain the integer value {intValue}.");
                }
            }
            else
            {
                Console.WriteLine("Invalid integer input.");
            }
        }
    }
}

*/
