using System;
using System.Collections.Generic;
using System.Linq;

//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//Use generic method (read in Internet about generic methods in C#).


class UsingGenericMethod
{
    static Random rnd = new Random();
    static T[] GenerateRandomArray<T>(int numberOfItems)
    {
        int maxNumberInArray = numberOfItems * 3;
        double[] randomArray = new double[numberOfItems];
        T[] randomArrayOfT = new T[numberOfItems];

        for (int counter = 0; counter < numberOfItems; counter++)
        {
            randomArray[counter] = rnd.NextDouble() * numberOfItems;
            randomArrayOfT[counter] = (T)Convert.ChangeType(randomArray[counter], typeof(T));
        }
        return randomArrayOfT;
    }
    static void PrintArray<T>(T[] inputArray)
    {
        for (int counter = 0; counter < inputArray.Length; counter++)
        {
            Console.Write("{0}\t", inputArray[counter]);
        }
    }
    static T FindMinValue<T>(params T[] inputnumbers)
    {
        dynamic minValue = inputnumbers[0];
        foreach (T number in inputnumbers)
        {
            if (number < minValue)
            {
                minValue = number;
            }
        }
        return minValue;
    }
    static T FindMaxValue<T>(params T[] inputnumbers)
    {
        dynamic maxValue = inputnumbers[0];
        foreach (T number in inputnumbers)
        {
            if (number > maxValue)
            {
                maxValue = number;
            }
        }
        return maxValue;
    }
    static double FindAverageValue<T>(params T[] inputNumbers)
    {
        dynamic sumOfNumbers = 0;
        foreach (T number in inputNumbers)
        {
            sumOfNumbers += number;
        }

        double average = (double)sumOfNumbers / inputNumbers.Length;
        return average;
    }
    static dynamic FindSumValue<T>(params T[] inputNumbers)
    {
        dynamic sumOfNumbers = 0;
        foreach (T number in inputNumbers)
        {
            sumOfNumbers += number;
        }
        return sumOfNumbers;
    }
    static T FindProductValue<T>(params T[] inputNumbers)
    {
        dynamic productOfNumbers = 1;
        foreach (var number in inputNumbers)
        {
            productOfNumbers *= number;
        }
        return productOfNumbers;
    }
    static void PrintResult<T>(T[] inputArray)
    {
        Console.WriteLine();
        Console.WriteLine("\nInput array:");
        PrintArray(inputArray);
        Console.WriteLine();
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("\nMin value = {0}", FindMinValue(inputArray));
        Console.WriteLine("Max value = {0}", FindMaxValue(inputArray));
        Console.WriteLine("Average value = {0}", FindAverageValue(inputArray));
        Console.WriteLine("Sum value = {0}", FindSumValue(inputArray));
        Console.WriteLine("Product value = {0}", FindProductValue(inputArray));
    }
    static void Main()
    {
        //int[] array = GenerateRandomArray<int>(10);
        //double[] array = GenerateRandomArray<double>(10);
        decimal[] array = GenerateRandomArray<decimal>(10);
        PrintResult(array);
    }
}

