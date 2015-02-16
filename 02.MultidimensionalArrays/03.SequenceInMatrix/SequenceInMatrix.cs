using System;
using System.Collections.Generic;
/*------------------------------------------------------------------------------------------------------------------------
We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.
Example:
matrix				result					matrix			result
ha	fifi ho	hi								s	qq	s		s, s, s
fo	ha	 hi	xx		ha, ha, ha				pp	pp	s
xxx	ho	 ha	xx								pp	qq	s
*/


class SequenceInMatrix
{
    static void Main()
    {

        Console.WriteLine("Enter the row and columns of the matrix");
        Console.Write("rows = ");
        int iRows = int.Parse(Console.ReadLine());
        Console.Write("cols = ");
        int iCols = int.Parse(Console.ReadLine());

        int curSum = 1;
        int bestRow = 1;
        int bestCol = 0;
        int bestSum = 0;

        string[,] matrix = new string[iRows, iCols];
        List<string> maxSeq = new List<string>();
        for (int row = 0; row < iRows; row++)
        {
            for (int col = 0; col < iCols; col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }

        Console.WriteLine("Print matrix");
        for (int row = 0; row < iRows; row++)
        {
            for (int coll = 0; coll < iCols; coll++)
            {
                Console.Write(" {0, 5}", matrix[row, coll]);
            }
            Console.WriteLine();
        }

        //Searching in rows

        for (int row = 0; row < iRows; row++)
        {
            for (int col = 0; col < iCols - 1; col++)
            {
                curSum = ((matrix[row, col] == matrix[row, col + 1]) ? ++curSum : 1);
                if (curSum == bestSum)
                {
                    maxSeq.Add(matrix[row, col]);
                }
                else if (curSum > bestSum)
                {
                    bestSum = curSum;
                    maxSeq.Clear();
                    maxSeq.Add(matrix[row, col]);
                }
            }

            bestSum = 1;
        }

        //Searching in columns

        for (int col = 0; col < iCols; col++)
        {
            for (int row = 0; row < iRows - 1; row++)
            {
                curSum = ((matrix[row, col] == matrix[row + 1, col]) ? ++curSum : 1);
                if (curSum == bestSum)
                {
                    maxSeq.Add(matrix[row, col]);
                }
                else if (curSum > bestSum)
                {

                    bestSum = curSum;
                    maxSeq.Clear();
                    maxSeq.Add(matrix[row, col]);
                }
            }

            curSum = 1;
        }

        //Searching in diagonal

        for (int i = 0; i < iCols; i++)
        {
            for (int row = 0, col = bestCol; row < iRows - 1 && col < iCols - 1; col++, row++)
            {
                curSum = ((matrix[row, col] == matrix[row + 1, col + 1]) ? ++curSum : 1);
                if (curSum == bestSum)
                {
                    maxSeq.Add(matrix[row, col]);
                }
                else if (curSum > bestSum)
                {

                    bestSum = curSum;
                    maxSeq.Clear();
                    maxSeq.Add(matrix[row, col]);
                }
            }

            bestCol++;
            curSum = 1;
        }

        //Seaching diagonals under other diagonal

        for (int i = 0; i < iRows - 1; i++)
        {
            for (int row = bestRow, col = 0; row < iRows - 1 && col < iCols - 1; col++, row++)
            {
                curSum = ((matrix[row, col] == matrix[row + 1, col + 1]) ? ++curSum : 1);
                if (curSum == bestSum)
                {
                    maxSeq.Add(matrix[row, col]);
                }
                else if (curSum > bestSum)
                {

                    bestSum = curSum;
                    maxSeq.Clear();
                    maxSeq.Add(matrix[row, col]);
                }
            }

            bestCol++;
            curSum = 1;
        }

        Console.WriteLine("Max sequence is of {0} elemets", bestSum);
        for (int i = 0; i < maxSeq.Count; i++)
        {
            Console.Write(maxSeq[i] + " ");
        }
        Console.WriteLine();
    }
}


