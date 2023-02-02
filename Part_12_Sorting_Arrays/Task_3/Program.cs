using System;
namespace Task_3
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
            bool isFound = false;
            while (l <= r)
            {
                int m = (l + r) / 2;
                if (num == arr[m])
                {
                    isFound = true;
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

            Console.WriteLine(isFound ? "Yes" : "No");

        }
    }
}