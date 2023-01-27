namespace Task_9
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(System.Console.ReadLine());
            string word = "";
            for (int i = 0; i < n; i++)
            {
                word += System.Console.ReadLine();
            }
            System.Console.WriteLine($"The word is: {word}");
        }
    }
}