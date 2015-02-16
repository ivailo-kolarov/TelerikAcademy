using System;

//Write a program to convert decimal numbers to their binary representation.



class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter Decimal Number");
        int numberDec = int.Parse(Console.ReadLine());
        ConvertToBinary(numberDec);
      
    }

    static void ConvertToBinary(int number)
    {

        string result = string.Empty;
        while(number > 0)
        {
            result = (number % 2) + result;
            number /= 2;
        }
        Console.WriteLine("Number in binary system is: ");
        Console.WriteLine(result);
    }
}

