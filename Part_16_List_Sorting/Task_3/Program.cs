namespace Task_3
{
    internal class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> squareNums = nums.Where(n =>
            {
                double sq = Math.Sqrt(n);
                return sq == (int)sq;
            }).ToList();
            squareNums.Sort((a, b) => b.CompareTo(a));
            System.Console.WriteLine(string.Join(" ", squareNums));

        }
    }
}