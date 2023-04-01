using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        List<List<int>> matrix = new List<List<int>>();
        for (int i = 0; i < size; i++)
        {
            matrix.Add(new List<int>(new int[size + 1]));
        }
        matrix[0][1] = 1;

        for (int x = 1; x < size; x++)
        {
            for (int y = 1; y <= size; y++)
            {
                matrix[x][y] = matrix[x - 1][y - 1]
                    + matrix[x - 1][y];
            }
        }

        for (int x = 0; x < size; x++)
        {
            string row = new string(' ', (size - x));
            for (int y = 1; y <= size; y++)
            {
                int matrix_el = matrix[x][y];
                if (matrix_el != 0)
                {
                    row += $"{matrix_el} ";
                }
            }
            Console.WriteLine(row);
        }
    }
}