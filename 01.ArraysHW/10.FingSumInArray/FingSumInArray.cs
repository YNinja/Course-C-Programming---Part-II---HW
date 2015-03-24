﻿/* Problem 10. Find sum in array

Write a program that finds in given array of integers a sequence of 
given sum S (if present).

Example:
array 	                S 	    result
4, 3, 1, 4, 2, 5, 8 	11 	    4, 2, 5

 */

using System;
using System.Collections.Generic;
class FingSumInArray
{
    static void Main(string[] args)
    {
        Console.Write("s = ");
        int s = int.Parse(Console.ReadLine());
        int[] myArray = { 4, 3, 1, 4, 2, 5, 8 };
        int currentSum = 0;
        List<int> result = new List<int>();
        for (int i = 0; i < myArray.Length - 1; i++)
        {
            if (myArray[i] < s)
            {
                int temp = i;
                while (currentSum < s)
                {
                    currentSum += myArray[temp];
                    if (temp == myArray.Length - 1)
                    {
                        break;
                    }
                    temp++;
                }
                if (currentSum == s)
                {
                    for (int j = i; j < temp; j++)
                    {
                        result.Add(myArray[j]);
                    }
                    currentSum = 0;
                }
                else
                {
                    currentSum = 0;
                }
            }
        }
        if (result.Count > 0)
        {
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] != result[result.Count - 1])
                {
                    Console.Write("{0}, ", result[i]);
                }
                else
                {
                    Console.WriteLine(result[i]);
                }
            }
        }
        else
        {
            Console.WriteLine("There is no sequence in the array, which sum is equal to {0}", s);
        }
    }
}