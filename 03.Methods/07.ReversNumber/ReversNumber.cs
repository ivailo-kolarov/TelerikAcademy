using System;

//Write a method that reverses the digits of given decimal number.
//Example:

//input	output
//256	652



class ReversNumber
{
    static void Main()
    {
        Console.WriteLine("Enter the number to reverse");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(ReverseNumber(number));
    }

    public static int ReverseNumber(int number)
    {
        int tempNumber = 0;
        while (number > 0)
        {
            tempNumber = (tempNumber * 10) + (number % 10);
            number /= 10;
        }
        return tempNumber;
    }
}

