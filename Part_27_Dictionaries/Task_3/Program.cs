using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var mine = new Dictionary<string, int>();

        while (input != "stop")
        {
            var element = input;
            var amount = int.Parse(Console.ReadLine());

            if (!mine.ContainsKey(element))
            {
                mine.Add(element, amount);
            }
            else
            {
                var oldAmount = mine[element];
                mine[element] = oldAmount + amount;
            }

            input = Console.ReadLine();
        }

        foreach (var element in mine.Keys)
        {
            Console.WriteLine($"{element} -> {mine[element]}");
        }
    }
}
