using System;

/*
Exercise 12 – Student Grades
Create a console application that records user grades. 
There are an equal number of 10 students with one grade each. Create two arrays. 
One of strings that hold the student names. 
Create another that holds the grades. 
Each student and their grade should be in the same index (student array index 0 should match the grade for grade array index 0). 
Print out the grades for each student by looping through the arrays and accessing both to show class grades.
 */

// STUDENT ID 20111218 | NAME: PUI LIM | DATE: 6/9/2023 

namespace MyApplicationS5E12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] StudentGrades = { 20, 25, 30, 22, 18, 20, 25, 30, 22, 18 };
            string[] StudentNames = { "David", "John", "Rachel", "James", "Simon", "June", "Janet", "Sue", "Rachel" , "Sam"};
           
            // SINGLE LOOP TO ITERATE THROUGH STUDENTGRADES & STUDENTNAMES WITH THE SAME INDEX [i]
            for (int i = 0; i < StudentGrades.Length; i++)
            {
                
                {
                    // WITHIN LOOP, STRING INTERPOLATION TO PRINT STUDEN TNUMBER AND CORRESPONDING GRADES 
                    Console.WriteLine($"Student Name: {StudentNames[i]} | Grade: {StudentGrades[i]}");

                }
            }
        }
    }
}

// Solution ref: https://www.w3schools.com/cs/cs_arrays_loop.php
