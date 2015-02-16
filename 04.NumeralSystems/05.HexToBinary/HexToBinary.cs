using System;
using System.Text;

//Write a program to convert hexadecimal numbers to binary numbers (directly).


class HexToBinary
{
    static void Main()
    {
        string hexNumber = Console.ReadLine();
        string binNumber = ConvertHexToBin(hexNumber);
        Console.WriteLine(binNumber);
    }

    static string ConvertHexToBin(string hex)
        {
        char[] hexChar = hex.ToUpper().ToCharArray();
        StringBuilder hexStr = new StringBuilder();

        for (int i = 0; i < hexChar.Length; i++)
        {
            switch (hexChar[i])
            {
                case 'A': hexStr.Append(" 1010"); break;
                case 'B': hexStr.Append(" 1011"); break;
                case 'C': hexStr.Append(" 1100"); break;
                case 'D': hexStr.Append(" 1101"); break;
                case 'E': hexStr.Append(" 1110"); break;
                case 'F': hexStr.Append(" 1111"); break;
                case '0': hexStr.Append(" 0000"); break;
                case '1': hexStr.Append(" 0001"); break;
                case '2': hexStr.Append(" 0010"); break;
                case '3': hexStr.Append(" 0011"); break;
                case '4': hexStr.Append(" 0100"); break;
                case '5': hexStr.Append(" 0101"); break;
                case '6': hexStr.Append(" 0110"); break;
                case '7': hexStr.Append(" 0111"); break;
                case '8': hexStr.Append(" 1000"); break;
                case '9': hexStr.Append(" 1001"); break;
            }
        }
        return hexStr.ToString();
    }
}


