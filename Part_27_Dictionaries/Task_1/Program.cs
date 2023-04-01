
class Program
{
    static void Main(string[] args)
    {
        string binding = Console.ReadLine();
        string[] input = binding.Split(' ');
        Dictionary<string, int> occurrences = new Dictionary<string, int>();

        foreach (string val in input)
        {
            string lower = val.ToLower();

            if (!occurrences.ContainsKey(lower))
            {
                occurrences.Add(lower, 1);
            }
            else
            {
                int occurs = occurrences[lower];
                occurrences[lower] = occurs + 1;
            }
        }

        List<string> output = new List<string>();
        foreach (string key in occurrences.Keys)
        {
            if (occurrences[key] % 2 != 0)
            {
                output.Add(key);
            }
        }

        Console.WriteLine(string.Join(", ", output));
    }
}