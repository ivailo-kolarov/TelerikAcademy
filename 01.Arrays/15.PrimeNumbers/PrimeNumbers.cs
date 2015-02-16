using System;

//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.



class PrimeNumbers

{
    static void Main()
    {


        bool[] allNums = new bool[10000000];
        for (int i = 2; i < Math.Sqrt(allNums.Length); i++)
        {
            if (!allNums[i])
            {
                for (int j = i * i; j < allNums.Length; j = j + i)
                {
                    allNums[j] = true;
                }
            }
        }
        for (int i = 2; i < allNums.Length; i++)
        {
            if (!allNums[i])
            {
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();
    }
}

