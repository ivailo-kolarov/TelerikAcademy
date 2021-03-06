﻿using System;


//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).


class ShortNumberInBinary
{
    static void Main()
    {
        Console.WriteLine("Type short number = ");
        short number = short.Parse(Console.ReadLine());
        short sing = number;

        if (sing <= 0) 
        { 
            number = (short)(number + 1); 
        }

        Console.Write("Binary = ");

        for (int i = 15; i >= 0; i--)
        {
            short exponent = (short)Math.Pow(2, i);
            short digit = (short)(number / exponent);
            number = (short)(number % exponent);

            if 
                (sing < 0) 
            { 
                Console.Write(1 + digit); 
            }
            else 
            {
                Console.Write(digit); 
            }
        }
        Console.WriteLine();
    }
}

