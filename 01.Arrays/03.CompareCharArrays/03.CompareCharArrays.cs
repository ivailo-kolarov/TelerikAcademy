using System;
using System.Linq;
//Write a program that compares two char arrays lexicographically (letter by letter).


class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the lenght of first array !");
        int n = int.Parse(Console.ReadLine());

        char[] arrayOne = new char[n];
        ReadArray(arrayOne);
        Console.WriteLine("Enter the lenght of second array !");
        int m = int.Parse(Console.ReadLine());

        char[] arrayTwo = new char[m];
        ReadArray(arrayTwo);
        CompareArrays(arrayOne, arrayTwo);
    }

    private static void ReadArray(char[] someArray)
    {
        for (int i = 0; i < someArray.Length; i++)
        {
            someArray[i] = char.Parse(Console.ReadLine());
        }
    }

    private static void CompareArrays(char[] arrayOne, char[] arrayTwo)
    {
        if (arrayOne.Length > arrayTwo.Length)
        {
            Console.WriteLine("The first array is bigger");
        }
        else if (arrayOne.Length < arrayTwo.Length)
        {
            Console.WriteLine("The second array is bigger");
        }
        else
        {
            Console.WriteLine("Two arrays are equal in lenght ...");
            if (arrayOne.Where((t, i) => t != arrayTwo[i]).Any())
            {
                Console.WriteLine("but different elements.");
                return;
            }

            Console.WriteLine("and equal elements.");
        }
    }
}

