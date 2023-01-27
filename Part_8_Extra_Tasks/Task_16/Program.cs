namespace Task_16
{
    internal class Program
    {
        static void Main()
        {
            char c = System.Console.ReadLine()[0];
            if (c >= 'A' && c <= 'Z')
            {
                c = (char)(c - 'A' + 'a');
            }

            if (c == 'a' || c == 'e' || c == 'o' || c == 'u' || c == 'i')
            {
                System.Console.WriteLine("vowel");
            }
            else if (c >= '0' && c <= '9')
            {
                System.Console.WriteLine("digit");
            }
            else
            {
                System.Console.WriteLine("other");
            }

        }
    }
}