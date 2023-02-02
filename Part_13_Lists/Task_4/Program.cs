namespace Task_4
{
    internal class Program
    {
        static void Main()
        {
            List<string> nums = Console.ReadLine().Split(", ").ToList();
            Console.WriteLine(string.Join("\n", nums));
        }
    }
}