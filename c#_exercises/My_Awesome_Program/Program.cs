using System;

namespace my_Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Count the words of a sentence 
            // User Input 
            Console.WriteLine("Enter a sentence: ");

            string lineofwords = Console.ReadLine();

            int words = WordCount(lineofwords);

            Console.WriteLine("Number of words: " + words);

            // Press ENTER to exit
            Console.ReadLine();
        }

        // Function to count the words in a sentence
        static int WordCount(string sentence)
        {
            // Split the sentence into words using spaces and count them
            int words = sentence.Split(' ').Length;

            return words;
        }
    }
}
