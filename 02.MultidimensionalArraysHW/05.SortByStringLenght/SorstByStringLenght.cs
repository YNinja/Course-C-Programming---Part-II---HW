/* Problem 5. Sort by string length

You are given an array of strings. Write a method that sorts
the array by the length of its elements
(the number of characters composing them).
*/

using System;
class SorstByStringLenght
{
    static void Main(string[] args)
    {
        string[] myArray = { "apple", "strawberry", "banana", "coconut", "lime" };
        string temp = " ";
        for (int i = 0; i < myArray.Length - 1; i++)
        {
            for (int j = i + 1; j < myArray.Length; j++)
            {
                if (myArray[i].Length > myArray[j].Length)
                {
                    temp = myArray[i];
                    myArray[i] = myArray[j];
                    myArray[j] = temp;
                }
            }
        }
        Console.WriteLine("The array, sorted by the length of its elements, looks like this: ");
        for (int i = 0; i < myArray.Length; i++)
        {
            if (i != myArray.Length - 1)
            {
                Console.Write("{0}, ", myArray[i]);
            }
            else
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}