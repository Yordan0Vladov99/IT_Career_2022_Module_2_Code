namespace Task_3
{
    internal class Program
    {
        static void Main()
        {
            string map = Console.ReadLine();
            bool isFound = false;
            while (!isFound)
            {
                string[] clues = Console.ReadLine().Split(' ');
                char symbol = clues[0][0];
                int amount = int.Parse(clues[1]);
                string keyword = new string(symbol, amount);
                int index = map.IndexOf(keyword);
                if (index != -1)
                {
                    int count = 0;
                    for (int i = index; i < map.Length; i++)
                    {
                        if (map[i] == symbol)
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    System.Console.WriteLine($"Hideout found at index {index} and it is with size {count}!");
                    isFound = true;
                }
            }
        }
    }
}