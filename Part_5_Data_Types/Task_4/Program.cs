namespace Task_4
{
    internal class Program
    {
        static void Main()
        {
            int a = int.Parse(System.Console.ReadLine());
            int b = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Before");
            System.Console.WriteLine($"a = {a}");
            System.Console.WriteLine($"b = {b}");

            int c = a;
            a = b;
            b = c;

            System.Console.WriteLine("After");
            System.Console.WriteLine($"a = {a}");
            System.Console.WriteLine($"b = {b}");

        }
    }
}