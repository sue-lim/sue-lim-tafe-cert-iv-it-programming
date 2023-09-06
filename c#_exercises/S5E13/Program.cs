using System;

/* 
Exercise 13 – Average Calculator
Using input, ask the user for 5 values and add them to an array. 
Iterate over the array and find the average of the values in the array. 
(Note: the average is found by adding all numbers together and dividing by the number of values there are).
*/

// STUDENT ID 20111218 | NAME: PUI LIM | DATE:6/9/2023 

namespace myApplicationS5E13
{
    class Program
    {
        static void Main(string[] args)
        {
            // CREATE AN ARRAY WITH THE SIZE OF 5 VALUES 
            int[] AverageFunctionArray = new int[5];
            // CREATE VARIABLE FOR LOOP COUNTER
            int i;

            // CONSOLE DISPLAY MESSAGE FOR USER INPUT TO INPUT 5 NUMBERS ON A NEW LINE (\N)
            Console.WriteLine("Input 5 numbers: \n");

            // FOR LOOP TO ITERATE & INPUT 5 TIMES 
            for (i = 0; i < 5; i++)
            {
                // DISPLAY ON CONSOLE "ENTER NUMBERS 
                Console.WriteLine("Enter number: ", i+1);
                // ADD NUMBERS ENTERED INTO THE ARRAY 
                AverageFunctionArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            // ENTER ON NEW LINE 
            Console.Write("\n");
            // CALCULATE THE SUM OF NUMBERS IN THE ARRAY
            Console.WriteLine("Sum of the Numbers: " + AverageFunctionArray.Sum());
            // CALCULATE THE AVERAGE OF NUMBERS IN THE ARRAY
            Console.WriteLine("Average of the Numbers: "+ AverageFunctionArray.Sum()/AverageFunctionArray.Length);

        }
    }
}

// SOLUTION REF: https://www.w3schools.com/cs/cs_arrays_sort.php