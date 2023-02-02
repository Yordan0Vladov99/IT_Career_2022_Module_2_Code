using System;
namespace Task_4
{
    internal class Program
    {
        static void Main()
        {
            string[] items = Console.ReadLine().Split(' ');
            int[] arr = new int[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                arr[i] = int.Parse(items[i]);
            }

            if (arr.Length <= 0)
            {
                System.Console.WriteLine("Empty Array.");
                return;
            }

            for (int i = arr.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    arr[j] += arr[j + 1];
                }
            }
            System.Console.WriteLine(arr[0]);
        }
    }
}