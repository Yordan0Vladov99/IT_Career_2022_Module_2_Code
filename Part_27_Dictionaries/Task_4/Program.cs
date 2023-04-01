using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        var store = new Dictionary<string, Tuple<float, int>>();

        while (input != "stocked")
        {
            var tokens = input.Split(' ');
            string item = tokens[0];
            float price = float.Parse(tokens[1]);
            int amount = int.Parse(tokens[2]);

            if (!store.ContainsKey(item))
            {
                store[item] = new Tuple<float, int>(price, amount);
            }
            else
            {
                var (oldPrice, oldAmount) = store[item];
                store[item] = new Tuple<float, int>(price, oldAmount + amount);
            }

            input = Console.ReadLine();
        }

        float totalPrice = 0.0f;

        foreach (var kvp in store)
        {
            string item = kvp.Key;
            float price = kvp.Value.Item1;
            int amount = kvp.Value.Item2;
            float itemTotalPrice = price * amount;

            Console.WriteLine("{0}: ${1:F2} * {2} = ${3:F2}", item, price, amount, itemTotalPrice);
            totalPrice += itemTotalPrice;
        }

        Console.WriteLine("------------------------------");
        Console.WriteLine("Grand Total: ${0:F2}", totalPrice);
    }
}
