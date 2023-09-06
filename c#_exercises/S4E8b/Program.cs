using System;

/* 
Exercise 8b – Complex Info
Recreate the user information exercise (1 and 2) but this time create a function that takes those inputs as parameters. 
Call the function and pass different values.
Example output:
I am older than them.
The age difference is 5 Years.
They have a longer name than I do.*/

// STUDENT ID 20111218 | NAME: PUI LIM | DATE:29/8/2023

namespace MyApplicationS48b
{
    class Program
    {
        // CREATE FUNCTION WITH THE BELOW IF STATEMENTS 
        static void UserDetailsComparison()

        {
            // YOUR NAME INPUT 
            Console.WriteLine("Hey Friend! my name is: ");
            string? YourName = Console.ReadLine();

            // THEIR NAME INPUT 
            Console.WriteLine("What is your name? ");
            string TheirName = Console.ReadLine();

            // COUNT LENGTH 
            int YourNameLength = YourName.Length;
            int TheirNameLength = TheirName.Length;

            // IF / ELSE STATEMENT TO COMPARE LENGTH OF NAMES 
            if (YourNameLength == TheirNameLength)
                Console.WriteLine("Our names are the same length!");
            else if (YourNameLength >= TheirNameLength)
            {
                Console.WriteLine("My name is longer than yours!");
            }
            else
            {
                Console.WriteLine("Your have a longer name!");
            }

            // IF / ELSE STATEMENT TO COMPARE AGE  
            Console.WriteLine("Hi " + TheirName + " , How old are you? ");
            int TheirAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("I am: ");
            int YourAge = Convert.ToInt32(Console.ReadLine());
            if (TheirAge == YourAge)
                Console.WriteLine("We are the same age! ");
            else if (TheirAge >= YourAge)
            {
                Console.WriteLine("Wow you are older!");
            }
            else
            {
                Console.WriteLine("Ah I am older!");
            }
        }

        // CALL FUNCTION 
        static void Main()
        {
            UserDetailsComparison();
        }
    }
}












