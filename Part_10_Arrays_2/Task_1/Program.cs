using System;
namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                System.Console.Write(arr[i] + " ");
            }
            System.Console.WriteLine();
        }
    }
}