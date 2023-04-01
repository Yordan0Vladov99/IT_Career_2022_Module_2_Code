namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string substr = Console.ReadLine();
            while (true)
            {
                int first = input.IndexOf(substr);
                int last = input.LastIndexOf(substr);
                if (first != -1 && first != last)
                {
                    System.Console.WriteLine("Shaked it.");
                    input = input.Remove(first, substr.Length);
                    last = input.LastIndexOf(substr);
                    input = input.Remove(last, substr.Length);
                    substr = substr.Remove(substr.Length / 2, 1);
                }
                else
                {
                    System.Console.WriteLine("No shake");
                    break;
                }
            }
            System.Console.WriteLine(input);
        }
    }
}