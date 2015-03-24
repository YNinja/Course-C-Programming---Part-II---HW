/* Problem 4. Binary search

Write a program, that reads from the console an array of N integers 
and an integer K, sorts the array and using the method Array.BinSearch() 
finds the largest number in the array which is ≤ K.
*/

using System;
class BinarySearch
{
    static void Main(string[] args)
    {
        Console.Write("Write the length of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] myArray = new int[n];
        Console.WriteLine("Write the elements of the array, each on a separate line: ");
        for (int i = 0; i < n; i++)
        {
            myArray[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        Array.Sort(myArray);
        int index = Array.BinarySearch(myArray, k);
        int result = 0;
        if (index < 0)
        {
            index = ~index - 1;
        }
        if (index >= 0)
        {
            result = myArray[index];
        }
        Console.WriteLine("The largest number in the array which is <= K is: {0}", result);
    }
}