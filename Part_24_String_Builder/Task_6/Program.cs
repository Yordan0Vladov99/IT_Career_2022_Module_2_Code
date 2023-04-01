namespace Task_6
{
    internal class Program
    {
        static void Main()
        {
            string keyword = Console.ReadLine();
            string sentence = Console.ReadLine();
            string censored = new string('*', keyword.Length);
            string res = "";
            for (int i = 0; i < sentence.Length; i++)
            {
                if (i + keyword.Length < sentence.Length && sentence.IndexOf(keyword, i, keyword.Length) != -1)
                {
                    res += censored;
                    i += keyword.Length - 1;
                }
                else
                {
                    res += sentence[i];
                }
            }
            System.Console.WriteLine(res);
        }
    }
}