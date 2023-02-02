using System;

namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            string[] first = Console.ReadLine().Split(' ');
            string[] second = Console.ReadLine().Split(' ');

            int smallerSize = Math.Min(first.Length, second.Length);
            byte bigger = 0;

            for (int i = 0; i < smallerSize; i++)
            {
                if (first[i][0] > second[i][0])
                {
                    bigger = 1;
                    break;
                }
                else if (second[i][0] > first[i][0])
                {
                    bigger = 2;
                    break;
                }
            }
            if (bigger == 0)
            {
                bigger = first.Length >= second.Length ? (byte)1 : (byte)2;
            }
            if (bigger == 2)
            {
                System.Console.WriteLine(string.Join("", first));
                System.Console.WriteLine(string.Join("", second));
            }
            else
            {
                System.Console.WriteLine(string.Join("", second));
                System.Console.WriteLine(string.Join("", first));

            }
        }
    }
}