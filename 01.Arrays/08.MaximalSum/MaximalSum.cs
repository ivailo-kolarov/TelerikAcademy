using System;





class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("Calculating the maximal sum of sequance in an array.");

        Console.Write("Enter size of the array: ");

        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

       int currSum = arr[0];
       int startIndex = 0;
       int endIndex = 0;
       int temp = 0;
       int maxSum = arr[0];

       for (int i = 0; i < n; i++)
       {
           if(currSum <= 0)
           {

               startIndex = i;
               currSum = 0;
               
           }

           currSum += arr[i];

           if (currSum > maxSum)
           {
               maxSum = currSum;
               temp = startIndex;
               endIndex = i;
           }
       }

       Console.Write("The best sequence is: ");

       for (int i = startIndex; i <= endIndex; i++)
       {
           Console.Write(arr[i] + " ");
       }

       Console.WriteLine();
       Console.WriteLine("The max sum is: {0}", maxSum);
    }
}

