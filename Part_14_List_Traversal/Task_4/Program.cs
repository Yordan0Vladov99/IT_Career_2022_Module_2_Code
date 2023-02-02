namespace Task_4
{
    internal class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int maxElem = -1;
            int maxCount = 0;
            int currElem = nums[0];
            int currCount = 1;

            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] == currElem)
                {
                    currCount += 1;
                    if (currCount > maxCount)
                    {
                        maxElem = currElem;
                        maxCount = currCount;
                    }
                }
                else
                {
                    currElem = nums[i];
                    currCount = 1;
                }
            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(maxElem);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
}