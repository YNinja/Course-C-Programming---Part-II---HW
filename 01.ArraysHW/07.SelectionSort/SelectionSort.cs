/* Problem 7. Selection sort

Sorting an array means to arrange its elements in increasing order. 
Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, 
move it at the first position, find the smallest from the rest, 
move it at the second position, etc.
*/

using System;
    class SelectionSort
    {
        static void Main(string[] args)
        {
            int[] numbers = Sort(12, 3, 2, 5, -1, 7, 0, -14);
            PrintNumbers(numbers);
        }
        static int[] Sort(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int helper = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = helper;
                    }
                }
            } 
            return numbers;
        }
        static void PrintNumbers(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0}", numbers[i]);
                if (i < (numbers.Length - 1))
                {
                    Console.Write(", ");
                }
                Console.WriteLine();
            }
        }
    }