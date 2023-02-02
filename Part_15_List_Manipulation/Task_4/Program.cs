namespace Task_3
{
    internal class Program
    {
        static void Main()
        {
            string[] nums = Console.ReadLine().Split('|');
            Array.Reverse(nums);
            string res = "";
            foreach (string lst in nums)
            {
                res += string.Join(" ", lst.Split(' ').Where(n => n != "")) + " ";
            }
            System.Console.WriteLine(res);
        }
    }
}