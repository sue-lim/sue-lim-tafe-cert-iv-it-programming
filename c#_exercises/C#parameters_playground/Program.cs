using System;

class GFG
{
    static public void scholar(string fname,
                               string lname,
                               int age = 20,
         string branch = "Computer science")

    {
        Console.WriteLine("First name: {0}", fname);
        Console.WriteLine("Last name: {0}", lname);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Branch: {0}", branch);
    }

    // Main Method
    static public void Main()
    {

        // Calling the scholar method
        scholar("Ankita", "Saini");
        scholar("Siya", "Joshi", 30);
        scholar("Rohan", "Joshi", 37,
           "Information Technology");
    }
}