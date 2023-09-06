using System;
/*
Exercise 8a – Simple Name
Update the welcome message function from exercise 6 to include a parameter that allows you to pass the name of the user into it and print that along with the function.

********************************
Welcome <Your Name>, to My Application!
*********************************/

// STUDENT ID 20111218 | NAME: PUI LIM | DATE: 29/8/2023

namespace MyApplicationS4E8a
{
    class Program
    {
        // CREATE METHOD 
        static void WelcomeMessage()

        {
            // CREATE USER INPUT WRITE LINE TO ASK FOR THE NAME AND THEN STORE INTO VARIABLE "USERNAME"
            Console.WriteLine("Enter your name: ");
            string? userName = Console.ReadLine();

            // CREATE MESSAGE FOR THE METHOD WITH INSTRUCTIONS TO WRITELINE / PRINT 
            Console.WriteLine("********************************\r\nWelcome " + userName + ", to My Application!\r\n********************************");
        }

        // CALLING THE METHOD WITHIN THE MAIN IN STRING FORMAT & EXECUTING IT
        static void Main()
        {
            WelcomeMessage();
        }
    }
}