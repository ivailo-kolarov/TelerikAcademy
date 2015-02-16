using System;
using System.Collections.Generic;

//Write a program that finds the maximal increasing sequence in an array
//3, 2, 3, 4, 2, 2, 4 --->	(2, 3, 4)

class MaxIncreaseSequence
{
    static void Main()
    {
        Console.WriteLine("Enter the lenght of the array !");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter the elements of the array:");
        int count = 1;
        int bestCount = 0;
        int element = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                count++;
            }

            else
            {
                if (count > bestCount)
                {
                    bestCount = count;
                    element = i;
                }
                count = 1;
            }
        }
            if (count > bestCount)
            {
                bestCount = count;
                element = array.Length - 1;
            }
            count = 1;
            Console.WriteLine("The longest sequence of increasing elements is:");
            Console.Write("{");
            for (int i = element - bestCount + 1; i < element + 1; i++)
            {
                Console.Write("{0},", array[i]);
            }
            Console.WriteLine("}");
        
    }
}

