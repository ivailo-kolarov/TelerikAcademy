using System;


//Write a program that sorts an array of integers using the Merge sort algorithm.


class MergeSort
{
    static void Merge(int[] arr, int[] temp, int l, int m, int r)
    {
        int i = l, j = m + 1, k = l;

        // For both arrays
        while (i <= m && j <= r)
            if (arr[i] < arr[j]) temp[k++] = arr[i++];
            else temp[k++] = arr[j++];

        while (i <= m) temp[k++] = arr[i++]; // Copy items left from first array
        while (j <= r) temp[k++] = arr[j++]; // Or from second array

        for (i = l; i <= r; i++) arr[i] = temp[i]; // Save to the original array
    }

    static void MergeSort(int[] arr, int[] temp, int l, int r)
    {
        if (l >= r) return;

        int m = l + (r - l) / 2; // Split in two

        MergeSort(arr, temp, l, m);
        MergeSort(arr, temp, m + 1, r);

        Merge(arr, temp, l, m, r); // And merge the sorted halves
    }

    static void Main()
    {

        int[] arr = { -1, 2, -3, 4, -5, 6, -7 };

        int[] temp = new int[arr.Length];
        MergeSort(arr, temp, 0, arr.Length - 1);

        foreach (int item in arr) Console.WriteLine(item);

    }
}

