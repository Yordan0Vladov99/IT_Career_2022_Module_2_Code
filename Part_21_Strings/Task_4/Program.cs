namespace Task_4
{
    internal class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write("\\u" + ((int)word[i]).ToString("X4"));
            }
            Console.WriteLine();
        }
    }
}