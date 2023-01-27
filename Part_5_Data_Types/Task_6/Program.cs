namespace Task_6
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(System.Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(System.Console.ReadLine());
                int b = int.Parse(System.Console.ReadLine());
                sum += a % b;
            }
            System.Console.WriteLine(sum);
        }
    }
}