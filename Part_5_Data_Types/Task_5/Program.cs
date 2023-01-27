namespace Task_5
{
    internal class Program
    {
        static void Main()
        {
            int a = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine(Convert.ToString(a, 16).ToUpper());
            System.Console.WriteLine(Convert.ToString(a, 2));

        }
    }
}