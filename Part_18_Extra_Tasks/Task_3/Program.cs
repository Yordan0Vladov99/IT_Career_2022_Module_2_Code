namespace Task_3
{
    internal class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command != "Odd" && command != "Even")
            {
                string[] cmdList = command.Split(' ');
                if (cmdList[0] == "Delete")
                {
                    int removed = int.Parse(cmdList[1]);
                    nums.RemoveAll(n => n == removed);
                }
                else if (cmdList[0] == "Insert")
                {
                    int inserted = int.Parse(cmdList[1]);
                    int pos = int.Parse(cmdList[2]);
                    nums.Insert(pos, inserted);

                }
                command = Console.ReadLine();
            }

            if (command == "Odd")
            {
                System.Console.WriteLine(string.Join(" ", nums.Where(n => n % 2 != 0)));
            }
            else
            {
                System.Console.WriteLine(string.Join(" ", nums.Where(n => n % 2 == 0)));
            }


        }
    }
}