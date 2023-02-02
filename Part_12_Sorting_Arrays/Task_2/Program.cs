using System;
namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(input, s => int.Parse(s));
            int num = int.Parse(Console.ReadLine());
            int l = 0;
            int r = arr.Length - 1;
            int ind = -1;
            while (l <= r)
            {
                int m = (l + r) / 2;
                if (num == arr[m])
                {
                    break;
                }
                else if (num > arr[m])
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }
            }
            ind = r + 1;
            for (int i = 0; i < arr.Length + 1; i++)
            {
                if (i == ind)
                {
                    Console.Write(num);
                    Console.Write(' ');
                }
                if (i < arr.Length)
                {
                    Console.Write(arr[i]);
                    Console.Write(' ');
                }

            }
            Console.WriteLine();

        }
    }
}