using System;


//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example: {4, 3, 1, 4, 2, 5, 8}, S=11 ? {4, 2, 5}

class FindSumInArray
{
    static void Main()
    {
        Console.Write("Enter array length: ");
        int arrayLength = int.Parse(Console.ReadLine());

        int[] array = new int[arrayLength];

        Console.WriteLine("Enter searching sum k=:");
        int k = int.Parse(Console.ReadLine());

        int currentSum = 0;
        int startElement = 0;
        int printStart = 0;
        int printEnd = 0;

        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Element[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length; i++)
        {
            currentSum += array[i];

            if (currentSum == k)
            {
                printStart = startElement;
                printEnd = i;
                break;
            }

            if (i == array.Length - 1)
            {
                currentSum = 0;
                startElement++;

                if (startElement == array.Length)
                {
                    break;
                }
                i = startElement - 1;
            }
        }
            if (k != currentSum)
            {
                Console.WriteLine("No such sum in array");
                return;
            }
            for (int i = printStart; i <= printEnd; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        
    }
}

