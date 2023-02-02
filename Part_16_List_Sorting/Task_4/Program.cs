namespace Task_4
{
    internal class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            nums.Sort();
            string res = "";
            int curr = nums[0];
            int occur = 1;
            for (int i = 1; i < nums.Count; i++)
            {
                if (curr == nums[i])
                {
                    occur += 1;
                }
                else
                {
                    res += $"{curr} -> {occur}\n";
                    curr = nums[i];
                    occur = 1;
                }
            }
            res += $"{curr} -> {occur}";
            System.Console.WriteLine(res);
        }
    }
}