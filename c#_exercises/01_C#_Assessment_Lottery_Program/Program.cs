using System;

namespace Assignment01
{
    class LotteryProgram
    {
        static void Main()
        {
            bool playAgain = true;
            while (playAgain)
            {
                // ARRAYS TO STORE USERNUMBER INPUTS & RANDOMNUMGENERATOR 
                int[] UserNumArray = new int[5];
                int[] RandomNumArray = new int[5];

                // LOTTO TITLE BOX & FORMATS
                Console.WriteLine("************************************");
                Console.WriteLine("***   Welcome to the Lotto Box   ***");
                Console.WriteLine("************************************ \n");

                // CALL PrintNumberBoxFunction TO SHOW 1-45 IN A BOX WITH FORMATTING 
                PrintNumberBox();
                // Console.WriteLine("\n");
                Console.WriteLine("************************************");
                Console.WriteLine("************************************");

                // USER INSTRUCTIONS 
                Console.WriteLine("\n");
                Console.WriteLine("To Enter the Lottery...");
                Console.WriteLine("Enter your 5 numbers between 1 - 45:\n");


                // CALL USERINPUT FUNCTION TO GET USER INPUT
                UserInput(UserNumArray);
                Console.WriteLine("\n");

                LocateDuplicatesInArray(UserNumArray);

                // Check for duplicates in user input array
                if (LocateDuplicatesInArray(UserNumArray))
                {
                    Console.WriteLine("\nDuplicate numbers found in your input.");
                    // Handle duplicates as needed
                    Console.WriteLine("Enter your 5 numbers between 1 - 45 again:\n");
                    UserInput(UserNumArray); // Ask for input again
                }

                Console.WriteLine("\n");
                Console.WriteLine("************************************");
                Console.WriteLine("***      Hit Enter to play!      ***");
                Console.WriteLine("************************************");
                Thread.Sleep(2000); // PAUSE / STOP AND USER TO HIT ENTER TO CONTINUE
                Console.ReadLine(); // Wait for Enter key press to exit

                Console.WriteLine("************************************");
                Console.WriteLine("***            To Win            ***");
                Console.WriteLine("***    All numbers must match    ***");
                Console.WriteLine("************************************");
                Console.WriteLine("\n");

                Console.WriteLine("************************************");
                Console.WriteLine("***       Winning Numbers!       ***");
                Console.WriteLine("************************************");
                Console.WriteLine("\n");
                RandomGenerator(RandomNumArray); // CALL RandomNumberGenerator

                Console.WriteLine("\n");

                if (AreEqual(UserNumArray, RandomNumArray))
                    Console.WriteLine("Yes ");
                else
                    Console.WriteLine("------------------------------------");
                Console.WriteLine("         Sorry not a winner!        ");
                Console.WriteLine("------------------------------------");



                Console.WriteLine("====================================");
                Console.WriteLine("=Thank you for playing the lottery!=");
                Console.WriteLine("====================================");
                // Console.ReadLine();

                // Ask the user if they want to play again
                Console.WriteLine("\nDo you want to play again? (yes/no):");
                string playAgainResponse = Console.ReadLine().ToLower();
                if (playAgainResponse != "yes")
                {
                    playAgain = false; // Exit the loop if the user doesn't want to play again
                }
                Console.WriteLine("====================================");
                Console.WriteLine("=Thank you for playing the lottery!=");
                Console.WriteLine("====================================");

            }
        }
        static void PrintNumberBox()
        {
            int numRows = 5; // Number of rows in the box
            int numCols = 9; // Number of columns in the box

            int currentValue = 1; // Starting value

            for (int i = 1; i <= numRows; i++)
            {
                for (int j = 1; j <= numCols; j++)
                {
                    // Check if we've reached the end of the numbers
                    if (currentValue > 45)
                    {
                        break;
                    }

                    // Print the current number with formatting
                    Console.Write($"{currentValue,3} ");
                    currentValue++;
                }
                Console.WriteLine(); // Move to the next row
            }

        }
        // USER INPUT FOR LOTTO NUMBERS 
        static void UserInput(int[] array)
        {
            // ARRAY TO STORE USER INPUT NUMBERS 
            int[] UserNumArray = new int[5];
            int i;

            // FORLOOP FOR THE INPUT 
            for (i = 0; i < 5; i++)

            {
                // DISPLAY ON CONSOLE FOR USER TO INPUT, INCREMENT TO THE NEXT INPUT WITH NUMBER OF EACH INPUT TO TRACK 
                Console.Write("{0}. Enter number : ", i + 1);

                // ADD / WRITE NUMBERS TO THE ARRAY UPDATING INDEX
                // DECLARING INTEGER VARIABLE 
                int IntUserNum;

                // PARSING THE INPUT AS AN INTEGER WITH A BOOL STATEMENT TO CHECK TRUE / FALSE
                bool UserInput = int.TryParse(Console.ReadLine(), out IntUserNum);

                // IF TRUE 
                // CHECK THAT NUMBER IS IS BETWEEN 1 - 45 IF SO ADD TO THE ARRAY
                if (UserInput && IntUserNum >= 1 && IntUserNum <= 45)
                {
                    // ADD TO THE userNumArray
                    UserNumArray[i] = IntUserNum;
                }
                else
                {
                    // IF FALSE, THROW ERROR MESSAGE AND DECREMENT TI RE-ENTER A VALID NUMBER. 
                    Console.WriteLine("*** Please Enter a valid number between 1 and 45 ***");
                    i--; // i-- IS TO DECREMENT 
                }
            }
            // CONSOLE MESSAGE TO LOOP THROUGH THE NUMBERS ENTERED 
            Console.WriteLine("************************************");
            Console.WriteLine("***      Your Ticket Numbers     ***");
            Console.WriteLine("************************************\n");

            for (i = 0; i < 5; i++)
            {
                Console.Write("   {0}  ", UserNumArray[i]);
            }
        }

