/* Problem 15. Prime numbers

Write a program that finds all prime numbers in the range [1...10 000 000]. 
Use the Sieve of Eratosthenes algorithm.
*/

using System;
class PrimeNumbers
{
    static void Main(string[] args)
    {
        bool[] primeNums = new bool[10000000];
        int count = 0;
        for (int i = 2; i < Math.Sqrt(primeNums.Length); i++)
        {
            if (primeNums[i] == false)
            {
                for (int j = i * i; j < primeNums.Length; j += i)
                {
                    primeNums[j] = true;
                }
            }
        }
        for (int i = 2; i < primeNums.Length; i++)
        {
            if (!primeNums[i]) count++;
        }
        Console.WriteLine("Prime numbers between 1 and 10 000 000 are {0}.", count);
    }
}