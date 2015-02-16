using System;
using System.Collections.Generic;

//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.

class Factorial
{
    static void PrintArray(int[] inputArray)
    {
        for (int counter = 0; counter < inputArray.Length; counter++)
        {
            Console.Write("{0}", inputArray[counter]);
        }
    }
    static int[] SumBigIntegers(int[] firstNumber, int[] secondNumber)
    {
        //determining the max lenght of the result number
        int[] longNumber;
        int[] shortnumber;
        int resultLenght = 0;
        int lenghtDifference = firstNumber.Length - secondNumber.Length;
        if (lenghtDifference > 0)
        {
            resultLenght = firstNumber.Length;
            longNumber = firstNumber;
            shortnumber = secondNumber;
        }
        else
        {
            resultLenght = secondNumber.Length;
            longNumber = secondNumber;
            shortnumber = firstNumber;
            lenghtDifference = secondNumber.Length - firstNumber.Length;
        }

        resultLenght++;

        //calculating result number
        int temp = 0;
        int counter = resultLenght - 2;
        List<int> resultNumber = new List<int>();
        for (int pos = counter; pos >= 0; pos--)
        {
            if (pos - lenghtDifference >= 0)
            {
                temp = longNumber[pos] + shortnumber[pos - lenghtDifference] + temp;
            }
            else
            {
                temp = longNumber[pos] + temp;
            }

            if (temp < 10)
            {
                resultNumber.Add(temp);
                temp = 0;
            }
            else
            {
                resultNumber.Add(temp % 10);
                temp = 1;
            }
        }
        if (temp != 0)
        {
            resultNumber.Add(temp);
        }
        resultNumber.Reverse();
        int[] result = resultNumber.ToArray();
        return result;
    }
    static int[] IntToArray(int inputNumber)
    {
        string numberAsString = inputNumber.ToString();
        int[] resultArray = new int[numberAsString.Length];
        for (int index = numberAsString.Length - 1; index >= 0; index--)
        {
            resultArray[index] = inputNumber % 10;
            inputNumber /= 10;
        }
        return resultArray;
    }
    static int[] ProductBigIntegers(int[] firstNumber, int[] secondNumber)
    {
        int[] result = new int[1] { 0 };
        int numberLenght = firstNumber.Length;
        int[] counter = new int[numberLenght];
        int possitionInNumber = 0;
        counter[numberLenght - 1] = 1;

        while (true)
        {
            possitionInNumber = numberLenght - 1;
            while (counter[possitionInNumber] <= firstNumber[possitionInNumber])
            {
                result = SumBigIntegers(result, secondNumber);
                counter[possitionInNumber]++;
            }
            counter[possitionInNumber]++;

            while (counter[possitionInNumber] > firstNumber[possitionInNumber])
            {
                counter[possitionInNumber] = 0;
                firstNumber[possitionInNumber] = 9;
                possitionInNumber--;

                if (possitionInNumber < 0)
                {
                    return result;
                }
                counter[possitionInNumber] = counter[possitionInNumber] + 1;
            }
        }
        return result;
    }
    static void Main()
    {
        Console.Write("Enter an int to calculate factoriel from: ");
        int number = int.Parse(Console.ReadLine());
        int[] numberFactoriel = new int[] { 1 };

        for (int index = 1; index <= number; index++)
        {
            numberFactoriel = ProductBigIntegers(IntToArray(index), numberFactoriel);
        }
        Console.WriteLine();
        Console.WriteLine(new string('-', 80));
        long startTime = DateTime.UtcNow.Ticks;
        PrintArray(numberFactoriel);
        Console.WriteLine();
        long endTime = DateTime.UtcNow.Ticks;
        double elapsedTime = (endTime - startTime) / 100000.0;
        Console.WriteLine("\nCalculation of {0}! have taken {1} s", number, elapsedTime);
    }
}