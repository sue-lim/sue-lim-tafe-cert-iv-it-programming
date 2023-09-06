using System;

// STUDENT ID 20111218 | NAME: PUI LIM | DATE: 25/8/2023
public class TimeTableExercise
{
    public static void Main()
    {
        int i; 
        int num;

        Console.Write("Please enter a number from 1-12: ");
        num = Convert.ToInt32(Console.ReadLine());

        // FOR LOOP TO BEGIN AT 1
        // MAX 12 ITERATIONS 
        // i++ - OPERATOR THAT TAKES THE VALUE AND INCREMENTS IT BY 1
        for (i = 1; i <= 12; i++)
        {
            Console.Write("{0} x {1} = {2} \n", num, i, (num  * i));
        }
    }
}