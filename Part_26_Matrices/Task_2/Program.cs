using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<List<char>> matrix = new List<List<char>>();

        for (int i = 0; i < 3; i++)
        {
            string input = Console.ReadLine();
            List<char> row = input.Trim().Split(" ").Select(x => x[0]).ToList();
            matrix.Add(row);
        }

        char winner = '-';
        for (int x = 0; x < 3; x++)
        {
            char start = matrix[x][0];
            if (start == '-')
            {
                continue;
            }
            bool hasWon = true;
            for (int y = 1; y < 3; y++)
            {
                if (matrix[x][y] != start)
                {
                    hasWon = false;
                    break;
                }
            }
            if (hasWon)
            {
                winner = start;
            }
        }

        if (winner == '-')
        {
            for (int y = 0; y < 3; y++)
            {
                char start = matrix[0][y];
                if (start == '-')
                {
                    continue;
                }
                bool hasWon = true;
                for (int x = 1; x < 3; x++)
                {
                    if (matrix[x][y] != start)
                    {
                        hasWon = false;
                        break;
                    }
                }
                if (hasWon)
                {
                    winner = start;
                }
            }
        }

        if (winner == '-')
        {
            if (matrix[0][0] == matrix[1][1] && matrix[0][0] == matrix[2][2])
            {
                winner = matrix[0][0];
            }
            else if (matrix[0][2] == matrix[1][1] && matrix[2][0] == matrix[0][2])
            {
                winner = matrix[0][2];
            }
        }

        if (winner == '-')
        {
            Console.WriteLine("There is no winner");
        }
        else
        {
            Console.WriteLine("The winner is: " + winner);
        }
    }
}
