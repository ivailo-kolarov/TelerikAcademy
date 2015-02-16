using System;

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.



public class AppearanceCount
{
    public static int CountAppearances (int[] array, int searchedNumber)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] == searchedNumber)
            {
                counter++;
            }
        }
        return counter;
    }
        

    static void Main()
    {
        Console.WriteLine("Enter the length of the array");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number to check it's appearances in the array");
        int searchedNumber = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
               Console.Write("Array[{0}] ", i);
                array[i] = int.Parse(Console.ReadLine());
        }

        CountAppearances(array, searchedNumber);

        Console.WriteLine("The number {0} appears {1} times in the array", searchedNumber, CountAppearances(array, searchedNumber));
    }
}

