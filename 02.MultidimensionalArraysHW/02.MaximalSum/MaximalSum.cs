﻿/* Problem 2. Maximal sum

Write a program that reads a rectangular matrix of size N x M 
and finds in it the square 3 x 3 that has maximal sum of its elements.
*/

using System;
class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = { { 1, 2, 3, 4, 5, 6, 7 },
                        { 8, 9, 1, 2, 3, 4, 5 },
                        { 1, 2, 4, 6, 7, 8, 9 },
                        { 3, 4, 5, 6, 7, 9, 9 },
                        { 7, 8, 8, 9, 9, 9, 9} };
        int maxSum = int.MinValue;
        int currentSum = 0;
        int bestRow = 0;
        int bestCol = 0;
        int size = 3;
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                currentSum = matrix[row, col] + matrix[row + 1, col] + matrix[row + 2, col] +
                matrix[row, col + 1] + matrix[row + 1, col + 1] + matrix[row + 2, col + 1] +
                matrix[row, col + 2] + matrix[row + 1, col + 2] + matrix[row + 2, col + 2];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        Console.WriteLine("The square 3 x 3 that has maximal sum of its elements in the array is: ");
        for (int row = bestRow; row < bestRow + size; row++)
        {
            for (int col = bestCol; col < bestCol + size; col++)
            {
                Console.Write(" {0} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}