using System;

// STUDENT ID 20111218 | NAME: PUI LIM | DATE:22/8/2023

namespace BioApplication
{
    class Bio
    {
        //member variables
        string? FirstName;
        string? LastName;
        int Age;
        bool InternationalStudent;
        int Pets;

        public void Acceptdetails()
        {
            FirstName = "Frodo";
            LastName = "Baggins";
            Age = 50;
            InternationalStudent = true;
            Pets = 2;

        }
        public void DisplayBio()
        {
            Console.WriteLine("First Name: " + FirstName);
            Console.WriteLine("Last Name: " + LastName);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("International Student? " + InternationalStudent);
            Console.WriteLine("I have " + Pets + " pets.");

        }
    }
    class ExecuteBio
    {
        static void Main(string[] args)
        {
            Bio bio = new();
            bio.Acceptdetails();
            bio.DisplayBio();
            Console.ReadLine();
        }
    }
}