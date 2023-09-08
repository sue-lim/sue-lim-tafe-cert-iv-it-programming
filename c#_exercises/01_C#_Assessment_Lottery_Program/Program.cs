using System;

namespace Assignment01
{
    class LotteryProgram
    {
        static void Main()
        {
            bool playAgain = true; // Flag to control whether to play the game again
            while (playAgain)
            {
                // ARRAYS TO STORE USERNUMBER INPUTS & RANDOMNUMGENERATOR 
                int[] UserNumArray = new int[5];
                int[] RandomNumArray = new int[5];

                // LOTTO TITLE BOX & FORMATS
                Console.WriteLine("====================================");
                Console.WriteLine("===   Welcome to the Lotto Box   ===");
                Console.WriteLine("==================================== \n");

                // CALL PrintNumberBoxFunction TO SHOW 1-45 IN A BOX WITH FORMATTING 
                PrintNumberBox();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("====================================");

                // USER INSTRUCTIONS 
                Console.WriteLine("To Enter the Lottery...");
                Console.WriteLine("Enter your 5 numbers between 1 - 45:\n");


                // CALL USERINPUT FUNCTION TO GET USER INPUT
                UserInput(UserNumArray);
                Console.WriteLine("\n");

                // Check for duplicates in user input array
                /*if (LocateDuplicatesInArray(UserNumArray))
                {
                    Console.WriteLine("\nDuplicate numbers found in your input.");
                    // Handle duplicates as needed
                    Console.WriteLine("Enter your 5 numbers between 1 - 45 again:\n");
                    UserInput(UserNumArray); // Ask for input again
                    Console.WriteLine("\n");
                }*/

                Console.WriteLine("====================================");
                Console.WriteLine("===            To Win            ===");
                Console.WriteLine("===    All numbers must match!   ===");
                Console.WriteLine("====================================");
                
                Console.WriteLine("====================================");
                Console.WriteLine("===      *** HIT ENTER ***       ===");
                Console.WriteLine("===     FOR THE LOTTERY DRAW     ===");
                Console.WriteLine("===          GOODLUCK!           ===");
                Console.WriteLine("====================================");
                Thread.Sleep(2000); // PAUSE / STOP AND USER TO HIT ENTER TO CONTINUE
                Console.ReadLine(); // Wait for Enter key press to exit

                Console.WriteLine("------------------------------------");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("---       Winning Numbers!       ---");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("\n");
                RandomGenerator(RandomNumArray); // CALL RandomNumberGenerator
                Console.WriteLine("\n");
                Console.WriteLine("====================================");
                Console.WriteLine("====================================");

                // CALL FUNCTION AreEqual 
                if (AreEqual(UserNumArray, RandomNumArray))

                    Console.WriteLine("------------------------------------\n");

                else
                    Console.WriteLine("------------------------------------\n");
                Console.WriteLine("         Sorry not a winner! \n     ");
                Console.WriteLine("------------------------------------");

                Console.WriteLine("====================================");
                Console.WriteLine("=Thank you for playing the lottery!=");
                Console.WriteLine("====================================\n");


                // ASK THE USER IS THEY WANT TO PLAY AGAIN 
                Console.WriteLine("\nDo you want to play again? (yes/no):");

                // CONVERT YES TO LOWER CASE FOR CASE INSENSITIVITY 
                string playAgainResponse = Console.ReadLine().ToLower();
                if (playAgainResponse != "yes\n")
                {
                    playAgain = false; // EXIT THE LOOP IF THE USER DOESN'T WANT TO LAUNCH AGAIN 
                }
                Console.WriteLine("====================================");
                Console.WriteLine("=Thank you for playing the lottery!=");
                Console.WriteLine("====================================\n");
            }
        }
        // LOTTO NUMBER BOX VISUAL 
        static void PrintNumberBox()
        {
            int numRows = 5; // DEFINE THE NUMBER OF ROWS IN THE BOX.
            int numCols = 9; // DEFINE THE NUMBER OF COLUMNS IN THE BOX.

            int currentValue = 1; // INITIALIZE THE STARTING VALUE FOR THE NUMBERS TO BE DISPLAYED.

            // LOOP THROUGH EACH ROW OF THE BOX.
            for (int i = 1; i <= numRows; i++)
            {
                // LOOP THROUGH EACH COLUMN WITHIN THE CURRENT ROW.
                for (int j = 1; j <= numCols; j++)
                {
                    // CHECK IF WE'VE REACHED THE END OF THE NUMBERS (1 TO 45).
                    if (currentValue > 45)
                    {
                        break; // EXIT THE INNER LOOP IF WE'VE DISPLAYED ALL NUMBERS.
                    }
                    // PRINT THE CURRENT NUMBER WITH PROPER FORMATTING.
                    Console.Write($"{currentValue,3} "); // THE {CURRENTVALUE,3} FORMAT ALIGNS THE NUMBER WITH A WIDTH OF 3 CHARACTERS.
                    currentValue++; // INCREMENT THE CURRENT VALUE FOR THE NEXT NUMBER.
                }
                Console.WriteLine(); // MOVE TO THE NEXT ROW BY ADDING A LINE BREAK.
            }
        }

