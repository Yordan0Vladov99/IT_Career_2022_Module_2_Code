using System;
namespace Task_3
{
    internal class Program
    {
        static void Main()
        {
            string[] word = Console.ReadLine().Split(' ');
            int[] arr = new int[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                arr[i] = int.Parse(word[i]);
            }
            if (arr.Length == 0)
            {
                System.Console.WriteLine("Empty Array");
                return;
            }
            int r = int.Parse(Console.ReadLine());
            int[] sum_array = new int[arr.Length];
            for (int i = 1; i <= r; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {

                    sum_array[(j + i) % arr.Length] += arr[j];
                }
            }
            System.Console.WriteLine(string.Join(' ', sum_array));
        }
    }
}