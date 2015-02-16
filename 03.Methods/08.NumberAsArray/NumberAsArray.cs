using System;

//Write a method that adds two positive integer numbers represented 
//as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.



class NumberAsArray
{
    class BigIntegersSum
    {
        static Random rnd = new Random();
        static int[] GenerateRandomArray(int numberOfItems)
        {
            int maxNumberInArray = 10;
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
            int[] resultNumber = new int[resultLenght];
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
                    resultNumber[pos + 1] = temp;
                    temp = 0;
                }
                else
                {
                    resultNumber[pos + 1] = temp % 10;
                    temp = 1;
                }
            }
            resultNumber[0] = temp;

            return resultNumber;
        }
        static void Main()
        {
            Console.Write("Enter the lenght of first integer: ");
            int firstIntLenght = int.Parse(Console.ReadLine());
            Console.Write("Enter the lenght of second integer: ");
            int secondIntLenght = int.Parse(Console.ReadLine());

            int[] firstNumber = GenerateRandomArray(firstIntLenght);
            int[] secondNumber = GenerateRandomArray(secondIntLenght);

            //hardcode
            //firstNumber = new int[6] { 1, 2, 3, 4, 5, 6 };
            //secondNumber = new int[3] { 7, 8, 9 };


            int pad = Console.CursorLeft + firstNumber.Length + secondNumber.Length + 14;
            Console.WriteLine();
            Console.Write("First number:");
            if (Math.Max(firstIntLenght, secondIntLenght) < 63)
            {
                Console.SetCursorPosition(pad - firstIntLenght + 1, Console.CursorTop);
            }
            PrintArray(firstNumber);
            Console.WriteLine();

            Console.Write("Second number:");
            if (Math.Max(firstIntLenght, secondIntLenght) < 63)
            {
                Console.SetCursorPosition(pad - secondIntLenght + 1, Console.CursorTop);
            }
            PrintArray(secondNumber);
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            int[] resultNumber = SumBigIntegers(firstNumber, secondNumber);

            if (Math.Max(firstIntLenght, secondIntLenght) < 63)
            {
                pad = Console.CursorLeft + Math.Min(firstIntLenght, secondIntLenght) + 14;
            }
            Console.Write("Result number:");
            Console.SetCursorPosition(pad, Console.CursorTop);
            PrintArray(resultNumber);
            Console.WriteLine();
        }
    }
}
