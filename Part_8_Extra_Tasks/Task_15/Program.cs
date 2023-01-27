namespace Task_14
{
    internal class Program
    {
        static void Main()
        {

            decimal time = decimal.Parse(System.Console.ReadLine());
            System.Console.Write($"{Math.Truncate(time)} centuries = ");
            time *= 100;

            System.Console.Write($"{Math.Truncate(time)} years = ");
            time *= 365.2422m;

            System.Console.Write($"{Math.Truncate(time)} days = ");
            time *= 24;


            System.Console.Write($"{Math.Truncate(time)} hours = ");
            time *= 60;


            System.Console.Write($"{Math.Truncate(time)} minutes = ");
            time *= 60;


            System.Console.Write($"{Math.Truncate(time)} seconds = ");
            time *= 1000;


            System.Console.Write($"{Math.Truncate(time)} milliseconds = ");
            time *= 1000;


            System.Console.Write($"{Math.Truncate(time)} microseconds = ");
            time *= 1000;


            System.Console.Write($"{Math.Truncate(time)} nanoseconds");
        }
    }
}