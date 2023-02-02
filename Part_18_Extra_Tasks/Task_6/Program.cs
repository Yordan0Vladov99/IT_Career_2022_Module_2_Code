namespace Task_6
{
    internal class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command != "done")
            {
                string[] commandArgs = command.Split(' ');
                if (commandArgs[0] == "add")
                {
                    int index = int.Parse(commandArgs[1]);
                    int elem = int.Parse(commandArgs[2]);
                    nums.Insert(index, elem);
                }
                else if (commandArgs[0] == "addMany")
                {
                    int index = int.Parse(commandArgs[1]);
                    for (int i = commandArgs.Length - 1; i >= 2; i--)
                    {
                        int elem = int.Parse(commandArgs[i]);
                        nums.Insert(index, elem);
                    }
                }
                else if (commandArgs[0] == "contains")
                {
                    int elem = int.Parse(commandArgs[1]);
                    System.Console.WriteLine(Array.IndexOf(nums.ToArray(), elem));
                }
                else if (commandArgs[0] == "remove")
                {
                    int index = int.Parse(commandArgs[1]);
                    nums.RemoveAt(index);
                }
                else if (commandArgs[0] == "shift")
                {
                    int r = int.Parse(commandArgs[1]);
                    int[] shifted = new int[nums.Count];
                    for (int i = 0; i < nums.Count; i++)
                    {
                        shifted[i] = nums[(i + r) % shifted.Length];
                    }
                    nums = shifted.ToList();
                }
                else if (commandArgs[0] == "sumPairs")
                {
                    int[] summed = new int[nums.Count];
                    int summedLen = 0;
                    for (int i = 0; i < nums.Count; i += 2)
                    {
                        summed[summedLen] = nums[i];
                        if (i != nums.Count - 1)
                        {
                            summed[summedLen] += nums[i + 1];
                        }
                        summedLen++;
                    }
                    nums = new List<int>();
                    for (int i = 0; i < summedLen; i++)
                    {
                        nums.Add(summed[i]);
                    }
                }
                else if (commandArgs[0] == "print")
                {
                    System.Console.WriteLine($"[{string.Join(", ", nums)}]");
                }
                command = Console.ReadLine();
            }
        }
    }
}