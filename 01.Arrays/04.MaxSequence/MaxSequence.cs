using System;



//2, 1, 1, 2, 3, 3, 2, 2, 2, 1  -->	 (2, 2, 2)

class MaxSequence
{
    static void Main()
    {
        Console.WriteLine("Enter the lenght of the array");
        int n = int.Parse(Console.ReadLine());
        int count = 1;
        int bestCount = 0;
        int element = 0;
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                count++;
                if (count >= bestCount)
                {
                    bestCount = count;
                    element = array[i];
                }
            }
            else
            {
                count = 1;
            }
        }
        Console.WriteLine();
        Console.WriteLine("The max sequence of equal elements in the array is \n");
        Console.Write("{");
        for (int i = 0; i < bestCount; i++)
        {
            if (i == bestCount - 1)
            {
                Console.Write("{0}", element);
                break;
            }
            Console.Write("{0},", element);
        }
        if (bestCount == 0)
        {
            Console.Write("The is no equals elements in the array");
        }
        Console.WriteLine("}");
        Console.WriteLine();
    }
}

