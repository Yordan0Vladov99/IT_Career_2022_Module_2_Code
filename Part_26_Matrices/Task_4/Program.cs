using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int matrix_count = int.Parse(Console.ReadLine());

        List<List<List<int>>> matrices = new List<List<List<int>>>();
        string output = "";
        float averages_sum = 0.0f;

        for (int i = 0; i < matrix_count; i++)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            List<List<int>> matrix = new List<List<int>>();
            for (int j = 0; j < rows; j++)
            {
                List<int> row = Console.ReadLine().Split().Select(int.Parse).ToList();
                matrix.Add(row);
            }

            int min = matrix[0][0];
            int max = matrix[0][0];
            float avg = 0.0f;

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < cols; y++)
                {
                    int val = matrix[x][y];
                    avg += (float)val;
                    if (min > val)
                    {
                        min = val;
                    }
                    if (max < val)
                    {
                        max = val;
                    }
                }
            }

            avg /= (rows * cols);
            averages_sum += avg;
            output += $"{min} {max} {avg:0.##}\n";
            matrices.Add(matrix);
        }

        float matrix_avg = averages_sum / matrix_count;

        foreach (List<List<int>> matrix in matrices)
        {
            int above_average_elems = 0;
            foreach (List<int> row in matrix)
            {
                above_average_elems += row.Count(val => val >= matrix_avg);
            }
            output += $"{above_average_elems} ";
        }
        Console.WriteLine(output.Trim());
    }
}