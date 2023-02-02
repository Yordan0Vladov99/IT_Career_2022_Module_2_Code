using System;
namespace Task_3
{
    internal class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                System.Console.WriteLine($"{word[i]} -> {word[i] - 'a'}");
            }
        }
    }
}