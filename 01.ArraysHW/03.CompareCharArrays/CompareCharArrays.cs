/* Problem 3. Compare char arrays

    Write a program that compares two char arrays lexicographically (letter by letter).
*/

using System;
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of characters for the first array: ");
            int fNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the characters for the first array: ");
            char[] fArray = new char[fNumber];
            for (int i = 0; i < fArray.Length; i++)
            {
                fArray[i] = Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine("Enter the number of characters for the second array: ");
            int sNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the characters for the second array: ");
            char[] sArray = new char[sNumber];
            for (int i = 0; i < sArray.Length; i++)
			{
			 sArray[i] = Convert.ToChar(Console.ReadLine());
			}

            if (fArray.Length == sArray.Length)
            {
                Console.WriteLine("The array's lenght is equal.");

                for (int i = 0; i < fArray.Length; i++)
                {
                    if (fArray[i] == sArray[i])
                    {
                        Console.WriteLine("The characters are the same.");
                    }
                    else
                    {
                        Console.WriteLine("The characters are not the same and lexicographically:");
                        if (fArray[i] < sArray[i])
                        {
                            Console.WriteLine("{0} < {1}", fArray[i], sArray[i]);
                        }
                        else
                        {
                            Console.WriteLine("{0} > {1}", fArray[i], sArray[i]);
                        }
                    }
                }
            }

            if (fArray.Length != sArray.Length)
            {
                Console.WriteLine("The array's lenght is not equal and the comparison goes by the smaller lenght array:");

                int smallerLenght = Math.Min(fArray.Length, sArray.Length);

                for (int i = 0; i < smallerLenght; i++)
                {
                    if (fArray[i] == sArray[i])
                    {
                        Console.WriteLine("The characters are the same.");
                    }
                    else
                    {
                        Console.WriteLine("The characters are not the same and lexicographically:");
                        if (fArray[i] < sArray[i])
                        {
                            Console.WriteLine("{0} < {1}", fArray[i], sArray[i]);
                        }
                        else
                        {
                            Console.WriteLine("{0} > {1}", fArray[i], sArray[i]);
                        }
                    }
                }
            }
        }
    }