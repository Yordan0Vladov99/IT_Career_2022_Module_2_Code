namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine(string.Join(" ", nums.Where(n => n % 2 == 0)));
        }
    }
}