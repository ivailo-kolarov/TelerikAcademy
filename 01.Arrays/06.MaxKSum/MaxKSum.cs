using System;


//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.


class MaxKSum
{
    static void Main()
    {

        Console.WriteLine("Calculationg the best K elements in array of N elements");

        Console.Write("Enter N =");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter K =");
        int k = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        int sum = 0;

        if (k > n)
        {
            Console.WriteLine("K cannot be bigger than array's lenght");
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);
        Array.Reverse(arr);

        for (int i = 0; i < k; i++)
        {
            sum += arr[i]; 
        }

        Console.WriteLine("The greatest sum of K={0} elements is {1} ", k, sum);
    }

}

