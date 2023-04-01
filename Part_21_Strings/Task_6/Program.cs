namespace Task_6
{
    internal class Program
    {
        static void Main()
        {
            string s = Console.ReadLine();
            bool isPal = true;
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    isPal = false;
                    break;
                }
            }
            System.Console.WriteLine(isPal);
        }
    }
}