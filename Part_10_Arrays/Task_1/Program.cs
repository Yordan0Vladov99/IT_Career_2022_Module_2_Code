using System;
namespace Task_1
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
            int min = arr[0];
            int max = arr[0];
            int sum = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                min = Math.Min(min, arr[i]);
                max = Math.Max(max, arr[i]);
                sum += arr[i];
            }

            System.Console.WriteLine($"Min = {min}");
            System.Console.WriteLine($"Max = {max}");
            System.Console.WriteLine($"Sum = {sum}");
            System.Console.WriteLine($"Average = {(double)sum / arr.Length:f1}");
        }
    }
}