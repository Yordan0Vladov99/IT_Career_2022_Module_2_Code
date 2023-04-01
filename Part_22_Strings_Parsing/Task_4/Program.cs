namespace Task_4
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            double sum = 0;

            foreach (string word in input)
            {
                char f = word[0];
                char l = word[word.Length - 1];
                string numStr = "";
                for (int i = 1; i < word.Length - 1; i++)
                {
                    numStr += word[i];
                }
                double num = double.Parse(numStr);
                if (f >= 'a' && f <= 'z')
                {
                    num *= ((int)f - 'a' + 1);
                }
                else if (f >= 'A' && f <= 'Z')
                {
                    num /= ((int)f - 'A' + 1);
                }

                if (l >= 'a' && l <= 'z')
                {
                    num += ((int)l - 'a' + 1);
                }
                else if (l >= 'A' && l <= 'Z')
                {
                    num -= ((int)l - 'A' + 1);
                }

                sum += num;

            }
            System.Console.WriteLine(sum);
        }
    }
}