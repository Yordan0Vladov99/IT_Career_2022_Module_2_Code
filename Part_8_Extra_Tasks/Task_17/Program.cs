namespace Task_17
{
    internal class Program
    {
        static void Main()
        {
            int num = int.Parse(System.Console.ReadLine());

            for (int candidate = 2; candidate <= num; candidate++)
            {
                bool isPrime = true;
                double sqrt = Math.Sqrt(candidate);
                for (int j = 2; j <= sqrt; j++)
                {
                    if (candidate % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                System.Console.WriteLine($"{candidate} -> {isPrime}");
            }

        }
    }
}