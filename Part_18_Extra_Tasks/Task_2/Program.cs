namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            List<string> words = Console.ReadLine().Split(new char[] { ',', ' ', '.', ':', '\n' }).ToList();
            List<string> lower = new List<string>();
            List<string> upper = new List<string>();
            List<string> mixed = new List<string>();
            foreach (string word in words)
            {
                string cleaned = word.Trim();
                if (cleaned == "")
                {
                    continue;
                }
                bool isLower = true;
                bool isUpper = true;

                foreach (char c in cleaned)
                {
                    if (c < 'a' || c > 'z')
                    {
                        isLower = false;
                    }

                    if (c < 'A' || c > 'Z')
                    {
                        isUpper = false;
                    }
                }

                if (isLower)
                {
                    lower.Add(cleaned);
                }
                else if (isUpper)
                {
                    upper.Add(cleaned);
                }
                else
                {
                    mixed.Add(cleaned);
                }
            }
            System.Console.WriteLine($"Lower-case: {string.Join(", ", lower)}");
            System.Console.WriteLine($"Mixed-case: {string.Join(", ", mixed)}");
            System.Console.WriteLine($"Upper-case: {string.Join(", ", upper)}");

        }
    }
}