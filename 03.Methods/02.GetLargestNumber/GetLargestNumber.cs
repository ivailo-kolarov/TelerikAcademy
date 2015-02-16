using System;
/*
Write a method GetMax() with two parameters that returns the larger of two integers.
Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax()
*/


class GetLargestNumber
{
   

    public static int  GetMax(int a, int b)
    {
        return a > b ? a : b; 
    }

     static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine(GetMax(GetMax(a, b), c));
    }
}

