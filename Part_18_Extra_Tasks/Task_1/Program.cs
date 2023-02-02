namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            bool hasNeighbourPair = true;
            while (hasNeighbourPair)
            {
                hasNeighbourPair = false;
                List<int> newNums = new List<int>();
                for (int i = 0; i < nums.Count - 1; i++)
                {
                    if (nums[i] == nums[i + 1] && !hasNeighbourPair)
                    {
                        nums[i + 1] *= 2;
                        hasNeighbourPair = true;
                    }
                    else
                    {
                        newNums.Add(nums[i]);
                    }
                }
                newNums.Add(nums[nums.Count - 1]);
                nums = newNums;
            }
            System.Console.WriteLine(string.Join(" ", nums));
        }
    }
}