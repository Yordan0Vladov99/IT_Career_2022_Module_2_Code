namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
                list.Add(int.Parse(Console.ReadLine()));
            for (int index = 0; index < list.Count; index++)
                Console.WriteLine($"list[{index}] = {list[index]}");
        }
    }
}