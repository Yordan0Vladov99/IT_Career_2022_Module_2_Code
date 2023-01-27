namespace Task_3
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(System.Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                decimal a = decimal.Parse(System.Console.ReadLine());
                sum += a;
            }
            System.Console.WriteLine(sum);
        }
    }
}