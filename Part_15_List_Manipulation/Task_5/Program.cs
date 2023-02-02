namespace Task_5
{
    internal class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<bool> blasted = Enumerable.Repeat(false, nums.Count).ToList();
            List<int> parameters = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int bomb = parameters[0];
            int radius = parameters[1];
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == bomb && !blasted[i])
                {
                    int start = Math.Max(i - radius, 0);
                    int end = Math.Min(i + radius, nums.Count - 1);
                    for (int j = start; j <= end; j++)
                    {
                        blasted[j] = true;
                    }
                }
            }
            int sum = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                if (!blasted[i])
                {
                    sum += nums[i];
                }
            }
            System.Console.WriteLine(sum);
        }
    }
}