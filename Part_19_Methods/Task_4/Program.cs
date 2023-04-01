namespace Task_4
{
    internal class Program
    {
        static void printHeaderRow(int n)
        {
            System.Console.WriteLine(new string('-', 2 * n));
        }
        static void printBodyRow(int n)
        {
            System.Console.Write("-");
            for (int i = 0; i < n - 1; i++)
            {
                System.Console.Write("\\/");
            }
            System.Console.WriteLine("-");
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            printHeaderRow(n);
            for (int i = 0; i < n - 2; i++)
            {
                printBodyRow(n);
            }
            printHeaderRow(n);
        }
    }
}