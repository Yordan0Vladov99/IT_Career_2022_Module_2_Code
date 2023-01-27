namespace Task_4
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(System.Console.ReadLine());
            for (char i = 'a'; i < 'a' + n; i++)
                for (char j = 'a'; j < 'a' + n; j++)
                    for (char k = 'a'; k < 'a' + n; k++)
                        System.Console.WriteLine($"{i}{j}{k}");

        }
    }
}