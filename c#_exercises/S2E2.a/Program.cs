using System;

// STUDENT ID 20111218 | NAME: PUI LIM | DATE:23/8/2023

namespace ClassMateComparisonApplication
{
    class ClassMateDetailsComparison
    {

        static void Main(string[] args)
        {
            // NAME VARIABLES 
            string YourName = "Susan";
            string TheirName = "Jon";
            
            // COUNT LENGTH 
            int YourNameCount = YourName.Length;
            int TheirNameCount = TheirName.Length;

            // AGE VARIABLES 
            int TheirAge = 45;
            int YourAge = 50;
            int AgeDifference = (TheirAge - YourAge);

            // IF STATEMENT TO COMPARE WHO IS OLDER
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

            // AGE DIFFERENT PRINT OUT 
            Console.WriteLine("The age difference is " + AgeDifference);

            // IF / ELSE STATEMENT TO COMPARE LENGTH OF NAMES 
            if (YourNameCount == TheirNameCount)
                Console.WriteLine("Our names are the same length!");
            else if (YourNameCount >= TheirNameCount)
            {
                Console.WriteLine("My name is longer than yours!");
            }
            else
            {
                Console.WriteLine("Your have a longer name!");
            }








        }
    }

}




