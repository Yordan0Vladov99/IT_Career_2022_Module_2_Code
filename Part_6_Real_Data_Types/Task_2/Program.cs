namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            double r = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine($"{Math.PI * r * r:f12}");

        }
    }
}