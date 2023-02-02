using System;
namespace Task_4
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
            int k = arr.Length / 4;
            int[] firstRowFirstHalf = new int[k];
            int[] firstRowSecondHalf = new int[k];
            int firstHalfIndex = 0;
            int secondHalfIndex = 0;

            int[] secondRow = new int[2 * k];
            int secondIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < k)
                {
                    firstRowFirstHalf[firstRowFirstHalf.Length - 1 - firstHalfIndex++] = arr[i];
                }
                else if (i >= k && i < 3 * k)
                {
                    secondRow[secondIndex++] = arr[i];
                }
                else
                {
                    firstRowSecondHalf[firstRowSecondHalf.Length - 1 - secondHalfIndex++] = arr[i];
                }
            }

            for (int i = 0; i < 2 * k; i++)
            {
                if (i < k)
                {
                    System.Console.Write(firstRowFirstHalf[i] + secondRow[i]);
                }
                else
                {
                    System.Console.Write(firstRowSecondHalf[i - k] + secondRow[i]);
                }

                System.Console.Write(" ");
            }
            System.Console.WriteLine();
        }
    }
}