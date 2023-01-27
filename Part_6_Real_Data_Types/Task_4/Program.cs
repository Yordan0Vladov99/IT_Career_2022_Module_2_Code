namespace Task_4
{
    internal class Program
    {
        static void Main()
        {
            double a = double.Parse(System.Console.ReadLine());
            double b = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine((a + b) * 2);
            System.Console.WriteLine(a * b);
            System.Console.WriteLine(Math.Sqrt(a * a + b * b));

        }
    }
}