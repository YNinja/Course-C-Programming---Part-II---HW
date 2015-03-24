﻿/* Problem 9. Frequent number

Write a program that finds the most frequent number in an array.

Example:
input 	                                result
4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 	4 (5 times)
 */

using System;
using System.Collections.Generic;
using System.Linq;
class FrequentNumber
{
    static void Main(string[] args)
    {
        int[] myArray = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        foreach (int number in myArray)
        {
            if (!dictionary.ContainsKey(number))
            {
                dictionary.Add(number, 1);
            }
            else
            {
                dictionary[number]++;
            }
        }
        int bestValue = dictionary.FirstOrDefault(x => x.Value == dictionary.Values.Max()).Key;
        int occurences = dictionary.Values.Max();
        Console.WriteLine("The most frequent number in the array is {0}. It appeares {1} times in the array.", bestValue, occurences);
    }
}