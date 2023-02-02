namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int last = nums[nums.Count - 1];
            nums.RemoveAll(n => n == last);
            System.Console.WriteLine(string.Join(" ", nums));
        }
    }
}