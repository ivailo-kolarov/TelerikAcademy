using System;
using System.Linq;

/*You are given an array of strings. Write a method that sorts 
the array by the length of its elements (the number of characters composing them).
*/

class SortArrayByLenght
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the array");
        int n = int.Parse(Console.ReadLine());

        string[] array = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("array[{0}]= ", i);
            array[i] = (Console.ReadLine());
        }

        foreach (var wordsSortedByLenght in array.OrderBy(orderString => orderString.Length))
        {
            Console.WriteLine(wordsSortedByLenght);
        }
    }
}

