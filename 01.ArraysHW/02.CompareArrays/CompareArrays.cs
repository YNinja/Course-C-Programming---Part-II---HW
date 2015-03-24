/* Problem 2. Compare arrays

    Write a program that reads two integer arrays from the console and compares them element by element.
*/

using System;  
class CompareArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of integers for the first array: ");
            int fNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the integers for the first array: ");
            int[] fArray = new int[fNumber];            
            for (int i = 0; i < fArray.Length; i++)
			{
			 fArray[i] = int.Parse(Console.ReadLine());
			}

            Console.WriteLine("Enter the number of integers for the second array: ");
            int sNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the integers for the second array: ");
            int[] sArray = new int[sNumber];
            for (int i = 0; i < sArray.Length; i++)
            {
                sArray[i] = int.Parse(Console.ReadLine());
            }

            if (fArray.Length != sArray.Length)
            {
                Console.WriteLine("The array's lenght is not equal and the comaprison goes by the lenght of smaller one like this:");

                int smallerArray = Math.Min(fArray.Length, sArray.Length);

                for (int i = 0; i < smallerArray; i++)
                {
                    if (fArray[i] == sArray[i])
                    {
                        Console.WriteLine("{0} = {1}", fArray[i], sArray[i]);
                    }

                    if (fArray[i] > sArray[i])
                    {
                        Console.WriteLine("{0} > {1}", fArray[i], sArray[i]);
                    }

                    if (fArray[i] < sArray[i])
                    {
                        Console.WriteLine("{0} < {1}", fArray[i], sArray[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("The array's lenght is equal.");
                
                for (int i = 0; i < fArray.Length; i++)
                {
                    if (fArray[i] == sArray[i])
                    {
                        Console.WriteLine("{0} = {1}", fArray[i], sArray[i]);
                    }

                    if (fArray[i] > sArray[i])
                    {
                        Console.WriteLine("{0} > {1}", fArray[i], sArray[i]);
                    }

                    if (fArray[i] < sArray[i])
                    {
                        Console.WriteLine("{0} < {1}", fArray[i], sArray[i]);
                    }
                }

            }
            
        }
    }