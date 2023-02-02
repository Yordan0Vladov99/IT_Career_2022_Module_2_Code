namespace Task_3
{
    internal class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine(string.Join(" ", nums.Where(n => n == nums.Max() || n == nums.Min()).Order()));
        }
    }
}