using System.Text;

namespace Task_4
{
    internal class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < word.Length; i++)
            {

                sb.Append(word[i]);

                if (word[i] == '>')
                {
                    i++;
                    int power = word[i] - '0';
                    for (int start = i; i < start + power && i < word.Length; i++)
                    {
                        if (word[i] == '>')
                        {
                            sb.Append(word[i]);
                            i++;
                            power += word[i] - '0' + 1;
                        }
                    }
                    i--;
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}