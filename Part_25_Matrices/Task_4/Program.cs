using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int rows = int.Parse(input[0]);
        int cols = int.Parse(input[1]);

        int[][] matrix = new int[rows][];
        for (int i = 0; i < rows; i++)
        {
            matrix[i] = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
        }

        int mainDiagonalSum = 0;
        int mainEvenDiagonalSum = 0;
        int secondaryDiagonalSum = 0;
        int aboveMainSum = 0;
        int belowMainSum = 0;
        int rowSum = 0;
        int colSum = 0;

        for (int x = 0; x < rows; x++)
        {
            for (int y = 0; y < cols; y++)
            {
                if (x == y)
                {
                    mainDiagonalSum += matrix[x][y];
                    if (matrix[x][y] % 2 == 0)
                    {
                        mainEvenDiagonalSum += matrix[x][y];
                    }
                }

                if (x + y == rows - 1)
                {
                    secondaryDiagonalSum += matrix[x][y];
                }
                if (x < y)
                {
                    aboveMainSum += matrix[x][y];
                }
                if (x > y)
                {
                    belowMainSum += matrix[x][y];
                }

                if ((x == 0 || x == rows - 1) && matrix[x][y] % 2 == 0)
                {
                    rowSum += matrix[x][y];
                }
                if ((y == 0 || y == cols - 1) && matrix[x][y] % 2 != 0)
                {
                    colSum += matrix[x][y];
                }
            }
        }

        if (mainDiagonalSum == secondaryDiagonalSum && aboveMainSum % 2 == 0 && belowMainSum % 2 != 0)
        {
            Console.WriteLine("YES");
            double result = (belowMainSum + mainEvenDiagonalSum + rowSum + colSum) / 4.0;
            Console.WriteLine($"The amount of money won is: {result:F2}");
        }
        else
        {
            Console.WriteLine("NO");
            Console.WriteLine($"{mainDiagonalSum} {secondaryDiagonalSum}");
        }
    }
}
