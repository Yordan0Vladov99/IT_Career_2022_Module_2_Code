namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            nums.Sort();
            System.Console.WriteLine(string.Join(" <= ", nums));

        }
    }
}