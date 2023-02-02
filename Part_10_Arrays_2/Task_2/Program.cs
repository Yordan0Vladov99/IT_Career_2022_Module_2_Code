using System;
namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            string[] items = Console.ReadLine().Split(' ');
            //Reverse
            for (int i = 0; i < items.Length / 2; i++)
            {
                string temp = items[i];
                items[i] = items[items.Length - 1 - i];
                items[items.Length - 1 - i] = temp;
            }
            System.Console.WriteLine(string.Join(" ", items));

            //Reverse Again
            Array.Reverse(items);
            System.Console.WriteLine(string.Join(" ", items));

        }
    }
}