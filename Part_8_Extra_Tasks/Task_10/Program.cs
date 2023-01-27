namespace Task_10
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(System.Console.ReadLine());
            int word = 0;
            for (int i = 0; i < n; i++)
            {
                word += System.Console.ReadLine()[0];
            }

            System.Console.WriteLine($"The sum equals: {word}");
        }
    }
}