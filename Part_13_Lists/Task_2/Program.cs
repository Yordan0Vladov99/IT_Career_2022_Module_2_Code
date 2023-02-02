namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int index = 0; index < nums.Count; index++)
                Console.WriteLine($"nums[{index}] = {nums[index]}");
        }
    }
}