using System;
namespace Task_4
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] nums = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                nums[i] = int.Parse(input[i]);
            }

            if (nums.Length == 1)
            {
                System.Console.WriteLine(nums[0]);
            }
            else if (nums.Length % 2 == 0)
            {
                System.Console.WriteLine(nums[nums.Length / 2 - 1] + " " + nums[nums.Length / 2]);
            }
            else
            {
                System.Console.WriteLine(nums[nums.Length / 2 - 1] + " " + nums[nums.Length / 2] + " " + nums[nums.Length / 2 + 1]);
            }
        }
    }
}