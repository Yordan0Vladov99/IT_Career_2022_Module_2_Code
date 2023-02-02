namespace Task_3
{
    internal class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int last = nums[nums.Count - 1];
            nums.RemoveAll(n => n < 0);
            if (nums.Count == 0)
            {
                System.Console.WriteLine("Empty");
            }
            else
            {
                System.Console.WriteLine(string.Join(" ", nums));
            }
        }
    }
}