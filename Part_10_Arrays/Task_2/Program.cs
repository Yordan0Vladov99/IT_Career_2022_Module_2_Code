using System;
namespace Task_2
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

            int maxElem = -1;
            int maxCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count += 1;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxElem = arr[i];
                }
            }
            System.Console.WriteLine(maxElem);
        }
    }
}