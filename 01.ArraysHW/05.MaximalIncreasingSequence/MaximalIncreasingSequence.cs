﻿/* Problem 5. Maximal increasing sequence

Write a program that finds the maximal increasing sequence in an array.

Example:
input 	                result
3, 2, 3, 4, 2, 2, 4 	2, 3, 4

 */

using System;
using System.Collections.Generic;

    class MaximalIncreasingSequence
    {
        static void Main(string[] args)
        {
            int[] myArray = { 3, 2, 3, 4, 2, 2, 4 };
            int count = 1;
            int temp = 0;
            int maxCount = 1;
            List<int> bestSequence = new List<int>();
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                if (myArray[i] < myArray[i + 1])
                {
                    temp = i;
                    while (myArray[temp] < myArray[temp + 1])
                    {
                        temp++;
                        count++;
                        if (temp == myArray.Length - 1)
                        {
                            break;
                        }
                    }
                    if (maxCount < count)
                    {
                        maxCount = count;
                        bestSequence.Clear();
                        for (int j = i; j < i + maxCount; j++)
                        {
                            bestSequence.Add(myArray[j]);
                        }
                    }
                    count = 1;
                }
                else
                {
                    count = 1;
                }
            }
            Console.Write("The maximal increasing sequence is: ");
            for (int i = 0; i < bestSequence.Count; i++)
            {
                if (bestSequence[i] != bestSequence[bestSequence.Count - 1])
                {
                    Console.Write("{0}, ", bestSequence[i]);
                }
                else
                {
                    Console.WriteLine("{0}", bestSequence[i]);
                }
            }
        }
    }