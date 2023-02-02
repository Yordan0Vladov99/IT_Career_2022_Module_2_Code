using System;
namespace Task_5
{
    internal class Program
    {
        static void Main()
        {
            string[] groceries = Console.ReadLine().Split(' ');
            string[] quantities = Console.ReadLine().Split(' ');
            string[] prices = Console.ReadLine().Split(' ');

            string groc = Console.ReadLine();
            while (groc != "done")
            {

                int ind = Array.IndexOf(groceries, groc);
                if (ind != -1)
                {
                    System.Console.WriteLine($"{groc} costs: {prices[ind]}; Available quantity: {quantities[ind]}");
                }

                groc = Console.ReadLine();

            }

        }
    }
}