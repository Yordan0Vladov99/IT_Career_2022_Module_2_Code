namespace Task_3
{
    internal class Program
    {
        static void Main()
        {
            const int CAPACITY = 255;
            int amount = 0;
            int n = int.Parse(System.Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(System.Console.ReadLine());
                if (amount + num > CAPACITY)
                {
                    System.Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    amount += num;
                }
            }
            System.Console.WriteLine(amount);

        }
    }
}