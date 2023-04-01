using System;
using System.Collections.Generic;

class Program
{
    static int GetMatrixElement(List<List<int>> matrix, int x, int y)
    {
        return matrix[x][y];
    }

    static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        List<List<int>> matrix = new List<List<int>>();

        for (int i = 0; i < rows; i++)
        {
            List<int> row = new List<int>();
            string[] rowString = Console.ReadLine().Split(' ');

            for (int j = 0; j < cols; j++)
            {
                row.Add(int.Parse(rowString[j]));
            }

            matrix.Add(row);
        }

        int max = 0;
        int maxX = -1;
        int maxY = -1;

        for (int x = 0; x < rows - 1; x++)
        {
            for (int y = 0; y < cols - 1; y++)
            {
                int sum = GetMatrixElement(matrix, x, y)
                    + GetMatrixElement(matrix, x, y + 1)
                    + GetMatrixElement(matrix, x + 1, y)
                    + GetMatrixElement(matrix, x + 1, y + 1);

                if (sum > max)
                {
                    max = sum;
                    maxX = x;
                    maxY = y;
                }
            }
        }

        Console.WriteLine($"{matrix[maxX][maxY]} {matrix[maxX][maxY + 1]}");
        Console.WriteLine($"{matrix[maxX + 1][maxY]} {matrix[maxX + 1][maxY + 1]}");
    }
}