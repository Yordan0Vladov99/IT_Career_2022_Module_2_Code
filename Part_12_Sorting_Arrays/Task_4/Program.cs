using System;
namespace Task_4
{
    internal class Program
    {
        static void Main()
        {
            int[] first = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            int[] second = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            int firstIndex = 0;
            int secondIndex = 0;
            while (firstIndex < first.Length && secondIndex < second.Length)
            {
                if (first[firstIndex] < second[secondIndex])
                {
                    Console.Write(first[firstIndex++]);
                    Console.Write(' ');
                }
                else
                {
                    Console.Write(second[secondIndex++]);
                    Console.Write(' ');
                }
            }

            while (firstIndex < first.Length)
            {
                Console.Write(first[firstIndex++]);
                Console.Write(' ');
            }

            while (secondIndex < second.Length)
            {
                Console.Write(second[secondIndex++]);
                Console.Write(' ');
            }
        }
    }
}