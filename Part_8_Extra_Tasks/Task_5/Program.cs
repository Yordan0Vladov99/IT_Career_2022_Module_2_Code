namespace Task_5
{
    internal class Program
    {
        static void Main()
        {
            decimal weather = decimal.Parse(System.Console.ReadLine());
            if ((int)weather == weather)
            {
                System.Console.WriteLine("Rainy");
            }
            else if (weather >= sbyte.MinValue && weather <= sbyte.MaxValue)
            {
                System.Console.WriteLine("Sunny");
            }
            else if (weather >= int.MinValue && weather <= int.MaxValue)
            {
                System.Console.WriteLine("Cloudy");
            }
            else
            {
                System.Console.WriteLine("Windy");
            }
        }
    }
}