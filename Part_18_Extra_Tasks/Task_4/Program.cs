namespace Task_4
{
    internal class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> commands = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            bool isFound = false;
            for (int i = commands[1]; i < commands[0]; i++)
            {
                if (nums[i] == commands[2])
                {
                    isFound = true;
                    break;
                }
            }
            Console.WriteLine(isFound ? "YES!" : "NO!");
        }
    }
}