/* Problem 1. Fill the matrix

Write a program that fills and prints a matrix of size (n, n) as shown below:

Example for n=4:

a) 	b) 	c) 	d)*
1 	5 	9 	13
2 	6 	10 	14
3 	7 	11 	15
4 	8 	12 	16
	
1 	8 	9 	16
2 	7 	10 	15
3 	6 	11 	14
4 	5 	12 	13
	
7 	11 	14 	16
4 	8 	12 	15
2 	5 	9 	13
1 	3 	6 	10
	
1 	12 	11 	10
2 	13 	16 	9
3 	14 	15 	8
4 	5 	6 	7

 */

using System;
class FillTheMatrix
{
    static void Main(string[] args)
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[,] myArrayA = new int[n, n];
        int[,] myArrayB = new int[n, n];
        int[,] myArrayC = new int[n, n];
        for (int row = 0; row < myArrayA.GetLength(1); row++)
        {
            for (int col = 0; col < myArrayA.GetLength(0); col++)
            {
                myArrayA[row, col] = row + 1 + col * n;
            }
        }
        Console.WriteLine("a)");
        PrintArray(myArrayA);
        int number = 1;
        for (int col = 0; col < myArrayB.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < myArrayB.GetLength(0); row++)
                {
                    myArrayB[row, col] = number;
                    number++;
                }
            }
            else
            {
                for (int row = myArrayB.GetLength(0) - 1; row >= 0; row--)
                {
                    myArrayB[row, col] = number;
                    number++;
                }
            }
        }
        Console.WriteLine("b)");
        PrintArray(myArrayB);
        number = 1;
        for (int row = myArrayC.GetLength(0) - 1; number <= myArrayC.GetLength(0) * myArrayC.GetLength(1); row--)
        {
            for (int currentCol = (row >= 0 ? 0 : -row), currentRow = (row >= 0 ? row : 0);
            currentCol < (myArrayC.GetLength(1) - (row >= 0 ? row : 0)); )
            {
                myArrayC[currentRow++, currentCol++] = number++;
            }
        }
        Console.WriteLine("c)");
        PrintArray(myArrayC);
        number = 1;
        int[,] myArrayD = new int[n, n];
        int r = 0;
        int c = 0;
        int maxRow = n - 1;
        int maxCol = n - 1;
        int count = 1;
        do
        {
            for (int i = r; i <= maxRow; i++)
            {
                myArrayD[i, c] = count;
                count++;
            }
            c++;
            for (int i = c; i <= maxCol; i++)
            {
                myArrayD[maxRow, i] = count;
                count++;
            }
            maxRow--;
            for (int i = maxRow; i >= r; i--)
            {
                myArrayD[i, maxCol] = count;
                count++;
            }
            maxCol--;
            for (int i = maxCol; i >= c; i--)
            {
                myArrayD[r, i] = count;
                count++;
            }
            r++;
        } while (count <= n * n);
        Console.WriteLine("d)");
        PrintArray(myArrayD);
    }
    private static void PrintArray(int[,] myArray)
    {
        for (int row = 0; row < myArray.GetLength(0); row++)
        {
            for (int col = 0; col < myArray.GetLength(1); col++)
            {
                Console.Write("{0, 4}", myArray[row, col]);
            }
            Console.WriteLine();
        }
    }
}