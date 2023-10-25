using System;

// STUDENT ID 20111218 | NAME: PUI LIM | DATE:23/8/2023

namespace ClassMateComparisonApplication
{
    class ClassMateDetailsComparison
    {

        static void Main(string[] args)
        {
            // YOUR NAME INPUT 
            Console.WriteLine("Hey Friend! my name is: ");
            string YourName = Console.ReadLine();
            
            // THEIR NAME INPUT 
            Console.WriteLine("What is your name? ");
            string TheirName = Console.ReadLine();
            
            // COUNT LENGTH 
            int YourNameCount = YourName.Length;
            int TheirNameCount = TheirName.Length;

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
            else {
                Console.WriteLine("Ah I am older!");
                    }

        }
    }

}




