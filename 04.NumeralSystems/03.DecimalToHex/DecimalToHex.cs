using System;


//Write a program to convert decimal numbers to their hexadecimal representation.


class DecimalToHex
{
    public static char GetChar(int i)
    {
        if (i > 10)
        {
            return (char)('A' + i - 10);
        }
        else
        {
            return (char)('0' + i);
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter number in Decimal to conver it in Hexadecimal system");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(ConvertToHex(n));
    }
    static string ConvertToHex(int number)
    {
        string result = string.Empty;
        while (number != 0)
        {
            result = GetChar(number % 16) + result;
            number /= 16;
        }
        return result;
    }
}

