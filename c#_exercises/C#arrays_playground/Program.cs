using System;

namespace myApplicationS6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a test array
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            // Call the BubbleSort method to sort the array
            BubbleSort(arr);

            // Print the sorted array
            Console.WriteLine("Sorted array:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }

        // BubbleSort method to sort an integer array in ascending order
        static void BubbleSort(int[] array)
        {
            int temp = 0;
            bool swapped = false;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    // Compare adjacent elements and swap if they are in the wrong order
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }
                // If no swaps were made in this pass, the array is already sorted
                if (!swapped) break;
            }
        }
    }
}


