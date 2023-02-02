namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            string[] word = Console.ReadLine().Split(' ');
            string[] comm = Console.ReadLine().Split(' ');

            while (comm[0] != "END")
            {
                if (comm[0] == "Distinct")
                {
                    string[] distinctArr = new string[word.Length];
                    int distinctIndex = 0;
                    for (int j = 0; j < word.Length; j++)
                    {
                        bool isUnique = true;
                        for (int k = 0; k < distinctIndex; k++)
                        {
                            if (distinctArr[k] == word[j])
                            {
                                isUnique = false;
                                break;
                            }
                        }
                        if (isUnique)
                        {
                            distinctArr[distinctIndex++] = word[j];
                        }
                    }
                    word = new string[distinctIndex];
                    for (int j = 0; j < distinctIndex; j++)
                    {
                        word[j] = distinctArr[j];
                    }
                }
                else if (comm[0] == "Reverse")
                {
                    Array.Reverse(word);
                }
                else if (comm[0] == "Replace")
                {
                    int pos = int.Parse(comm[1]);
                    if (pos >= 0 && pos < word.Length)
                    {
                        string newWord = comm[2];
                        word[pos] = newWord;
                    }
                    else
                    {
                        System.Console.WriteLine("Invalid Input!");
                    }
                }
                else
                {
                    System.Console.WriteLine("Invalid input!");
                }
                comm = Console.ReadLine().Split(' ');
            }

            System.Console.WriteLine(string.Join(", ", word));

        }
    }
}