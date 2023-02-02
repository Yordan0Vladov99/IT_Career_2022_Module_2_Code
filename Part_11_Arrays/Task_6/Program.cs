using System;
namespace Task_6
{
    internal class Program
    {
        static void Main()
        {
            string[] groceries = Console.ReadLine().Split(' ');
            string[] quantities_input = Console.ReadLine().Split(' ');
            string[] prices_input = Console.ReadLine().Split(' ');
            long[] quantities = new long[groceries.Length];
            for (int i = 0; i < quantities_input.Length; i++)
            {
                quantities[i] = long.Parse(quantities_input[i]);
            }

            double[] prices = new double[prices_input.Length];
            for (int i = 0; i < prices_input.Length; i++)
            {
                prices[i] = double.Parse(prices_input[i]);
            }
            string command = Console.ReadLine();
            while (command != "done")
            {
                string[] command_args = command.Split(' ');
                string groc = command_args[0];
                long quant = long.Parse(command_args[1]);

                int ind = Array.IndexOf(groceries, groc);
                if (ind == -1 || quant <= 0)
                {
                    continue;
                }
                if (quant <= quantities[ind])
                {
                    System.Console.WriteLine($"{groc} X {quant} costs {quant * prices[ind]}");
                    quantities[ind] -= quant;
                }
                else
                {
                    System.Console.WriteLine($"We de not have enough {groc}");
                }

                command = Console.ReadLine();

            }

        }
    }
}