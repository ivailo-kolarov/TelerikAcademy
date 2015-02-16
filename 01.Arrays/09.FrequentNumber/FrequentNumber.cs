using System;

//Write a program that finds the most frequent number in an array.

//input	                                    result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3--> 4 (5 times

class FrequentNumber
{
    static void Main()
    {
        Console.Write("Enter array length: ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Element[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());

        }

        int maxCounter = 0;
        int mostFrequent = 0;

        for (int i = 0; i < array.Length-1; i++)
        {
            int count = 1;
            for (int j = i+1; j < array.Length-1; j++)
            {
                if(array[i]== array[j])
                {
                    count++;
                }
            }

            if (count > maxCounter)
            {
                maxCounter = count;
                mostFrequent = array[i];
            }
           
        }

        if (maxCounter > 1)
        {
            Console.WriteLine("Most frequent number = {0}", mostFrequent);
            Console.WriteLine("Count = {0} times", maxCounter);
        }

        else
        {
            Console.WriteLine("All elements are different");
        }
    }
}

