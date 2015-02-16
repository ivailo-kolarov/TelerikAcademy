using System;


//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.


class MinMaxAverageSumProduct
{
    static Random rnd = new Random();
    static int[] GenerateRandomArray(int numberOfItems)
    {
        int maxNumberInArray = numberOfItems * 2;
        int[] randomArray = new int[numberOfItems];

        for (int counter = 0; counter < numberOfItems; counter++)
        {
            randomArray[counter] = rnd.Next(maxNumberInArray);
        }
        return randomArray;
    }
    static void PrintArray(int[] inputArray)
    {
        for (int counter = 0; counter < inputArray.Length; counter++)
        {
            Console.Write("{0}\t", inputArray[counter]);
        }
    }
    static int FindMinValue(params int[] inputnumbers)
    {
        int minValue = int.MaxValue;
        foreach (var number in inputnumbers)
        {
            if (number < minValue)
            {
                minValue = number;
            }
        }
        return minValue;
    }
    static int FindMaxValue(params int[] inputnumbers)
    {
        int maxValue = int.MinValue;
        foreach (var number in inputnumbers)
        {
            if (number > maxValue)
            {
                maxValue = number;
            }
        }
        return maxValue;
    }
    static double FindAverageValue(params int[] inputNumbers)
    {
        int sumOfNumbers = 0;
        foreach (var number in inputNumbers)
        {
            sumOfNumbers += number;
        }

        double average = (double)sumOfNumbers / inputNumbers.Length;
        return average;
    }
    static int FindSumValue(params int[] inputNumbers)
    {
        int sumOfNumbers = 0;
        foreach (var number in inputNumbers)
        {
            sumOfNumbers += number;
        }
        return sumOfNumbers;
    }
    static int FindProductValue(params int[] inputNumbers)
    {
        int productOfNumbers = 1;
        foreach (var number in inputNumbers)
        {
            productOfNumbers *= number;
        }
        return productOfNumbers;
    }
    static void Main()
    {
        Console.WriteLine("Enter the Lenght of an Array: ");
        int numbersCount = int.Parse(Console.ReadLine());
        int[] array = GenerateRandomArray(numbersCount);

        Console.WriteLine("\nInput arraY:");
        PrintArray(array);
        Console.WriteLine();
        Console.WriteLine(new string('-', 80));
        Console.WriteLine();
        Console.WriteLine("Min value = {0}", FindMinValue(array));
        Console.WriteLine("Max value = {0}", FindMaxValue(array));
        Console.WriteLine("Average value = {0}", FindAverageValue(array));
        Console.WriteLine("Sum value = {0}", FindSumValue(array));
        Console.WriteLine("Product value = {0}", FindProductValue(array));
    }
}

