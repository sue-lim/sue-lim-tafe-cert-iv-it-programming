namespace Assignment01
{
    class LotteryProgram
    {
        static void Main()
        {
            // Lotto Console Title
            Console.Title = "Welcome to the Lotto Box";
            Console.WriteLine("====================================");
            Console.WriteLine("===   Welcome to the Lotto Box   ===");
            Console.WriteLine("==================================== \n");

            // CALL PrintNumberBoxFunction TO SHOW 1-45 IN A BOX WITH FORMATTING 
            PrintNumberBox();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("====================================");

            PrintGameRules();

            string userName = GetUserName(); // Get the user's name

            Console.WriteLine($"\nWelcome, {userName}!\n"); // Display a welcome message

            bool playAgain = true; // Flag to control whether to play the game again

            // Set the range of numbers (min & max) 
            int minRange = 1;  // Minimum value for user input
            int maxRange = 45; // Maximum value for user input



            while (playAgain)
            {

                Console.WriteLine("Let's play!\n");


                int numberOfPicks = GetNumberOfPicks(); // Ask the user how many lottery numbers they want to pick.

                int[] userNumbers = new int[numberOfPicks]; // Create an array to store the user's numbers.
                int[] winningNumbers = GenerateWinningNumbers(minRange, maxRange); // Generate the winning numbers.

                GetUserNumbers(userNumbers, minRange, maxRange);  // Get the user's numbers.
                Console.WriteLine("------------------------------------");
                Console.Write("Here are your selected numbers: \n");
                DisplayNumbers(userNumbers);
                Console.WriteLine("------------------------------------");

                Console.WriteLine("\nHit Enter to see winning numbers");

                Console.ReadKey();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("\nWinning Numbers:");  
                DisplayNumbers(winningNumbers);

                SortArray(winningNumbers); // Sort the winning numbers

                int matches = CheckMatches(userNumbers, winningNumbers); // Check how many matches there are between user numbers and winning numbers.


                if (matches > 0)
                {
                    Console.WriteLine($"\nCongratulations, {userName}! You have {matches} matches!");
                    HighlightMatchingNumbers(userNumbers, winningNumbers);
                }
                else
                {
                    Console.WriteLine("\n------------------------------------\n");
                    Console.WriteLine($"Sorry, {userName}, not a winner! \nBetter luck next time!\n\nThank you for playing...\n");

                }

                playAgain = AskToPlayAgain();
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
        // Function to get the user's name
        static string GetUserName()
        {
            Console.Write("\nEnter your name: ");
            return Console.ReadLine();
        }

        static void PrintGameRules()
        {
            Console.WriteLine("\nWelcome to the Lotto Box\n\nTo play you must select a minimum of 5 numbers\nThese numbers must be between 1-45\n\nGoodluck & Happy Playing!");
        }

        // Function to get the number of picks from the user
        static int GetNumberOfPicks()
        {
            int numberOfPicks;

            while (true)
            {
                Console.Write("How many numbers would you like to play, minimum of 5 numbers must be picked (5-9)? \n");
                if (int.TryParse(Console.ReadLine(), out numberOfPicks) && numberOfPicks >= 5 && numberOfPicks <= 9)
                    return numberOfPicks;
                else
                    Console.WriteLine("Please try again. Please enter a number between 5 and 9.");
            }
        }

        // Function to get user-selected numbers
        static void GetUserNumbers(int[] userNumbers, int minRange, int maxRange)
        {
            for (int i = 0; i < userNumbers.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Enter number {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int num) && num >= minRange && num <= maxRange && !ContainsNumber(userNumbers, num))
                    {
                        userNumbers[i] = num;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Please try again. Please enter a unique number between {minRange} and {maxRange}.");
                    }
                }
            }
        }

        // Function to generate winning numbers
        static int[] GenerateWinningNumbers(int minRange, int maxRange) // range has been set in main 1-45
        {
            // This function generates random winning numbers within the specified range.
            // It uses a random number generator to select 5 unique numbers.
            Random random = new Random();
            int[] winningNumbers = new int[5];
            int[] numbers = new int[maxRange - minRange + 1];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + minRange;
            }

            for (int i = 0; i < 5; i++)
            {
                int index = random.Next(0, numbers.Length);
                winningNumbers[i] = numbers[index];
                RemoveNumber(ref numbers, index);
            }

            return winningNumbers;
        }

        // Function to display an array of numbers on the screen 
        static void DisplayNumbers(int[] numbers)
        {
            foreach (int num in numbers)
            {
                Console.Write($"{num:D2} ");
            }
            Console.WriteLine();
        }

        // Function to check how many matches there are between user numbers and winning numbers
        static int CheckMatches(int[] userNumbers, int[] winningNumbers)
        {
            int matches = 0;

            foreach (int num in userNumbers)
            {
                if (BinarySearch(winningNumbers, num) >= 0)
                {
                    matches++;
                }
            }
            return matches;
        }

        // Function to highlight matching numbers
        static void HighlightMatchingNumbers(int[] userNumbers, int[] winningNumbers)
        {
            Console.Write("Your Numbers: ");
            foreach (int num in userNumbers)
            {
                if (BinarySearch(winningNumbers, num) >= 0)
                {
                   
                    Console.Write($"{num:D2} ");
                }
                else
                {
                    Console.Write($"{num:D2} ");
                    Console.ResetColor();
                }
            }
            Console.WriteLine();
        }

        // Function to ask if the user wants to play again
        static bool AskToPlayAgain()
        {
            while (true)
            {
                Console.Write("Do you want to play again? (Y/N): ");
                string response = Console.ReadLine().ToLower();
                if (response == "y")
                    return true;
                else if (response == "n")
                    return false;
                else
                    Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            }
        }

        // Function to sort an array
        static void SortArray(int[] array)
        {
            Array.Sort(array);
        }

        // Function to check if an array contains a specific number using binary search
        static int BinarySearch(int[] array, int number)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (array[middle] == number)
                    return middle;

                if (array[middle] < number)
                    left = middle + 1;
                else
                    right = middle - 1;
            }

            return -1; // Number not found
        }

        // Function to remove a number from an array
        static void RemoveNumber(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (i != index)
                {
                    newArray[j++] = array[i];
                }
            }
            array = newArray;
        }

        // Function to check if an array contains a specific number
        static bool ContainsNumber(int[] array, int number)
        {
            foreach (int num in array)
            {
                if (num == number)
                {
                    return true;
                }
            }
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
// RANDOM GENERATOR + LOOPS - https://www.youtube.com/watch?v=9ozOSKCiO0I&list=PLPV2KyIb3jR4CtEelGPsmPzlvP7ISPYzR&index=5
// LINEAR SEARCH - https://www.geeksforgeeks.org/check-if-two-arrays-are-equal-or-not/
// LINEAR SEARCH - https://www.youtube.com/watch?v=vYSdsBgFji8
// LOTTO NUMBER BOX - https://chat.openai.com/share/ac2eeb5f-d945-41af-99cc-e61ec15d6f11
// THREAD  SLEEP
// https://www.tutlane.com/tutorial/csharp/csharp-thread-sleep#:~:text=In%20c%23%2C%20the%20sleep%20method,property%20like%20as%20shown%20below.
// https://www.geeksforgeeks.org/suspending-the-current-thread-for-the-specified-amount-of-time-in-c-sharp/
// REPLAY THE PROGRAM - https://chat.openai.com/share/92241e6c-3217-450b-8a84-c39a23d718f3
// RESIZE THE SCREEN - https://www.geeksforgeeks.org/console-setwindowsize-method-in-c-sharp/
// BINARY SEARCH - https://chat.openai.com/share/30f51733-1b58-449f-a25b-c4dbd9785ac1



