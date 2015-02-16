using System;


//Write a program to convert hexadecimal numbers to their decimal representation.


class HexToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter number in Hexadecimal");
        string hex = Console.ReadLine();
        ConvertToDecimal(hex.ToUpper());
    }

    static void ConvertToDecimal(string hex)
    {
        int dec = 0;
        int len = hex.Length;
        for (int i = len - 1; i >= 0; i--)
        {
            switch (hex[i])
            {
                case 'A': dec += 10 * (int)Math.Pow(16, len - 1 - i); break;
                case 'B': dec += 11 * (int)Math.Pow(16, len - 1 - i); break;
                case 'C': dec += 12 * (int)Math.Pow(16, len - 1 - i); break;
                case 'D': dec += 13 * (int)Math.Pow(16, len - 1 - i); break;
                case 'E': dec += 14 * (int)Math.Pow(16, len - 1 - i); break;
                case 'F': dec += 15 * (int)Math.Pow(16, len - 1 - i); break;
                default: dec += (hex[i] - '0') * (int)Math.Pow(16, len - 1 - i); break;
            }
        }
        Console.WriteLine(dec);
    }
}

