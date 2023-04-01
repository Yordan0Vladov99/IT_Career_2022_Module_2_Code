namespace Task_3
{
    internal class Program
    {

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine();
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                PrintLine(1, i);
            }
            for (int i = n; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }
    }
}