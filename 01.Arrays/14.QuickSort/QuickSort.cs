using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that sorts an array of integers using the Quick sort algorithm.


class QuickSort
{
    static void Main()
    {
        string[] stringArray = { "asda", "dvqweds", "excaer", "ftrdvadvce", "vvasdest", "asaa", "dsda", "djhfgb", "adas", "fsa", "fasaa", "asdbada" };

        List<string> sortedList = stringArray.ToList();

        sortedList = Partition(sortedList);
        foreach (var item in sortedList)
        {
            Console.WriteLine(item);
        }
    }

    private static List<string> Partition(List<string> partition)
    {
        List<string> left = new List<string>();
        List<string> right = new List<string>();

        if (partition.Count > 0)
        {
            int pivot = GetPivot(partition);

            string pivotString = partition[pivot];

            for (int i = 0; i < partition.Count; i++)
            {
                if (i != pivot)
                {
                    if (string.Compare(partition[i], partition[pivot]) >= 0)
                    {
                        right.Add(partition[i]);
                    }
                    else
                    {
                        left.Add(partition[i]);
                    }
                }
            }

            left = Partition(left);
            right = Partition(right);

            partition.Clear();
            partition.AddRange(left);
            partition.Add(pivotString);
            partition.AddRange(right);
        }

        return partition;
    }

    public static int GetPivot(List<string> tempArray)
    {
        Random randomNum = new Random();
        int[] random = new int[3];
        string[] randomString = new string[3];

        for (int i = 0; i < 3; i++)
        {
            random[i] = randomNum.Next(0, tempArray.Count);

            randomString[i] = tempArray[random[i]] + i;
        }

        Array.Sort(randomString);

        return random[(randomString[1][randomString[1].Length - 1]) - '0'];
    }
}

