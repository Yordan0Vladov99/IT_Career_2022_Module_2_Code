namespace Task_18
{
    internal class Program
    {
        static void Main()
        {
            double eps = 0.000001;
            double a = double.Parse(System.Console.ReadLine());
            double b = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine(Math.Abs(a - b) < eps);
        }
    }
}