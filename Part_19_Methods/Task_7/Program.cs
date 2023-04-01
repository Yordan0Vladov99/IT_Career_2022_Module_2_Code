using System;
namespace Task_7
{
    internal class Program
    {
        static double RaiseToPower(double number, int power)
        {
            return Math.Pow(number, power);
        }
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double res = RaiseToPower(number, power);
            System.Console.WriteLine(res);
        }
    }
}