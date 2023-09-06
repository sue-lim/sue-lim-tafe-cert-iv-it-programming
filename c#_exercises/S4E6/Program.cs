using System;

/*
 * Exercise 6 – Declaring and using functions
Create a welcome message function called WelcomeMessage(). 
When called it will display the program’s welcome message. 
This will call several Console.WriteLine() functions to print an opening message. E.g.:

********************************
Welcome to My Application!
********************************
 */

// STUDENT ID 20111218 | NAME: PUI LIM | DATE: 29/8/2023

namespace MyApplicationsS4E6
{
    class Program
    {
     // CREATE METHOD 
        static void WelcomeMessage()
        {
            // CREATE MESSAGE FOR THE METHOD WITH INSTRUCTIONS TO WRITELINE / PRINT 
            Console.WriteLine("********************************\r\nWelcome to My Application!\r\n********************************");
        }

        // CALLING THE METHOD WITHIN THE MAIN IN STRING FORMAT & EXECUTING IT
        static void Main(string[] args)
        {
            WelcomeMessage();
        }
    }
}
