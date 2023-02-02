
namespace Task_5
{
    internal class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] len = new int[nums.Count];
            int[] prev = new int[nums.Count];

            len[0] = 1;
            prev[0] = -1;

            for (int i = 1; i < nums.Count; i++)
            {
                int max = 0;
                int ind = -1;
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j] && len[j] > max)
                    {
                        max = len[j];
                        ind = j;
                    }
                }
                len[i] = max + 1;
                prev[i] = ind;
            }

            int maxInd = 0;
            int maxLen = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                if (len[i] > maxLen)
                {
                    maxLen = len[i];
                    maxInd = i;
                }
            }
            string res = "";
            while (true)
            {
                res = nums[maxInd] + " " + res;
                if (prev[maxInd] == -1)
                {
                    break;
                }
                maxInd = prev[maxInd];
            }
            System.Console.WriteLine(res);
        }
    }
}