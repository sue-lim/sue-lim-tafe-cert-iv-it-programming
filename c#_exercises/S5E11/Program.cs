using System;

/*
 
Exercise 11 – Print Array Function
Create a function that prints all values in an array. 
The function will take one input parameter in the form of an int array. 
It will then use a for loop to iterate using the length of the array at the end point. 
Use Console.WriteLine() to print the values of every item in the array by accessing the array with square brackets “[]”.
 
 */

// STUDENT ID 20111218 | NAME: PUI LIM | DATE: 5/9/2023 

namespace myApplicationS5E11
{
    class Program
    {

        static void Main()
        {
            // CREATE A NEW ARRAY WITH THE SIZE OF 5
            int[] arrayFunction = new int[5];
            // CREATE VARIABLE FOR A LOOP COUNTER 
            int i;

            // CONSOLE DISPLAY MESSAGE FOR USER INPUT TO INPUT 5 NUMBERS 
            Console.WriteLine("Input 5 numbers into the array:\n");
            // FOR LOOP, ITERATES FROM 0 - 9 TIMES = 10 INPUTS 
            for (i = 0; i < 5; i++)
            {
                // PROMPT FOR USER TO INPUT THE NUMBERS WITH STARTING AT HUMAN READABLE 1
               Console.Write("Enter {0} : ", i + 1);
                // LINE READ AND STORED INTO ARRAYFUNCTION AT INDEX 
               arrayFunction[i] = Convert.ToInt32(Console.ReadLine());
            }
            

            Console.Write("\n Numbers in array are: ");
            // FOR LOOP TO ITERATE AND DISPLAY EACH ELEMENT 
            for (i = 0; i < 5; i++)
            {
                Console.Write("{0}  ", arrayFunction[i]);
            }
            Console.Write("\n");

        }

    }
        
 }

// SOLUTION REF - https://www.w3resource.com/csharp-exercises/array/csharp-array-exercise-1.php
