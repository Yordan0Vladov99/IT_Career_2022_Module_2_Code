using System;
namespace Task_3
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] nums = new int[k];
            int numsIndex = 0;
            nums[numsIndex] = 1;

            System.Console.Write(nums[0]);
            System.Console.Write(" ");

            for (int i = 1; i < n; i++)
            {
                int sum = 0;
                int last = Math.Min(k - 2, numsIndex++);
                for (int j = 0; j <= last; j++)
                {
                    sum += nums[j];
                    if (numsIndex >= k)
                    {

                        nums[j] = nums[j + 1];
                    }
                }

                sum += nums[last + 1];
                nums[last + 1] = sum;
                System.Console.Write(sum);
                System.Console.Write(" ");
            }


        }
    }
}