        // LOTTO NUMBER GENERATOR
        static void RandomGenerator(int[] array)
        {
            int[] RandomNumArray = new int[5];
            int lowestValue = 1;
            int highestValue = 45;

            // BUILT IN RANDOM NUMBER GENERATOR 
            Random rnd = new();

            for (int j = 0; j < 5; j++)
            {
                RandomNumArray[j] = rnd.Next(lowestValue, highestValue);
                Console.Write("   {0}  ", RandomNumArray[j], "\n");
            }
        }

        // AREEQUAL USED TO CHECK THE 2 ARRAYS USERINPUT & RANDOMNUMBER TO CHECK IF THEY MATCH
        static bool AreEqual(int[] array1, int[] array2)
        {
            // IF LENGHTH OF ARRAY ARE NOT EQUAL MEANS ARRAYS ARE NOT EQUAL & IF STATEMENT IS INVALID
            if (array1 != array2)
                return false;

            // SORT ARRAYS 
            Array.Sort(array1);
            Array.Sort(array2);

            // Traverse both arrays and check if their elements
            // are equal
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1 != array2)
                    return false;
            }
            // If all elements are equal
            return true;
        }

        // LINEAR SEARCH FUNCTION TO IDENTIFY DUPLICATE NUMBERS IN AN ARRAY
        // THIS FUNCTION IDENTIFIES NUMBERS THAT ARE REPEATED IN THE ARRAY.
        static bool LocateDuplicatesInArray(int[] array)
        {
            // THE ARRAY IS SORTED IN NUMERICAL ORDER TO SIMPLIFY &...
            // ALLOWS FOR EASIER DETECTION OF DUPLICATE NUMBERS SINCE THEY'LL BE PLACED NEXT TO EACH OTHER.
            Array.Sort(array);

            // LOOP - ITERATES THROUGH THE SORTED LIST, BEGINNING FROM THE SECOND NUMBER.
            // THIS CHOICE IS MADE BECAUSE EACH NUMBER IS COMPARED TO THE ONE THAT PRECEDES IT.
            for (int i = 1; i < array.Length; i++)
            {
                // WHEN THE CURRENT NUMBER MATCHES THE PREVIOUS ONE,
                // IT INDICATES THE PRESENCE OF A DUPLICATE, AND THE FUNCTION RETURNS TRUE.
                // OBSERVING TWO CONSECUTIVE EQUAL NUMBERS SERVES AS THE TELLTALE SIGN.
                if (array[i] == array[i - 1])
                    return true;
            }

            // AFTER EXAMINING ALL NUMBERS AND FINDING NO DUPLICATES, THE FUNCTION RETURNS FALSE.
            // THIS SIGNALS THAT NO MATCHING NUMBERS WERE DISCOVERED.
            return false;

        }

    }
}





// SOLUTION REFERENCE:
// COMPILER ERROR CS0029 - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0029?f1url=%3FappId%3Droslyn%26k%3Dk(CS0029)
// INTEGER BOOL CHECK AND ERROR MSG - https://stackoverflow.com/questions/72400895/c-sharp-input-validation-for-strings-and-integers
// CONSOLE.WRITELINE VS CONSOLE.WRITE  - https://stackoverflow.com/questions/22845664/how-do-i-print-text-in-same-line
// BOOLEEN OPERATORS - https://education.launchcode.org/intro-to-programming-csharp/chapters/booleans-and-conditionals/logical-operators.html#:~:text=C%23%20allows%20us%20to%20create,the%20overall%20expression%20is%20False%20.
// RANDOM GENERATOR - https://www.tutorialsteacher.com/articles/generate-random-numbers-in-csharp
// LINEAR SEARCH - https://www.geeksforgeeks.org/check-if-two-arrays-are-equal-or-not/
// LINEAR SEARCH - https://www.youtube.com/watch?v=vYSdsBgFji8
// LOTTO NUMBER BOX - https://chat.openai.com/share/ac2eeb5f-d945-41af-99cc-e61ec15d6f11
// THREAD  SLEEP
// https://www.tutlane.com/tutorial/csharp/csharp-thread-sleep#:~:text=In%20c%23%2C%20the%20sleep%20method,property%20like%20as%20shown%20below.
// https://www.geeksforgeeks.org/suspending-the-current-thread-for-the-specified-amount-of-time-in-c-sharp/
// REPLAY THE PROGRAM - https://chat.openai.com/share/92241e6c-3217-450b-8a84-c39a23d718f3