        // USER INPUT FOR LOTTO NUMBERS 
        static void UserInput(int[] array)
        {
            // INITIALIZE AN ARRAY TO STORE USER-ENTERED NUMBERS 
            int[] UserNumArray = new int[5]; // CREATE AN ARRAY WITH SPACE FOR 5 NUMBERS
            int i; // DECLARE AN INTEGER VARIABLE TO CONTROL THE LOOP ITERATION

            // FOR LOOP TO RECEIVE USER INPUT FOR 5 NUMBERS
            for (i = 0; i < 5; i++)
            {
                // DISPLAY A PROMPT ON THE CONSOLE TO INSTRUCT THE USER AND TRACK THE CURRENT INPUT NUMBER
                Console.Write("{0}. Enter number : ", i + 1);

                // DECLARE AN INTEGER VARIABLE TO STORE THE USER'S INPUT
                int IntUserNum;

                // TRY TO PARSE THE USER'S INPUT AS AN INTEGER AND CHECK WHETHER THE PARSING SUCCEEDS
                bool UserInput = int.TryParse(Console.ReadLine(), out IntUserNum);

                // IF PARSING SUCCEEDS (TRUE), CHECK IF THE ENTERED NUMBER IS WITHIN THE RANGE OF 1 TO 45 INCLUSIVE
                if (UserInput && IntUserNum >= 1 && IntUserNum <= 45)
                {
                    // CHECK IF THE ENTERED NUMBER IS ALREADY IN THE UserNumArray
                    if (Array.IndexOf(UserNumArray, IntUserNum) != -1)
                    {
                        Console.WriteLine("\n*** Number {0} has already been entered.\n*** Please enter a unique number.\n", IntUserNum);
                        i--; // DECREMENT TO RE-ENTER A VALID NUMBER
                    }
                    else
                    {
                        UserNumArray[i] = IntUserNum; // ELSE ADD THE NUMBER TO THE ARRAY
                    }
                }
                else
                {
                    // ELSE IF NUMBER ISNT BETWEEN 1-45 MESSAGE TO REENTER AND DECREMENT 
                    Console.WriteLine("\n*** Please Enter a valid number between 1 and 45 ***\n");
                    i--; // DECREMENT TO RE-ENTER A VALID NUMBER
                }
            }
            // DISPLAY A MESSAGE INDICATING THAT THE USER'S TICKET NUMBERS ARE BEING SHOWN
            Console.WriteLine("\n************************************");
            Console.WriteLine("***      Your Ticket Numbers     ***");
            Console.WriteLine("************************************\n");

            // DISPLAY THE USER'S ENTERED NUMBERS ON THE CONSOLE
            for (i = 0; i < 5; i++)
            {
                Console.Write("   {0}  ", UserNumArray[i]); // PRINT EACH USER NUMBER
            }
        }

        // FUNCTION TO GENERATE RANDOM LOTTO NUMBERS
        static void RandomGenerator(int[] array)
        {
            int[] RandomNumArray = new int[5]; // CREATE AN ARRAY TO STORE RANDOMLY GENERATED NUMBERS
            int lowestValue = 1; // DEFINE THE LOWEST VALUE FOR RANDOM NUMBER GENERATION
            int highestValue = 45; // DEFINE THE HIGHEST VALUE FOR RANDOM NUMBER GENERATION

            // CREATE AN INSTANCE OF THE BUILT-IN RANDOM NUMBER GENERATOR
            Random rnd = new();

            for (int j = 0; j < 5; j++)
            {
                // GENERATE A RANDOM NUMBER BETWEEN THE lowestValue AND highestValue (INCLUSIVE)
                RandomNumArray[j] = rnd.Next(lowestValue, highestValue);

                // DISPLAY THE GENERATED RANDOM NUMBER ON THE CONSOLE
                Console.Write("   {0}  ", RandomNumArray[j], "\n");
            }
        }

        // FUNCTION TO COMPARE TWO ARRAYS (USER INPUT & RANDOMLY GENERATED NUMBERS) TO CHECK IF THEY MATCH FOR A WIN
        static bool AreEqual(int[] array1, int[] array2)
        {
            // IF THE LENGTHS OF THE TWO ARRAYS ARE NOT EQUAL, IT MEANS THE ARRAYS ARE DIFFERENT, SO RETURN FALSE
            if (array1 != array2)
                return false;

            // SORT BOTH ARRAYS IN ASCENDING ORDER
            Array.Sort(array1);
            Array.Sort(array2);

            // TRAVERSE BOTH ARRAYS AND COMPARE THEIR ELEMENTS
            for (int i = 0; i < array1.Length; i++)
            {
                // IF ANY ELEMENTS IN THE ARRAYS ARE NOT EQUAL, RETURN FALSE
                if (array1 != array2)
                    return false;
            }
            // IF ALL ELEMENTS ARE EQUAL, RETURN TRUE, INDICATING A WIN
            return true;
        }

        // *** FUNCTION NOT USED 
        // FUNCTION TO IDENTIFY DUPLICATE NUMBERS IN AN ARRAY
        // THIS FUNCTION DETECTS NUMBERS THAT ARE REPEATED IN THE ARRAY.
        static bool LocateDuplicatesInArray(int[] array)
        {
            // SORT THE ARRAY IN NUMERICAL ORDER TO SIMPLIFY DETECTION OF DUPLICATE NUMBERS
            Array.Sort(array);

            // LOOP THROUGH THE SORTED ARRAY, STARTING FROM THE SECOND NUMBER
            // THIS APPROACH IS USED BECAUSE EACH NUMBER IS COMPARED TO THE PREVIOUS ONE
            for (int i = 1; i < array.Length; i++)
            {
                // WHEN THE CURRENT NUMBER MATCHES THE PREVIOUS ONE,
                // IT INDICATES THE PRESENCE OF A DUPLICATE, AND THE FUNCTION RETURNS TRUE.
                // OBSERVING TWO CONSECUTIVE EQUAL NUMBERS INDICATES DUPLICATES.
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


