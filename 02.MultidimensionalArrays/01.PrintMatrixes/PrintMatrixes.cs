using System;

//Write a program that fills and prints a matrix of size (n, n) as shown below:
//Example for n=4:
/*a)					b)					c)					d)*
    1	5	9	13		1	8	9	16		7	11	14	16		1	12	11	10
    2	6	10	14		2	7	10	15		4	8	12	15		2	13	16	9
    3	7	11	15		3	6	11	14		2	5	9	13		3	14	15	8
    4	8	12	16		4	5	12	13		1	3	6	10		4	5	6	7
*/



class PrintMatrixes
{
    static void Main()
    {
        Console.WriteLine("Enter the number ot rows,columns of the matrix");
        int n = int.Parse(Console.ReadLine());

        PrintMatrixA(n);
        PrintMatrixB(n);
        PrintMatrixC(n);
        PrintMatrixD(n);
    }

    public static void PrintMatrix(int[,] matrix, int n )
    {
        int maxLength = (int)Math.Log10(matrix.Length) + 1;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {

                Console.Write(Convert.ToString(matrix[row, col]).PadRight(maxLength, ' ') + (col != matrix.GetLength(1) - 1 ? " " : "\n"));
            }
            Console.WriteLine();

        }
    }

    public static void PrintMatrixA(int n)
    {
        Console.WriteLine("Matrix A");
        Console.WriteLine();
        int count = 1;

        int[,] matrix = new int[n, n];
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrix[row, col] = count++;
            }
        }
        PrintMatrix(matrix, n);
    }

        public static void PrintMatrixB(int n)
    {
        Console.WriteLine("Matrix B");
        Console.WriteLine();
        int count = 1;
        int[,] matrix = new int[n, n];

        for (int col = 0; col < n; col++)
        {
            if(col % 2 == 0)
            {
                 for (int row = 0; row < n; row++)
                 {
                     matrix[row, col] = count++;
                 }
            } 
  
            else
            {
                for (int i = n - 1; i >= 0; i--)
                {
                    matrix[i, col] = count++;
                }
            }
        }
        PrintMatrix(matrix, n);
    }

      public static void PrintMatrixC(int n)
        {
            Console.WriteLine("Matrix C");
            Console.WriteLine();
            int count = 1;
            int[,] matrix = new int[n, n];
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    matrix[n - i + j - 1, j] = count++;
                }
            }
            for (int i = n - 2; i >= 0; i--)
            {
                for (int j = i; j >= 0; j--)
                {
                    matrix[i - j, n - j - 1] = count++;
                }
            }
            PrintMatrix(matrix, n);
        }
      public static void PrintMatrixD(int n)
      {
          Console.WriteLine("Matrix D ");
          Console.WriteLine();

          int x = 0;
          int y = 0;
          int direction = 0;
          int dx = 1;
          int dy = 0;
          int[,] matrix = new int[n, n];
          for (int currentValue = 1; currentValue <= n * n; currentValue++)
          {
              matrix[x, y] = currentValue;

              if (!IsValidCell(n, x + dx, y + dy) || matrix[x + dx, y + dy] > 0)
              {
                  direction = (++direction) % 4;
                  if (direction == 0)
                  {
                      dx = 1;
                      dy = 0;
                  }
                  else if (direction == 1)
                  {
                      dx = 0;
                      dy = 1;
                  }
                  else if (direction == 2)
                  {
                      dx = -1;
                      dy = 0;
                  }
                  else if (direction == 3)
                  {
                      dx = 0;
                      dy = -1;
                  }
                  else
                  {
                      Console.WriteLine("Invalid direction value: {0}", direction);
                  }
              }

              x += dx;
              y += dy;
          }

          PrintMatrix(matrix, n);
      }

      public static bool IsValidCell(int n, int x, int y)
      {
          return x >= 0 && x < n && y >= 0 && y < n;
      }

}

